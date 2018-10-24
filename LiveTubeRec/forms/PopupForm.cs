using LiveTubeReport.Entity;
using NLog;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class PopupForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		private readonly static Option option = OptionForm.Option;

		private Channel Channel;

		public PopupForm() {
			InitializeComponent();
		}

		// TODO 複数表示時に位置をずらせるようにする
		private void SetupLocation() {
			var screanHeight = Screen.GetWorkingArea(this).Height;
			var screanWidth = Screen.GetWorkingArea(this).Width;

			var formHeight = this.Size.Height;
			var formWidth = this.Size.Width;
			// デスクトップ右上
			this.SetDesktopLocation(screanWidth - formWidth, 0);
		}

		public PopupForm(Channel channel) : this() {
			this.Channel = channel;

			this.Text = channel.Live.StartTime.ToString("F");
			imgChannel.Image = channel.Thumbnail.Image;
			lblChannelName.Text = channel.Name;
			lblLiveTitle.Text = channel.Live.Title;
			lblLiveDescription.Text = channel.Live.Description;
			tpLiveDescription.SetToolTip(lblLiveDescription, channel.Live.Description);
		}

		private void NotificationForm_Load(object sender, EventArgs e) {
			SetupLocation();

			var timer = new System.Timers.Timer(option.Notice.PopUp.ShowSec * 1000) {
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

		// フェードアウト
		private void FadeOut() {
			for (int i = 15; i >= 0; i--) {
				this.Opacity = 1.0 / 15 * i;
				Thread.Sleep(50);
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
