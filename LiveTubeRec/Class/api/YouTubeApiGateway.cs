using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;

namespace LiveTubeReport.Api.Core {
	public class YouTubeDataApiGateway {
		private static YouTubeService youtubeService;

		/// <summary>
		/// APIキーを元にインスタンス生成する
		/// </summary>
		/// <param name="apiKey"></param>
		public YouTubeDataApiGateway(string apiKey) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				ApiKey = apiKey
			});
		}

		/// <summary>
		/// 資格情報を元にインスタンス生成する
		/// </summary>
		/// <param name="credential"></param>
		public YouTubeDataApiGateway(IConfigurableHttpClientInitializer credential) {
			youtubeService = new YouTubeService(new BaseClientService.Initializer() {
				HttpClientInitializer = credential,
				ApplicationName = "LiveTubeReport"
			});
		}
		
		/// <summary>
		/// ライブ情報を取得する
		/// </summary>
		/// <param name="channelID"></param>
		/// <returns></returns>
		public SearchListResponse GetLiveInfoData(string channelID) {
			var request = youtubeService.Search.List("id,snippet");
			request.EventType = SearchResource.ListRequest.EventTypeEnum.Live;
			request.Type = "video";
			request.Fields = "items(id/videoId,snippet(title,description,channelTitle))";
			request.ChannelId = channelID;

			return request.Execute();
		}

		/// <summary>
		/// チャンネル情報を取得する
		/// </summary>
		/// <param name="channelID"></param>
		/// <returns></returns>
		public SearchListResponse GetChannelData(string channelID) {
			//検索条件の設定
			var request = youtubeService.Search.List("snippet");
			request.Type = "channel";
			request.Fields = "items(id/channelId, snippet(title,description,thumbnails/default/url))";
			request.ChannelId = channelID;

			Dictionary<string, object> dic = new Dictionary<string, object>();

			return request.Execute();
		}

		/// <summary>
		/// ユーザの登録チャンネルを取得する
		/// </summary>
		/// <param name="nextPageToken"></param>
		/// <returns></returns>
		public SubscriptionListResponse GetSubscriptions(string nextPageToken) {
			var request = youtubeService.Subscriptions.List("snippet");
			request.Mine = true;
			request.MaxResults = 50;
			request.PageToken = nextPageToken ?? ""; //null合体演算子
			request.Fields = "pageInfo, nextPageToken, items(snippet(title,publishedAt, resourceId/channelId, description, thumbnails/default/url))";

			return request.Execute();
		}
	}
}