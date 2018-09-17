using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LiveTubeReport {
	public partial class OptionForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public OptionForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read)) {
					var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }
						, "user"
						, CancellationToken.None
						, new FileDataStore("LiveTubeReport")
					).Result;

					YouTubeDataProvider youTubeDataProvider = new YouTubeDataProvider(credential);
					List<Dictionary<string, object>> list = youTubeDataProvider.GetSubscriptionsList();

					ChannelSelectForm selectForm = new ChannelSelectForm();
					selectForm.argument = list;
					selectForm.ShowDialog();
				}
			}
			catch (Exception ex) {
				logger.Debug(ex.ToString());
			}
		}
	}
}