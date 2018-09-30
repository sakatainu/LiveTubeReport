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
		public DataRow[] Rows { get; set; }
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public OptionForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			ChannelSelectForm selectForm = new ChannelSelectForm();
			if (selectForm.ShowDialog() == DialogResult.OK) {
				Rows = selectForm.Rows;
			}
		}

		private void btnNotificationFormSample_Click(object sender, EventArgs e) {
			this.Invoke((MethodInvoker)delegate () {
				NotificationForm notificationForm = new NotificationForm();
				notificationForm.CloseTime = numericUpDown.Value;
				notificationForm.Show();
			});
		}

		private void button2_Click(object sender, EventArgs e) {
			MainForm mainForm = (MainForm)Owner;
			mainForm.ShowBalloonNotification();
		}
	}
}