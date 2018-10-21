using LiveTubeReport.Properties;
using NLog;
using System;
using System.Data;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class OptionForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		private static Option _option;
		public static Option Option {
			get {
				if (_option != null) return _option;

				if (System.IO.File.Exists(Settings.Default.data_path + Settings.Default.option_file_name)) {
					_option = Utils.XmlDeserialize<Option>(Settings.Default.data_path + Settings.Default.option_file_name);
				}
				else {
					_option = new Option();
					_option.General.ApiKey = "AIzaSyAFZC5qhkmYhVjfVErmQmE8jCVfZd4ToSA";
					_option.General.ChannelMaxCount = 20;
					_option.General.CheckInterval = 5;


					_option.Notice.Sound.DefaultSoundAlias = "Asterisk";
					var path = @"C:\Windows\media\Windows Notify System Generic.wav";
					if (File.Exists(path)) {
						_option.Notice.Sound.DefaultSound = false;
						_option.Notice.Sound.FilePath = path;
					} else {
						_option.Notice.Sound.DefaultSound = true;
						_option.Notice.Sound.FilePath = "";
					}


					_option.Notice.PopUp.Width = 350;
					_option.Notice.PopUp.ShowSec = 3;

					_option.Notice.Balloon.ShowSec = 3;

					DirectoryUtils.SafeCreateDirectory(Settings.Default.data_path);
					Utils.XmlSerialize(Settings.Default.data_path + Settings.Default.option_file_name, _option);
				}

				return _option;
			}
			set {
				_option = value;
			}
		}

		public OptionForm() {

			InitializeComponent();

			// データソースの設定
			AppItemBindingSource.DataSource = Option.Notice.App.AppItems;
			SoundNoticeBindingSource.DataSource = Option.Notice.Sound;

			// 一般設定
			ApiKeyTextBox.DataBindings.Add(new Binding("Text", Option.General, "ApiKey"));

			// ポップアップ
			PopUpShowTimeNumericUpDown.DataBindings.Add("Value", Option.Notice.PopUp, "ShowSec");
			PopUpWidthNumericUpDown.DataBindings.Add("Value", Option.Notice.PopUp, "Width");

			// バルーン
			BalloonShowTimeNumericUpDown.DataBindings.Add("Value", Option.Notice.Balloon, "ShowSec");

			//　ブラウザ
			WebCheckBox.DataBindings.Add("Checked", Option.Notice.Web, "Enable");
		}

		private void ShowPopupButton_Click(object sender, EventArgs e) {
			this.Invoke((MethodInvoker)delegate () {
				PopupForm notificationForm = new PopupForm();
				notificationForm.Show();
			});
		}

		private void ShowBalloonButton_Click(object sender, EventArgs e) {
			MainForm mainForm = (MainForm)Owner;
			mainForm?.ShowBalloonNotification();
		}

		private void OKButton_Click(object sender, EventArgs e) {
			DirectoryUtils.SafeCreateDirectory(Settings.Default.data_path);
			Utils.XmlSerialize(Settings.Default.data_path + Settings.Default.option_file_name, _option);
		}

		private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
			e.Row.Cells["AppItemArgument"].Value = "{live_url}";
		}

		private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			OpenFileDialog.Filter = "実行ファイル(*.exe)|*.exe";
			OpenFileDialog.Title = "実行するソフトを選択してください";
			OpenFileDialog.FileOk += (object s, System.ComponentModel.CancelEventArgs cancel) => {
				var dialog = (FileDialog)s;
				if (!Path.GetExtension(dialog.FileName).Equals(".exe")) {
					MessageBox.Show("実行ファイル(*.exe)を選択してください。");
					cancel.Cancel = true;
				}
			};

			if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
				AppItemFilePathTextBox.Text = OpenFileDialog.FileName;
			}
		}

		private void AddAppItemButton_Click(object sender, EventArgs e) {
			var item = new AppNotice.AppItem();
			item.Enable = EnableAppItemCheckBox.Checked;
			item.FilePath = AppItemFilePathTextBox.Text;
			item.Argument = AppItemArgumentTextBox.Text;

			_option.Notice.App.AppItems.Add(item);
		}

		private void ChangeAppItemButton_Click(object sender, EventArgs e) {
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["AppItemEnable"].Value = EnableAppItemCheckBox.Checked;
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["AppItemPath"].Value = AppItemFilePathTextBox.Text;
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["AppItemArgument"].Value = AppItemArgumentTextBox.Text;

			dataGridView1.EndEdit();
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0) {
				ChangeAppItemButton.Enabled = true;

				EnableAppItemCheckBox.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells["AppItemEnable"].Value;
				AppItemFilePathTextBox.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["AppItemPath"].Value;
				AppItemArgumentTextBox.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["AppItemArgument"].Value;
			}
			else {
				ChangeAppItemButton.Enabled = false;
			}
		}

		private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
			if (dataGridView1.Rows.Count <= 0) {
				ChangeAppItemButton.Enabled = false;
			}
		}

		private void SoundNoticePlayButton_Click(object sender, EventArgs e) {
			Option.Notice.Sound.Play();
		}

		private void SelectSoundButton_Click(object sender, EventArgs e) {
			OpenFileDialog.InitialDirectory = Path.GetDirectoryName(Option.Notice.Sound.FilePath);
			OpenFileDialog.Filter = "音声ファイル(*.wav)|*.wav";
			OpenFileDialog.Title = "再生する音声ファイルを選択してください";
			OpenFileDialog.FileOk += (object s, System.ComponentModel.CancelEventArgs cancel) => {
				var dialog = (FileDialog)s;
				if (!Path.GetExtension(dialog.FileName).Equals(".wav")) {
					MessageBox.Show("音声ファイル(*.wav)を選択してください。");
					cancel.Cancel = true;
				}
			};

			if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
				Option.Notice.Sound.FilePath = OpenFileDialog.FileName;
			}
		}

		private void SoundNoticeDefaultCheckBox_CheckedChanged(object sender, EventArgs e) {
			var isChecked = !((CheckBox)sender).Checked;
			SoundNoticeFilePathTextBox.Enabled = isChecked;
			SelectSoundButton.Enabled = isChecked;
		}
	}
}