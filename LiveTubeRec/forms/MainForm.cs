using LiveTubeReport.Api.Util;
using LiveTubeReport.Entity;
using LiveTubeReport.Properties;
using NLog;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class MainForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		private readonly static Option option = OptionForm.Option;

		private Monitor monitor;

		private readonly string dataPath = Settings.Default.data_path + Settings.Default.data_file_name;
		private readonly string imagePath = Settings.Default.data_path + Settings.Default.image_path;

		public MainForm() {
			InitializeComponent();

			// 設定関連の読み込み
			this.Size = Settings.Default.form_size;

			dcChannelID.ColumnName = Consts.Channel.ID;
			dcChannelName.ColumnName = Consts.Channel.Name;
			dcAddDate.ColumnName = Consts.Channel.AddDate;
			dcDescription.ColumnName = Consts.Channel.Description;
			dcThumbnail.ColumnName = Consts.Channel.Thumbnail.Image;
			dcThumbnailUrl.ColumnName = Consts.Channel.Thumbnail.Url;
			dcThumbnailPath.ColumnName = Consts.Channel.Thumbnail.Path;
			dcLastRequestTime.ColumnName = Consts.Channel.LastRequestTime;
			dcNextRequestTime.ColumnName = Consts.Channel.NextRequestTime;

			dcLiveStatus.ColumnName = Consts.Live.Status;
			dcLiveID.ColumnName = Consts.Live.ID;
			dcLiveTitle.ColumnName = Consts.Live.Title;
			dcLiveDescription.ColumnName = Consts.Live.Description;
			dcLiveUrl.ColumnName = Consts.Live.Url;
			dcLiveStartTime.ColumnName = Consts.Live.StartTime;
			dcLiveEndTime.ColumnName = Consts.Live.EndTime;

			dgvChannelID.DataPropertyName = dcChannelID.ColumnName;
			dgvChannelName.DataPropertyName = dcChannelName.ColumnName;
			dgvAddDate.DataPropertyName = dcAddDate.ColumnName;
			dgvDescription.DataPropertyName = dcDescription.ColumnName;
			dgvThumbnail.DataPropertyName = dcThumbnail.ColumnName;
			dgvLastRequestDate.DataPropertyName = dcLastRequestTime.ColumnName;

			dgvStatus.DataPropertyName = dcLiveStatus.ColumnName;
			dgvLiveID.DataPropertyName = dcLiveID.ColumnName;
			dgvLiveTitle.DataPropertyName = dcLiveTitle.ColumnName;
			dgvLiveURL.DataPropertyName = dcLiveUrl.ColumnName;
			dgvLiveDescription.DataPropertyName = dcLiveDescription.ColumnName;
			dgvLiveStartTime.DataPropertyName = dcLiveStartTime.ColumnName;
			dgvLiveEndTime.DataPropertyName = dcLiveEndTime.ColumnName;

			ToolStripProfessionalRenderer renderer = new ToolStripProfessionalRenderer {
				RoundedEdges = false
			};
			toolStrip.Renderer = renderer;
		}

		/******************             ここから下はイベントハンドラ              *******************************/

		private void Form1_Load(object sender, EventArgs e) {
			//データセットの初期化
			liveTubeDataSet.Clear();
			DirectoryUtils.SafeCreateDirectory(imagePath);

			if (File.Exists(dataPath)) {
				liveTubeDataSet.ReadXml(dataPath);

				foreach (DataRow row in tbChannel.Rows) {
					row[Consts.Channel.Thumbnail.Image] = new Bitmap((string)row[Consts.Channel.Thumbnail.Path]);
				}
				logger.Info("データの読み込みに成功しました。");
			}
			else {
				liveTubeDataSet.WriteXml(dataPath);
			}

			logger.Debug("初期設定が完了");

			monitor = new Monitor(tbChannel);
			monitor.LiveStartEvent += ActionLiveStartEventHandler;
			monitor.LiveEndEvent += ActionLiveEndEventHandler;
			monitor.Start();

			label1.Text = "[ 状態：記録中 ]";

			logger.Info("チャンネルの記録を開始しました。");
		}

		private void ActionLiveEndEventHandler(object sender, LiveEventArgs e) {
			// Do something
		}

		private void ActionLiveStartEventHandler(object sender, LiveEventArgs e) {
			Channel channel = e.Channel;

			if (option.Notice.PopUp.Enable) {
				Invoke((MethodInvoker) delegate{
					PopupForm notificationForm = new PopupForm(channel);
					notificationForm.Show();
				});
			}

			if (option.Notice.Web.Enable) {
				Process.Start(channel.Live.Url);
			}

			if (option.Notice.Sound.Enable) {
				option.Notice.Sound.Play();
			}

			if (option.Notice.App.Enable) {
				foreach(var item in option.Notice.App.AppItems) {
					if (!item.Enable) continue;
					if (string.IsNullOrWhiteSpace(item.FilePath)) continue;

					var arg = item.Argument;
					arg = arg.Replace("{channel_id}", $"\"{channel.ID}\"");
					arg = arg.Replace("{channel_name}", $"\"{channel.Name}\"");
					arg = arg.Replace("{live_id}", $"\"{channel.Live.ID}\"");
					arg = arg.Replace("{live_title}", $"\"{channel.Live.Title}\"");
					arg = arg.Replace("{live_url}", $"\"{channel.Live.Url}\"");
					arg = arg.Replace("{live_start_time}", $"\"{channel.Live.StartTime}\"");

					Process.Start(item.FilePath, arg);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			DirectoryUtils.SafeCreateDirectory(@".\data");
			liveTubeDataSet.WriteXml(@".\data\data.xml");
			if (this.WindowState != FormWindowState.Normal) {
				// 通常のウィンドウ状態でフォームの位置とサイズを保存する
				Properties.Settings.Default.form_size = this.RestoreBounds.Size;
				Properties.Settings.Default.form_location = this.RestoreBounds.Location;
			}
			else {
				// 現在のフォームのサイズを保存する
				Properties.Settings.Default.form_size = this.Size;
			}
			Settings.Default.Save();
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
			if (string.IsNullOrWhiteSpace(channelID) || HasChannelID(channelID)) {
				logger.Error("入力したURLが正しくないか、一覧に存在しているため追加できません。");

				textBoxChannelID.Focus();
				textBoxChannelID.SelectAll();
				return;
			}

			if (tbChannel.Rows.Count >= 20) {
				logger.Error("記録可能なチャンネル数が上限に達しているため追加できません。");
				textBoxChannelID.Text = "";
				return;
			}

			var row = GetChannelDataRow(channelID);
			tbChannel.Rows.Add(row);
			logger.Info("チャンネル名 " + (string)row[Consts.Channel.Name] + " を追加しました。");

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
			option.ShowDialog(this);
		}

		public void ShowBalloonNotification() {
			notifyIcon.BalloonTipTitle = "おしらせ";
			notifyIcon.BalloonTipText = "おしらせのメッセージ";
			notifyIcon.ShowBalloonTip(3000);
		}
		/******************          ここから先はプライベートメソッド            ***************************/

		//リストにチャンネルIDが登録されているかをチェック
		// 登録済み:true 未登録:false
		private bool HasChannelID(string channelID) {
			logger.Debug("start");

			var rows = tbChannel.Select(Consts.Channel.ID + "=" + "'" + channelID + "'");

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
			return ToDataRow(new YouTubeDataProvider("").GetChannelData(channelID));
		}

		private DataRow ToDataRow(Channel channel) {
			logger.Trace("");

			DataRow row = tbChannel.NewRow();

			row[Consts.Channel.ID] = channel.ID;
			row[Consts.Channel.Name] = channel.Name;
			row[Consts.Channel.Description] = channel.Description;
			row[Consts.Channel.AddDate] = DateTime.Now;
			row[Consts.Channel.Thumbnail.Url] = channel.Thumbnail.Url;
			row[Consts.Channel.Thumbnail.Path] = channel.Thumbnail.Path;
			row[Consts.Channel.Thumbnail.Image] = channel.Thumbnail.Image;

			return row;
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if (e.ColumnIndex == dgvStatus.Index) {
				if ((bool)e.Value) {
					e.Value = "配信中";
				}
				else {
					e.Value = "未配信";
				}
			}
		}

		private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void 登録チャンネルの取得ToolStripMenuItem_Click(object sender, EventArgs e) {
			var confirm = new ConfirmDialog();

			if (confirm.ShowDialog() != DialogResult.OK) {
				return;
			}

			var form = new ChannelSelectForm();

			if (form.ShowDialog() == DialogResult.OK) {
				if (form.Rows.Length <= 0) {
					return;
				}

				// TODO 重複チャンネル処理
				var tmp = form.Rows.CopyToDataTable();
				tmp.Columns.Add(Consts.Channel.AddDate);
				foreach (DataRow row in tmp.Rows) {
					var now = DateTime.Now;
					row[Consts.Channel.AddDate] = now;
					tbChannel.ImportRow(row);
				}
			}
		}

		private void フォルダを開くToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(@".\");
		}

		private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
			VersionInfo form = new VersionInfo();
			form.ShowDialog();
		}

		private void youTubeトップページVToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start("https://www.youtube.com");
		}

		private void youTubeLiveトップページLToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC4R8DWoMoI7CAwX8_LjQHig");
		}
	}
}
