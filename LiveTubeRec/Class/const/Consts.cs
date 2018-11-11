namespace LiveTubeReport {
	/// <summary>
	/// 定数関連
	/// </summary>
	public static class Consts {
		/// <summary>
		/// チャンネル定数
		/// </summary>
		public static class Channel {
			/// <summary>
			/// チャンネル：channel
			/// </summary>
			private const string Channel_ = "channel";
			/// <summary>
			/// チャンネルID：channel_id
			/// </summary>
			public const string ID = Channel_ + "_id";
			/// <summary>
			/// チャンネル名：channel_name
			/// </summary>
			public const string Name = Channel_ + "_name";
			/// <summary>
			/// チャンネル概要：channel_description
			/// </summary>
			public const string Description =  Channel_ + "_description";
			/// <summary>
			/// 追加日：channel_add_date
			/// </summary>
			public const string AddDate = Channel_ + "_add_date";
			/// <summary>
			/// 登録日：channel_published_at
			/// </summary>
			public const string PublishedAt = Channel_ + "_published_at";
			/// <summary>
			/// 最終リクエスト時間：channel_last_request_time
			/// </summary>
			public const string LastRequestTime = "_last_request_time";
			/// <summary>
			/// 次回リクエスト時間：channel_next_request_time";
			/// </summary>
			public const string NextRequestTime= "_next_request_time";

			/// <summary>
			/// サムネイル定数
			/// </summary>
			public static class Thumbnail {
				private const string Thumbnail_ = "thumbnail";
				/// <summary>
				/// サムネイル：thumbnail
				/// </summary>
				public const string Image = Thumbnail_;
				/// <summary>
				/// サムネイルURL：thumbnail_url
				/// </summary>
				public const string Url = Thumbnail_ + "_url";
				/// <summary>
				/// サムネイル保存先：thumbnail_path
				/// </summary>
				public const string Path = Thumbnail_ + "_path";
			}
		}
		/// <summary>
		/// ライブ定数
		/// </summary>
		public static class Live {
			private const string Live_ = "live";
			/// <summary>
			/// ライブID：live_id
			/// </summary>
			public const string ID = Live_ + "_id";
			/// <summary>
			/// ライブタイトル：live_title
			/// </summary>
			public const string Title = Live_ + "_title";
			/// <summary>
			/// ライブURL：live_url
			/// </summary>
			public const string Url = Live_ + "_url";
			/// <summary>
			/// ライブ状態：live_status
			/// </summary>
			public const string Status = Live_ + "_status";
			/// <summary>
			/// ライブ概要：live_description
			/// </summary>
			public const string Description = Live_ + "_description";
			/// <summary>
			/// ライブ開始時間：live_start_time
			/// </summary>
			public const string StartTime = Live_ + "_start_time";
			/// <summary>
			/// ライブ終了時間：live_end_time
			/// </summary>
			public const string EndTime = Live_ + "_end_time";
		}
	}
}
