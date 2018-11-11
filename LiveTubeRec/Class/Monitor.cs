using LiveTubeReport.Api.Util;
using LiveTubeReport.Entity;
using LiveTubeReport.Properties;
using LiveTubeReport.View;
using NLog;
using System;
using System.Data;
using System.Drawing;
using System.Timers;

namespace LiveTubeReport {
	public class Monitor {
		private static Logger logger = LogManager.GetCurrentClassLogger();

		private static Option option = OptionForm.Option;

		private Timer timer;
		private DataTable table;
		private YouTubeDataProvider provider;

		public event EventHandler<LiveEventArgs> LiveStartEvent;
		public event EventHandler<LiveEventArgs> LiveEndEvent;

		public Monitor(DataTable table) {
			timer = new Timer();
			timer.Elapsed += new ElapsedEventHandler(CheckLiveStatus);

			timer.Interval = option.General.CheckInterval * 60000;

			this.table = table;

			provider = new YouTubeDataProvider(option.General.ApiKey);
		}

		private void CheckLiveStatus(object sender, ElapsedEventArgs e) {
			CheckLiveStatus();
		}

		private bool keepOn;
		public void CheckLiveStatus() {
			logger.Info("ライブ情報の取得を開始します...");

			int count = 0;
			keepOn = true;
			foreach (DataRow row in table.Rows) {
				if (!keepOn) break;

				string channelName = (string)row[Consts.Channel.Name];
				string channelID = (string)row[Consts.Channel.ID];

				try {
					var live = provider.GetLiveInfoData(channelID);
					logger.Info($"ライブ情報の取得に成功しました。    {++count} / {table.Rows.Count}");

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
						args.Channel.Live.ID = (string)row[Consts.Channel.ID];
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
				catch (Exception e) {
					logger.Error(e);
				}
			}
		}

		public void Start() {
			timer.Start();
			logger.Info("チャンネルの記録を開始しました。");
		}

		public void Stop() {
			keepOn = false;
			timer.Stop();
			logger.Info("チャンネルの記録を停止しました。");
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
