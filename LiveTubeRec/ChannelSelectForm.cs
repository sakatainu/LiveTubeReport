using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport {
	public partial class ChannelSelectForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public DataRow[] Rows { get; set; }
		private int rowsCount = 0;

		public ChannelSelectForm() {
			InitializeComponent();
		}

		private void ChannelSelectForm_Shown(object sender, EventArgs e) {
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			try {
				using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read)) {
					var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
						, "user"
						, CancellationToken.None
						, new FileDataStore("LiveTubeReport")
					).Result;

					YouTubeDataProvider youTubeDataProvider = new YouTubeDataProvider(credential);
					list = youTubeDataProvider.GetSubscriptionsList();
				}
			}
			catch (Exception ex) {
				logger.Error(ex, ex.Message);
				Close();
			}

			int index = 1;
			foreach (var dic in list) {
				DataRow row = dataTable.NewRow();
				row["Index"] = index++;
				string channelID = (string)dic[Consts.Channel.ID];
				row["ChannelID"] = channelID;
				row["ChannelName"] = dic[Consts.Channel.Name];
				row["Description"] = dic[Consts.Channel.Description];

				string url = (string)dic[Consts.Channel.Thumbnail];
				string path = @".\data\image\" + channelID + ".png";

				row["ThumbnailUrl"] = url;
				row["ThumbnailPath"] = path;

				if (!System.IO.File.Exists(path)) {
					Bitmap bmp = new Bitmap(Utils.loadImageFromURL(url));
					bmp.Save(@".\data\image\" + channelID + ".png", System.Drawing.Imaging.ImageFormat.Png);
				}
				row["Thumbnail"] = new Bitmap(path);
				row["Selected"] = true;

				dataTable.Rows.Add(row);
			}

			rowsCount = dataTable.Select("Selected=true").Length;
			lblCount.Text = rowsCount + " ]";
		}

		private void button1_Click(object sender, EventArgs e) {
			Rows = dataTable.Select("Selected=true");
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void ToggleCheckBox(DataGridViewCellMouseEventArgs cellEvent) {
			if (cellEvent.RowIndex != -1) 
			{
				dataGridView.Rows[cellEvent.RowIndex].Cells["Selected"].Value = !(bool)dataGridView.Rows[cellEvent.RowIndex].Cells["Selected"].Value;
				dataTable.Rows[cellEvent.RowIndex].EndEdit();
			}
		}

		private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.RowIndex != -1) {
				var isSelected = !(bool)dataGridView.Rows[e.RowIndex].Cells["Selected"].Value;
				if (isSelected) {
					rowsCount++;
				} else {
					rowsCount--;
				}
				dataGridView.Rows[e.RowIndex].Cells["Selected"].Value = isSelected;
				lblCount.Text = rowsCount + " ]";

				dataSet.Tables[0].Rows[e.RowIndex].EndEdit();
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			rowsCount = 0;
			foreach(DataRow row in dataTable.Rows) {
				row["Selected"] = true;
				rowsCount++;
			}
			lblCount.Text = rowsCount + " ]";
		}

		private void button4_Click(object sender, EventArgs e) {
			foreach (DataRow row in dataTable.Rows) {
				row["Selected"] = false;
			}

			lblCount.Text = 0 + " ]";
		}
	}
}
