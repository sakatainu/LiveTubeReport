using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.Util.Store;
using System.Threading;

namespace LiveTubeReport {
	public partial class OptionForm : Form {

		private const string CLIENT_ID = "680837152266-n7hrac1ukr4hl3ro7qpoq34tkiiesp19.apps.googleusercontent.com";
		private const string CLIENT_SECRET = "vCe5_eXu2ZS5QMQyTSt159ow";
		private const string API_KEY = "";
		private const string PROFILE_ID = "";

		public OptionForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read)) {
					var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.Youtube }
				   , "user"
				   , CancellationToken.None
				   , new FileDataStore("LiveTubeReport")
			   ).Result;
				}
			}
			catch (AggregateException) {
				// donothing
			}

		}
	}
}