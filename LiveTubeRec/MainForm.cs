using System;
using System.Windows.Forms;
using NLog;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using LiveTubeReport.Properties;

/*
 * 更新日 2018/04/23
 *
 */

namespace LiveTubeReport {
	public partial class MainForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
		private static Settings settings = Properties.Settings.Default;

		private Monitor monitor;

		public MainForm() {
			InitializeComponent();

			ToolStripProfessionalRenderer renderer = new ToolStripProfessionalRenderer();
			renderer.RoundedEdges = false;
			toolStrip.Renderer = renderer;
		}

		/******************             ここから下はイベントハンドラ              *******************************/

		private void Form1_Load(object sender, EventArgs e) {
			//データセットの初期化
			liveTubeDataSet.Clear();
			DirectoryUtils.SafeCreateDirectory(@".\data");
			DirectoryUtils.SafeCreateDirectory(@".\data\image");

			if (System.IO.File.Exists(@".\data\data.xml")) {
				liveTubeDataSet.ReadXml(@".\data\data.xml");

				foreach(DataRow row in tbChannel.Rows) {
					row[dcThumbnail.ColumnName] = new Bitmap((string)row[dcThumbnailPath.ColumnName]);
				}
				logger.Info("データの読み込みに成功しました。");
			}
			else {
				liveTubeDataSet.WriteXml(@".\data\data.xml");
			}

			logger.Debug("初期設定が完了");

			ProcessExe process = new ProcessExe();
			process.SynchronizingObject = this;
			process.EnableRaisingEvents = true;

			monitor = new Monitor(tbChannel);
			monitor.LiveStartEvent += doNotification;

			monitor.Start();

			label1.Text = "[ 状態：記録中 ]";

			logger.Info("チャンネルの記録を開始しました。");
		}

		private void doNotification(object sender, LiveEventArgs e) {
			Task.Factory.StartNew(() => showNotificationForm(e.Channel));
		}

		private void showNotificationForm(Channel channel) {
			this.Invoke((MethodInvoker)delegate () {
				NotificationForm notificationForm = new NotificationForm(channel);
				notificationForm.CloseTime = 30000;
				notificationForm.Show();
			});
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			DirectoryUtils.SafeCreateDirectory(@".\data");
			liveTubeDataSet.WriteXml(@".\data\data.xml");
		}

