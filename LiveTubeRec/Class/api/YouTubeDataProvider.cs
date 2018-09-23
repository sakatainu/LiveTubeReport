using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using Google.Apis.Http;

namespace LiveTubeReport {
	//YouTubeAPIでデータを取得し、LiveDataで返却するクラス
	public class YouTubeDataProvider {
		private YouTubeService youtubeService;

		public YouTubeDataProvider(string apiKey) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				ApiKey = apiKey
			});
		}

		public YouTubeDataProvider(IConfigurableHttpClientInitializer credential) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				HttpClientInitializer = credential,
				ApplicationName = "hogehoge"
			});
		}

		/// <summary>
		///チャンネルから生放送の情報を取得します
		///keylist liveID, liveTitle, liveUrl
		/// </summary>
		public Dictionary<string, object> GetLiveInfoData(string channelID) {
			//検索条件の設定
			var request = youtubeService.Search.List("id,snippet");
			request.EventType = SearchResource.ListRequest.EventTypeEnum.Live;
			request.Type = "video";
			request.Fields = "items(id/videoId,snippet(title,description,channelTitle))";
			request.ChannelId = channelID;

			Dictionary<string, object> dic = new Dictionary<string, object>();
			dic.Add(Consts.Live.Status, false);

			//APIの発行
			var response = request.Execute();

			//データ数のカウント
			if (response.Items.Count > 0) {
				//データの整形
				dic[Consts.Live.Status] = true;
				dic[Consts.Live.ID] = response.Items[0].Id.VideoId;
				dic[Consts.Live.Title] = response.Items[0].Snippet.Title;
				dic[Consts.Live.Description] = response.Items[0].Snippet.Description;
				dic[Consts.Live.Url] = "https://www.youtube.com/watch?v=" + response.Items[0].Id.VideoId;
			}

			return dic;
		}

		//チャンネルIDからチャンネルの情報を取得します
		//keylist channelName, thumbnail
		public Dictionary<string, object> GetChannelData(string channelID) {
			//検索条件の設定
			var request = youtubeService.Search.List("snippet");
			request.Type = "channel";
			request.Fields = "items(snippet/title,snippet/description,snippet/thumbnails/default/url)";
			request.ChannelId = channelID;

			Dictionary<string, object> dic = new Dictionary<string, object>();

			//APIの発行
			var response = request.Execute();

			//データ数のカウント
			if (response.Items.Count > 0) {
				//データの整形
				dic[Consts.Channel.ID] = channelID;
				dic[Consts.Channel.Name] = response.Items[0].Snippet.Title;
				dic[Consts.Channel.Description] = response.Items[0].Snippet.Description;
				dic[Consts.Channel.Thumbnail] = response.Items[0].Snippet.Thumbnails.Default__.Url;
			}

			return dic;
		}

		private Dictionary<string, object> GetSubscriptions(string nextPageToken) {
			var request = youtubeService.Subscriptions.List("snippet");
			request.Mine = true;
			request.MaxResults = 50;
			request.Fields = "nextPageToken, items(snippet/title, snippet/resourceId/channelId, snippet/description, snippet/thumbnails/default/url)";
			if (!string.IsNullOrEmpty(nextPageToken)) {
				request.PageToken = nextPageToken;
			}

			Dictionary<string, object> dic = new Dictionary<string, object>();

			//APIの発行
			var response = request.Execute();

			//データ数のカウント
			if (response.Items.Count > 0) {
				dic["nextPageToken"] = response.NextPageToken;
				List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
				foreach (var item in response.Items) {
					list.Add(new Dictionary<string, object> {
						{Consts.Channel.Name, item.Snippet.Title },
						{Consts.Channel.ID, item.Snippet.ResourceId.ChannelId},
						{Consts.Channel.Description, item.Snippet.Description },
						{Consts.Channel.Thumbnail, item.Snippet.Thumbnails.Default__.Url }
					});
				}

				dic["itemList"] = list;
			}

			return dic;
		}

		public List<Dictionary<string, object>> GetSubscriptionsList() {
			var list = new List<Dictionary<string, object>>();

			var dic = GetSubscriptions("");
			if (dic.Keys.Count > 0) {
				list.AddRange((List<Dictionary<string, object>>)dic["itemList"]);

				while (!string.IsNullOrEmpty((string)dic["nextPageToken"])) {
					dic = GetSubscriptions((string)dic["nextPageToken"]);

					if (dic.Keys.Count > 0) {
						list.AddRange((List<Dictionary<string, object>>)dic["itemList"]);
					}
				}
			}

			return list;
		}
	}
}