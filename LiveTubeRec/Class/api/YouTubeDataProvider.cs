using Google.Apis.Http;
using LiveTubeReport.Api.Core;
using LiveTubeReport.Entity;
using System;
using System.Collections.Generic;

namespace LiveTubeReport.Api.Util {
	public class YouTubeDataProvider : YouTubeDataApiGateway {
		public YouTubeDataProvider(string apiKey) : base(apiKey) { }
		public YouTubeDataProvider(IConfigurableHttpClientInitializer credential) : base(credential) { }
		
		/// <summary>
		/// ライブ情報を取得する
		/// </summary>
		/// <param name="channelID"></param>
		/// <returns></returns>
		public new Live GetLiveInfoData(string channelID) {
			var response = base.GetLiveInfoData(channelID);
			if (response.Items.Count <= 0) {
				return new Live() { Status = false };
			}

			var item = response.Items[0];

			Live live = new Live {
				Status = true,
				ID = item.Id.VideoId,
				Title = item.Snippet.Title,
				Description = item.Snippet.Description,
				Url = "https://www.youtube.com/watch?v=" + item.Id.VideoId
			};

			return live;
		}

		/// <summary>
		/// チャンネル情報を取得する
		/// </summary>
		/// <param name="channelID"></param>
		/// <returns></returns>
		public new Channel GetChannelData(string channelID) {
			var res = base.GetChannelData(channelID);

			if (res.Items.Count <= 0) {
				return null;
			}

			var item = res.Items[0];

			var channel = new Channel {
				ID = item.Id.ChannelId,
				Name = item.Snippet.Title,
				Description = item.Snippet.Description,
			};
			channel.Thumbnail.Url = item.Snippet.Thumbnails.Default__.Url;

			return channel;
		}

		/// <summary>
		/// ユーザーの登録チャンネルを取得する
		/// </summary>
		/// <returns></returns>
		public List<Channel> GetSubscriptions() {
			var list = new List<Channel>();

			string nextPageToken = null;
			do {
				var res = base.GetSubscriptions(nextPageToken);
				foreach (var item in res.Items) {
					var channel = new Channel() {
						ID = item.Snippet.ResourceId.ChannelId,
						Name = item.Snippet.Title,
						Description = item.Snippet.Description,
						PublishedAt = item.Snippet.PublishedAt ?? new DateTime()
					};
					channel.Thumbnail.Url = item.Snippet.Thumbnails.Default__.Url;

					list.Add(channel);
				}
				nextPageToken = res.NextPageToken;
			} while (!string.IsNullOrEmpty(nextPageToken));

			list.Sort((a, b) => DateTime.Compare(b.PublishedAt, a.PublishedAt));

			return list;
		}

		/// <summary>
		/// ユーザの登録チャンネルを取得する
		/// </summary>
		/// <param name="progress"></param>
		/// <returns></returns>
		public List<Channel> GetSubscriptions(IProgress<int> progress) {
			var list = new List<Channel>();

			string nextPageToken = null;
			do {
				var res = base.GetSubscriptions(nextPageToken);
				int channelCount = res.PageInfo.TotalResults ?? 0;

				foreach (var item in res.Items) {
					var channel = new Channel() {
						ID = item.Snippet.ResourceId.ChannelId,
						Name = item.Snippet.Title,
						Description = item.Snippet.Description,
						PublishedAt = item.Snippet.PublishedAt ?? new DateTime()
					};
					channel.Thumbnail.Url = item.Snippet.Thumbnails.Default__.Url;

					list.Add(channel);

					int prog = (int)((double)list.Count / (double)channelCount * (double)100);
					progress.Report(prog);
				}
				nextPageToken = res.NextPageToken;
			} while (!string.IsNullOrEmpty(nextPageToken));

			list.Sort((a, b) => DateTime.Compare(b.PublishedAt, a.PublishedAt));

			progress.Report(100);
			return list;
		}
	}
}
