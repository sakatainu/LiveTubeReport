using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.IO;
using System.Diagnostics;
using LiveTubeReport.Entity;

namespace LiveTubeReport {
	public partial class NotificationForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public decimal CloseTime { get; set; } = 5;
		public SoundPlayer player;

		private Channel Channel;

		public NotificationForm() {
			InitializeComponent();

			// windows 10 用のデフォルト通知音
			var path = @"C:\Windows\media\Windows Notify System Generic.wav";
			if (File.Exists(path)) {
				player = new SoundPlayer(path);
			}
		}

		public NotificationForm(Channel channel) : this(){
			this.Channel = channel;

			this.Text = channel.Live.StartTime.ToString("F");
			imgChannel.Image = channel.Thumbnail.Image;
			lblChannelName.Text = channel.Name;
			lblLiveTitle.Text = channel.Live.Title;
			lblLiveDescription.Text = channel.Live.Description;
			tpLiveDescription.SetToolTip(lblLiveDescription, channel.Live.Description);
		}
		
		private void NotificationForm_Load(object sender, EventArgs e) {
			if (player != null) {
				player.Play();
			} else {
				System.Media.SystemSounds.Asterisk.Play();
			}

			var timer = new System.Timers.Timer((double)CloseTime * 1000) {
				SynchronizingObject = this
			};
			timer.Elapsed += (se, ev) => {
				FadeOut();
				this.Close();

				timer.Stop();
				timer.Dispose();
			};

			timer.Start();
		}

		private void FadeOut() {
			for (int i = 15; i >= 0; i--) {
				this.Opacity = 1.0 / 15 * i;
				System.Threading.Thread.Sleep(50);
			}
		}

		private void NotificationForm_Click(object sender, EventArgs e) {
			if (Channel?.Live.Url != null) {
				Process.Start(Channel.Live.Url);
			}
		}
	}

	public class FormLocation {
		public const string TOP_RIGHT = "1";
		public const string TOP_LEFT = "2";
		public const string BOTTOM_RIGHT = "3";
		public const string BOTTOM_LEFT = "4";
	}
}