		public void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			DataGridView dgv = (DataGridView)sender;
			//"Link"列ならば、ボタンがクリックされた
			if (dgv.Columns[e.ColumnIndex].Name == "dgvLiveURL") {
				//訪問済みにする
				DataGridViewLinkCell cell = (DataGridViewLinkCell)dgv[e.ColumnIndex, e.RowIndex];
				cell.LinkVisited = true;

				Process.Start(cell.Value.ToString());
			}
		}

		private void buttonInsert_Click(object sender, EventArgs e) {
			string input = textBoxChannelID.Text;
			if (string.IsNullOrWhiteSpace(input)) {
				return;
			}

			string channelID = ExtractChannelID(input);
			if (string.IsNullOrWhiteSpace(channelID) || hasChannelID(channelID)) {
				logger.Error("入力したURLが正しくないか、一覧に存在しているため追加できません。");

				textBoxChannelID.Focus();
				textBoxChannelID.SelectAll();
				return;
			}

			if(tbChannel.Rows.Count >= settings.ChannelLimit) {
				logger.Error("記録可能なチャンネル数が上限に達しているため追加できません。");
				textBoxChannelID.Text = "";
				return;
			}

			var row = GetChannelDataRow(channelID);
			tbChannel.Rows.Add(row);
			logger.Info("チャンネル名 " + (string)row[dcChannelName.ColumnName] + " を追加しました。");

			textBoxChannelID.Clear();
		}

		private void toolStripMenuItemDelete_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 1) {
				for (int i = 0; i < tbChannel.Rows.Count; i++) {
					var a = tbChannel.Rows[i]["channelID"];
					var b = dataGridView.SelectedRows[0].Cells["dgvChannelID"].Value;
					if (tbChannel.Rows[i]["channelID"].Equals(dataGridView.SelectedRows[0].Cells["dgvChannelID"].Value)) {
						string name = tbChannel.Rows[i]["channelName"].ToString();

						tbChannel.Rows[i].Delete();
						logger.Info("チャンネル： " + name + " を削除しました");
					}
				}
			}
		}

		private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
			if (dataGridView.SelectedRows.Count < 1) {
				toolStripMenuItemDelete.Enabled = false;
			}
			else {
				toolStripMenuItemDelete.Enabled = true;
			}
		}

		private void textBoxChannelID_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;
				buttonInsert_Click(sender, e);
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			monitor.Start();
			label1.Text = "[ 状態：記録中 ]";
			logger.Info("チャンネルの記録を開始しました。");
		}

		private void button3_Click(object sender, EventArgs e) {
			monitor.Stop();
			label1.Text = "[ 状態：停止中 ]";
			logger.Info("チャンネルの記録を停止しました。");
		}

		//更新ボタン
		private async void button2_Click(object sender, EventArgs e) {

			button2.Enabled = false;
			await Task.Run(() => monitor.CheckLiveStatus());
			button2.Enabled = true;

		}
		private void textBox_Log_TextChanged(object sender, EventArgs e) {
			if (textBox_Log.Lines.Length > 1000) {
				textBox_Log.Text = "";
			}
		}

		private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
			// ヘッダ以外のセルか？
			if (e.ColumnIndex >= 0 && e.RowIndex >= 0) {
				dataGridView.CurrentCell = dataGridView[e.ColumnIndex, e.RowIndex];
			}
			else {
				dataGridView.CurrentCell = null;
			}
		}

		private void toolStripItemOption_Click(object sender, EventArgs e) {
			OptionForm option = new OptionForm();
			if(option.ShowDialog(this) == DialogResult.OK) {
				var tmp = option.Rows.CopyToDataTable();
				tmp.Columns.Add("AddDate");
				foreach(DataRow row in tmp.Rows) {
					row["AddDate"] = DateTime.Now;
					tbChannel.ImportRow(row);
				}
			}
		}

		public void ShowNotification() {
			notifyIcon.BalloonTipTitle = "おしらせ";
			notifyIcon.BalloonTipText = "おしらせのメッセージ";
			notifyIcon.ShowBalloonTip(3000);
		}
		/******************          ここから先はプライベートメソッド            ***************************/

		//リストにチャンネルIDが登録されているかをチェック
		// 登録済み:true 未登録:false
		private bool hasChannelID(string channelID) {
			logger.Debug("start");

			var rows = tbChannel.Select(dcChannelID.ColumnName + "=" + "'" + channelID + "'");

			if (rows.Length > 0) {
				return true;
			}
			else {
				return false;
			}
		}

		//URLからチェンネルIDを取得 取得できなければ空文字を返す
		private string ExtractChannelID(string inputURL) {
			logger.Debug("Start");

			string expression = "(?<type>channel)/(?<id>.*?)(&|$|/)";

			Regex reg = new Regex(expression);
			Match match = reg.Match(inputURL);
			bool rtn = match.Success;
			if (rtn == true) {
				return match.Groups["id"].Value;
			}
			else {
				return "";
			}
		}

		//datagridviewの列ごとの処理を記述
		private void replaceDataGridView() {
			logger.Trace("");

			for (int i = 0; i < dataGridView.Rows.Count; i++) {
				//チャンネルIDからレコードを取得
				DataRow[] rows = liveTubeDataSet.Tables[0].Select("ChannelID = " + "'" + dataGridView.Rows[i].Cells["dgvChannelID"].Value.ToString() + "'");

				//チャンネルIDは一意
				if (rows.Length == 1) {
					//サムネイルをセット
					object o = rows[0]["thumbnailPath"];
					if (o != null && !"".Equals(o.ToString())) {
						dataGridView.Rows[i].Cells["dgvThumbnail"].Value = new Bitmap(o.ToString());
					}
				}
				else {
					logger.Error("チャンネルデータに誤りがあります。");
					break;
				}
			}
		}

		private void loggingLiveData() {
			foreach (DataRow row in tbChannel.Rows) {
				logger.Debug("Name          : " + row["channelName"].ToString());
				logger.Debug("LiveStatus    : " + row["liveStatus"].ToString());
			}
		}

		private DataRow GetChannelDataRow(string channelID) {
			return ConvertToDataRow(new YouTubeDataProvider(settings.ApiKey).GetChannelData(channelID));
		}

		private DataRow ConvertToDataRow(Dictionary<string, object> dic) {
			logger.Trace("");

			DataRow row = tbChannel.NewRow();

			string channelID = (string)dic[Consts.Channel.ID];
			row[dcChannelID.ColumnName] = channelID;
			row[dcChannelName.ColumnName] = dic[Consts.Channel.Name];
			row[dcDescription.ColumnName] = dic[Consts.Channel.Description];
			row[dcAddDate.ColumnName] = DateTime.Now;

			string url = dic[Consts.Channel.Thumbnail].ToString();
			string path = @".\data\image\" + channelID + ".png";

			row[dcThumbnailUrl.ColumnName] = url;
			row[dcThumbnailPath.ColumnName] = path;

			Bitmap bmp = null;
			if (!System.IO.File.Exists(path)) {
				bmp = new Bitmap(Utils.loadImageFromURL(url));
				bmp.Save(@".\data\image\" + channelID + ".png", System.Drawing.Imaging.ImageFormat.Png);
			}
			else {
				bmp = new Bitmap(path);
			}

			row[dcThumbnail.ColumnName] = bmp;

			return row;
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if(e.ColumnIndex == dgvStatus.Index) {
				if ((bool)e.Value) {
					e.Value = "配信中";
				} else {
					e.Value = "未配信";
				}
			}
		}
	}
}
