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
using Google.Apis.YouTube.v3.Data;

namespace LiveTubeReport.Api.Core{
	//YouTubeAPIでデータを取得し、LiveDataで返却するクラス
	public class YouTubeDataApiGateway {
		private static YouTubeService youtubeService;

		public YouTubeDataApiGateway(string apiKey) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				ApiKey = apiKey
			});
		}

		public YouTubeDataApiGateway(IConfigurableHttpClientInitializer credential) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				HttpClientInitializer = credential,
				ApplicationName = "LiveTubeReport"
			});
		}

		/// <summary>
		///チャンネルから生放送の情報を取得します
		///keylist liveID, liveTitle, liveUrl
		/// </summary>
		public SearchListResponse GetLiveInfoData(string channelID) {
			//検索条件の設定
			var request = youtubeService.Search.List("id,snippet");
			request.EventType = SearchResource.ListRequest.EventTypeEnum.Live;
			request.Type = "video";
			request.Fields = "items(id/videoId,snippet(title,description,channelTitle))";
			request.ChannelId = channelID;

			return request.Execute();
		}

		/// <summary>
		/// 指定したチャンネル情報を取得します。
		/// </summary>
		/// <param name="channelID"></param>
		/// <returns></returns>
		public SearchListResponse GetChannelData(string channelID) {
			//検索条件の設定
			var request = youtubeService.Search.List("snippet");
			request.Type = "channel";
			request.Fields = "items(snippet/title,snippet/description,snippet/thumbnails/default/url)";
			request.ChannelId = channelID;

			Dictionary<string, object> dic = new Dictionary<string, object>();

			return request.Execute();
		}
		/*
		private SubscriptionListResponse GetSubscriptions() {
			var request = youtubeService.Subscriptions.List("snippet");
			request.Mine = true;
			request.MaxResults = 50;
			request.Fields = "nextPageToken, items(snippet/title, snippet/resourceId/channelId, snippet/description, snippet/thumbnails/default/url)";

			return request.Execute();
		}
		*/
		/// <summary>
		/// ユーザの登録チャンネルを取得します。
		/// </summary>
		/// <param name="nextPageToken"></param>
		/// <returns></returns>
		public SubscriptionListResponse GetSubscriptions(string nextPageToken) {
			var request = youtubeService.Subscriptions.List("snippet");
			request.Mine = true;
			request.MaxResults = 50;
			request.PageToken = nextPageToken ?? ""; //null合体演算子
			request.Fields = "nextPageToken, items(snippet(title,publishedAt, resourceId/channelId, description, thumbnails/default/url))";
			//request.Fields = "nextPageToken, items(snippet/title, snippet/resourceId/channelId, snippet/description, snippet/thumbnails/default/url)";

			return request.Execute();
		}
	}
}