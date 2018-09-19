using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LiveTubeReport
{
	public class Monitor{
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		private Timer timer;
		private DataTable table;
		private YouTubeDataProvider provider;
		private Config config;

		public Monitor(DataTable table) {
			//設定ファイル
			config = new Config(@".\config\config.ini");
			
			//タイマー
			timer = new Timer();
			timer.Elapsed += new ElapsedEventHandler(CheckLiveStatus);
			timer.Interval = 300000; //msec

			//チャンネルテーブル
			this.table = table;

			//YouTubeApi
			provider = new YouTubeDataProvider(config.ApiKey);
		}

		public void CheckLiveStatus(object sender, ElapsedEventArgs e) {
			CheckLiveStatus();
		}

		public void CheckLiveStatus() {
			foreach (DataRow row in table.Rows) {
				string channelName = (string)row["ChannelName"];
				logger.Info("チャンネル " + channelName + " のライブ情報を取得します...");

				var dic = provider.GetLiveInfoData((string)row["ChannelID"]);

				var status = dic[Consts.Live.Status];
				row["LiveStatus"] = status;
				row["LiveLastRequestTime"] = DateTime.Now;
				row["LiveNextRequestTime"] = DateTime.Now.AddMilliseconds(timer.Interval);

				if ((bool)status) {
					row["LiveID"] = dic[Consts.Live.ID];
					row["LiveTitle"] = dic[Consts.Live.Title];
					row["LiveUrl"] = dic[Consts.Live.Url];
				}
			}
		}

		public void Start() {
			timer.Start();
		}

		public void Stop() {
			timer.Stop();
		}
	}
}
