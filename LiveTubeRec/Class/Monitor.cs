using LiveTubeReport.Api.Util;
using LiveTubeReport.Entity;
using LiveTubeReport.Properties;
using NLog;
using System;
using System.Data;
using System.Drawing;
using System.Timers;

namespace LiveTubeReport {
	public class Monitor {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		private Timer timer;
		private DataTable table;
		private YouTubeDataProvider provider;

		public event EventHandler<LiveEventArgs> LiveStartEvent;
		public event EventHandler<LiveEventArgs> LiveEndEvent;

		public Monitor(DataTable table) {
			//タイマー
			timer = new Timer();
			timer.Elapsed += new ElapsedEventHandler(CheckLiveStatus);
			// ひとまず設定値*1分 
			//timer.Interval = Settings.Default.check_interval_min * 60000;

			//チャンネルテーブル
			this.table = table;

			//YouTubeApi
			//provider = new YouTubeDataProvider(Settings.Default.api_key);
		}

		private void CheckLiveStatus(object sender, ElapsedEventArgs e) {
			CheckLiveStatus();
		}

		public void CheckLiveStatus() {
			foreach (DataRow row in table.Rows) {
				string channelName = (string)row[Consts.Channel.Name];
				logger.Info("チャンネル " + channelName + " のライブ情報を取得します...");

				string channelID = (string)row[Consts.Channel.ID];
				var live = provider.GetLiveInfoData(channelID);

				var status = live.Status;
				bool statusBefore = (bool)row[Consts.Live.Status];
				row[Consts.Live.Status] = status;
				row[Consts.Channel.LastRequestTime] = DateTime.Now;
				row[Consts.Channel.NextRequestTime] = DateTime.Now.AddMilliseconds(timer.Interval);

				if (!statusBefore && (bool)status) {
					row[Consts.Live.ID] = live.ID;
					row[Consts.Live.Description] = live.Description;
					row[Consts.Live.Title] = live.Title;
					row[Consts.Live.Url] = live.Url;
					row[Consts.Live.StartTime] = DateTime.Now;

					LiveEventArgs args = new LiveEventArgs();
					args.Channel.ID = (string)row[Consts.Channel.ID];
					args.Channel.Name = (string)row[Consts.Channel.Name];
					args.Channel.Thumbnail.Image = (Bitmap)row[Consts.Channel.Thumbnail.Image];
					args.Channel.Live.Title = (string)row[Consts.Live.Title];
					args.Channel.Live.Url = (string)row[Consts.Live.Url];
					args.Channel.Live.StartTime = (DateTime)row[Consts.Live.StartTime];
					args.Channel.Live.Description = (string)row[Consts.Live.Description];

					OnLiveStart(row, args);
				}
				else if (statusBefore && !(bool)status) {
					row[Consts.Live.EndTime] = DateTime.Now;

					LiveEventArgs args = new LiveEventArgs();
					OnLiveEnd(row, args);
				}
			}
		}

		public void Start() {
			timer.Start();
		}

		public void Stop() {
			timer.Stop();
		}

		protected virtual void OnLiveStart(DataRow row, LiveEventArgs e) {
			LiveStartEvent?.Invoke(row, e);
		}

		protected virtual void OnLiveEnd(DataRow row, LiveEventArgs e) {
			LiveEndEvent?.Invoke(row, e);
		}
	}

	public class LiveEventArgs : EventArgs {
		public Channel Channel { get; set; }

		public LiveEventArgs() {
			Channel = new Channel();
		}
	}
}
