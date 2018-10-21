using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTubeReport {
	public static class Consts {
		public static class Channel {
			private const string Channel_ = "channel";
			public const string ID = Channel_ + "_id";
			public const string Name = Channel_ + "_name";
			public const string Description =  Channel_ + "_description";
			public const string AddDate = Channel_ + "_add_date";
			public const string PublishedAt = Channel_ + "_published_at";
			public const string LastRequestTime = "_last_request_time";
			public const string NextRequestTime= "_next_request_time";

			public static class Thumbnail {
				private const string Thumbnail_ = "thumbnail";
				public const string Image = Thumbnail_;
				public const string Url = Thumbnail_ + "_url";
				public const string Path = Thumbnail_ + "_path";
			}
		}
		public static class Live {
			private const string Live_ = "live";
			public const string ID = Live_ + "_iD";
			public const string Title = Live_ + "_title";
			public const string Url = Live_ + "_url";
			public const string Status = Live_ + "_status";
			public const string Description = Live_ + "_description";
			public const string StartTime = Live_ + "_start_time";
			public const string EndTime = Live_ + "_end_time";
		}
	}
}
