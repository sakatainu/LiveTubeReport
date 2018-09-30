using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using LiveTubeReport.Api.Util;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport {
	public partial class ChannelSelectForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public UserCredential UserCredential { get; set; }
		public DataRow[] Rows { get; set; }

		private int rowsCount = 0;
		private Assembly assembly = Assembly.GetExecutingAssembly();

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

		private void ChannelSelectForm_Shown(object sender, EventArgs e) {
		}

		private void button1_Click(object sender, EventArgs e) {
			Rows = dataTable.Select("Selected=true");
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void ToggleCheckBox(DataGridViewCellMouseEventArgs cellEvent) {
			if (cellEvent.RowIndex != -1) {
				dataGridView.Rows[cellEvent.RowIndex].Cells["Selected"].Value = !(bool)dataGridView.Rows[cellEvent.RowIndex].Cells["Selected"].Value;
				dataTable.Rows[cellEvent.RowIndex].EndEdit();
			}
		}

		private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.RowIndex != -1) {
				var isSelected = !(bool)dataGridView.Rows[e.RowIndex].Cells["Selected"].Value;
				if (isSelected) {
					rowsCount++;
				}
				else {
					rowsCount--;
				}
				dataGridView.Rows[e.RowIndex].Cells["Selected"].Value = isSelected;
				lblCount.Text = rowsCount + " ]";

				dataSet.Tables[0].Rows[e.RowIndex].EndEdit();
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			rowsCount = 0;
			foreach (DataRow row in dataTable.Rows) {
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

		private async void GetSubscriptionsList() {
			Progress<int> progress = new Progress<int>(onProgressChanged);

			Task task = Task.Run(() => {
				try {
					YouTubeDataProvider youTubeData = new YouTubeDataProvider(UserCredential);
					var list = youTubeData.GetSubscriptions(progress);

					foreach (var channel in list) {
						DataRow row = dataTable.NewRow();

						row[Consts.Channel.ID] = channel.ID;
						row[Consts.Channel.Name] = channel.Name;
						row[Consts.Channel.Description] = channel.Description;
						row[Consts.Channel.PublishedAt] = channel.PublishedAt;
						row[Consts.Channel.Thumbnail.Url] = channel.Thumbnail.Url;
						row[Consts.Channel.Thumbnail.Path] = channel.Thumbnail.Path;
						row[Consts.Channel.Thumbnail.Image] = channel.Thumbnail.Image;

						dataTable.Rows.Add(row);
					}

					rowsCount = dataTable.Select("Selected=true").Length;
					lblCount.Text = rowsCount + " ]";
				}
				catch (Exception ex) {
					logger.Error(ex, ex.Message);
					Close();
				}
			});

			await task;
		}

		private void onProgressChanged(int count) {
			progressBar.Value = count;
		}

		private void ChannelSelectForm_Load(object sender, EventArgs e) {
			//OptionForm.r
			//fileStream.Write(this.clientsec)
			/*
			string[] resnames = assembly.GetManifestResourceNames();
			foreach (string res in resnames) {
				Console.WriteLine("resource {0}", res);
			}
			Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			ResourceManager rm = new ResourceManager(assembly.GetName() + ;

			var streama = assembly.GetManifestResourceStream("LiveTubeReport.client_secrets.json");


			if (MessageBox.Show("hogehoge") == DialogResult.OK) {
				if (UserCredential == null) {
					using (var msStream = assembly.GetManifestResourceStream("LiveTubeReport.client_secrets.json")) {
						using (FileStream stream = new FileStream("file.bin", FileMode.Create, System.IO.FileAccess.Write)) {
							msStream.CopyTo(stream);
							var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
								, "user"
								, CancellationToken.None
								, new FileDataStore("LiveTubeReport")
							).Result;
						}
					}
				}

				GetSubscriptionsList();
			}
			*/
		}

		private void button5_Click(object sender, EventArgs e) {
			string[] resnames = assembly.GetManifestResourceNames();
			foreach (string res in resnames) {
				Console.WriteLine("resource {0}", res);
			}
			if (UserCredential == null) {
				using (var stream = assembly.GetManifestResourceStream("LiveTubeReport.client_secrets.json")) {
					UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
						, "user"
						, CancellationToken.None
						, new FileDataStore("LiveTubeReport")
					).Result;
				}

					//	string tmpPath = Path.GetTempFileName();
					//	using (FileStream stream = new FileStream(tmpPath, FileMode.Create, System.IO.FileAccess.Write)) {
					//		msStream.CopyTo(stream);

					//		var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(msStream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
					//			, "user"
					//			, CancellationToken.None
					//			, new FileDataStore("LiveTubeReport")
					//		).Result;

					//	}
					//}

					GetSubscriptionsList();
			}
		}

	}
}
