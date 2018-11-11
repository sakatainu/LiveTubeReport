using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using LiveTubeReport.Api.Util;
using LiveTubeReport.Entity;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class ChannelSelectForm : Form {
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public UserCredential UserCredential { get; set; }
		public DataRow[] Rows { get; set; }
		public List<string> AddedRows { get; set; }

		private int selectedCount = 0;
		private int SelectedCount {
			get {
				return selectedCount;
			}
			set {
				selectedCount = value;
				SelectCount.Text = $"[ 選択数： {selectedCount} ]";
			}
		}

		private Assembly assembly = Assembly.GetExecutingAssembly();
		private FileDataStore dataStore = new FileDataStore("LiveTubeReport");
		private readonly static Option option = OptionForm.Option;

		public ChannelSelectForm() {
			InitializeComponent();

			ChannelIDDataColumn.ColumnName = Consts.Channel.ID;
			ChannelNameDataColumn.ColumnName = Consts.Channel.Name;
			DescriptionDataColumn.ColumnName = Consts.Channel.Description;
			PublishedAtDataColumn.ColumnName = Consts.Channel.PublishedAt;
			ThumbnailDataColumn.ColumnName = Consts.Channel.Thumbnail.Image;
			ThumbnailUrlDataColumn.ColumnName = Consts.Channel.Thumbnail.Url;
			ThumbnailPathDataColumn.ColumnName = Consts.Channel.Thumbnail.Path;

			ChannelIDDGVColumn.DataPropertyName = Consts.Channel.ID;
			ChannelNameDGVColumn.DataPropertyName = Consts.Channel.Name;
			ThumbnailDGVColumn.DataPropertyName = Consts.Channel.Thumbnail.Image;
			DescriptionDGVColumn.DataPropertyName = Consts.Channel.Description;
			PublishedAtDGVColumn.DataPropertyName = Consts.Channel.PublishedAt;
		}

		private void OKButton_Click(object sender, EventArgs e) {
			SelectedCount = dataTable.Select("Selected=true").Length;

			if (AddedRows.Count != SelectedCount && AddedRows.Count + SelectedCount > option.General.ChannelMaxCount) {
				MessageBox.Show($"記録できるチャンネル数は{option.General.ChannelMaxCount}に制限されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				close_permition = false;
				return;
			}

			Rows = dataTable.Select("Selected=true");
		}

		private void CancelButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void SelectAll_Click(object sender, EventArgs e) {
			var rowsCount = 0;
			foreach (DataRow row in dataTable.Rows) {
				row["Selected"] = true;
				rowsCount++;
			}
			SelectedCount = rowsCount;
		}

		private void DeSelectAll_Click(object sender, EventArgs e) {
			foreach (DataRow row in dataTable.Rows) {
				row["Selected"] = false;
			}

			SelectedCount = 0;
		}

		private async void GetSubscriptionsList() {
			if (UserCredential == null) {
				using (var stream = assembly.GetManifestResourceStream("LiveTubeReport.client_secrets.json")) {
					UserCredential = GoogleWebAuthorizationBroker
						.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
							, "user"
							, CancellationToken.None
							, dataStore
						).Result;
				}
			}

			progressBar.Value = 0;
			Progress<int> progress = new Progress<int>(OnProgressChanged);
			Task<List<Channel>> task = Task.Run(() => {
				var youTubeData = new YouTubeDataProvider(UserCredential);
				return youTubeData.GetSubscriptions(progress);
			});

			List<Channel> list = await task;

			foreach (var channel in list) {
				DataRow row = dataTable.NewRow();

				if (AddedRows.Contains(channel.ID)) {
					row["Added"] = true;
				}
				else {
					row["Added"] = false;
				}

				row[Consts.Channel.ID] = channel.ID;
				row[Consts.Channel.Name] = channel.Name;
				row[Consts.Channel.Description] = channel.Description;
				row[Consts.Channel.PublishedAt] = channel.PublishedAt;
				row[Consts.Channel.Thumbnail.Url] = channel.Thumbnail.Url;
				row[Consts.Channel.Thumbnail.Path] = channel.Thumbnail.Path;
				row[Consts.Channel.Thumbnail.Image] = channel.Thumbnail.Image;

				dataTable.Rows.Add(row);
			}
		}

		private void OnProgressChanged(int count) {
			progressBar.Value = count;
		}

		private void ReacquireButton_Click(object sender, EventArgs e) {
			dataTable.Clear();

			if (CheckBox.Checked) {
				ClearCredential();
			}

			GetSubscriptionsList();
		}

		private void ClearCredential() {
			UserCredential = null;

			string[] filePaths = Directory.GetFiles(dataStore.FolderPath);
			foreach (string filePath in filePaths) {
				File.SetAttributes(filePath, FileAttributes.Normal);
				File.Delete(filePath);
			}
		}

		private void ChannelSelectForm_Shown(object sender, EventArgs e) {
			dataTable.Clear();
			ClearCredential();
			GetSubscriptionsList();

			SelectedCount = AddedRows.Count;
		}

		private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
			DataGridViewRow row = dataGridView.Rows[e.RowIndex];

			if (AddedRows.Contains((string)row.Cells["ChannelIDDGVColumn"].Value)) {
				row.Cells["SelectedDGVColumn"] = new DataGridViewTextBoxCell();

				foreach (DataGridViewCell cell in row.Cells) {
					cell.Style.BackColor = Color.LightGray;
				}
			}
		}

		private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if (e.ColumnIndex == 0) {
				if (dataGridView.Rows[e.RowIndex].Cells[0] is DataGridViewTextBoxCell) {
					dataGridView.Rows[e.RowIndex].Cells[0].ReadOnly = true;
					e.Value = "追加済";
				}
			}
		}

		bool close_permition = true;
		private void ChannelSelectForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (!close_permition) {
				close_permition = true;
				e.Cancel = true;
			}
		}
	}
}
