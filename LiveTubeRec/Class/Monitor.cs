using LiveTubeReport.Properties;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LiveTubeReport {
	public class Monitor {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
		private static Settings settings = Properties.Settings.Default;

		private Timer timer;
		private DataTable table;
		private YouTubeDataProvider provider;

		public event EventHandler<LiveEventArgs> LiveStartEvent;
		public event EventHandler<LiveEventArgs> LiveEndEvent;

		public Monitor(DataTable table) {
			//タイマー
			timer = new Timer();
			timer.Elapsed += new ElapsedEventHandler(CheckLiveStatus);
			timer.Interval = settings.Interval * 60000; //msec

			//チャンネルテーブル
			this.table = table;

			//YouTubeApi
			provider = new YouTubeDataProvider(settings.ApiKey);
		}

		private void CheckLiveStatus(object sender, ElapsedEventArgs e) {
			CheckLiveStatus();
		}

		public void CheckLiveStatus() {
			foreach (DataRow row in table.Rows) {
				string channelName = (string)row["ChannelName"];
				logger.Info("チャンネル " + channelName + " のライブ情報を取得します...");

				string channelID = (string)row["ChannelID"];
				var dic = provider.GetLiveInfoData(channelID);

				var status = dic[Consts.Live.Status];
				bool statusBefore = (bool)row["LiveStatus"];
				row["LiveStatus"] = status;

				if (!statusBefore && (bool)status) {
					row["LiveDescription"] = dic[Consts.Live.Description];
					row["LiveLastRequestTime"] = DateTime.Now;
					row["LiveNextRequestTime"] = DateTime.Now.AddMilliseconds(timer.Interval);
					row["LiveID"] = dic[Consts.Live.ID];
					row["LiveTitle"] = dic[Consts.Live.Title];
					row["LiveUrl"] = dic[Consts.Live.Url];
					row["LiveStartTime"] = DateTime.Now;

					LiveEventArgs args = new LiveEventArgs();
					args.Channel.Name = (string)row["ChannelName"];
					args.Channel.Thumbnail = (Bitmap)row["Thumbnail"];
					args.Channel.Live.Title = (string)row["LiveTitle"];
					args.Channel.Live.URL = "https://www.youtube.com/watch?v=" + (string)dic[Consts.Live.ID];
					args.Channel.Live.StartTime = (DateTime)row["LiveStartTime"];
					args.Channel.Live.Description = (string)row["LiveDescription"];

					onLiveStart(row, args);
				}
				else if (statusBefore && !(bool)status) {
					row["LiveEndTime"] = DateTime.Now;

					LiveEventArgs args = new LiveEventArgs();
					args.channelID = channelID;
					onLiveEnd(row, args);
				}
			}
		}

		public void Start() {
			timer.Start();
		}

		public void Stop() {
			timer.Stop();
		}

		protected virtual void onLiveStart(DataRow row, LiveEventArgs e) {
			EventHandler<LiveEventArgs> handler = LiveStartEvent;
			if (handler != null) {
				handler(row, e);
			}
		}

		protected virtual void onLiveEnd(DataRow row, LiveEventArgs e) {
			EventHandler<LiveEventArgs> handler = LiveEndEvent;
			if (handler != null) {
				handler(row, e);
			}
		}
	}

	public class LiveEventArgs : EventArgs {
		public string channelID { get; set; }
		public DataRow DataRow { get; set; }
		public Channel Channel { get; set; }

		public LiveEventArgs() {
			Channel = new Channel();
		}
	}
}
