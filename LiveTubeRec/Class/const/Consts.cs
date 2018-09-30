using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTubeReport {
	public static class Consts {
		public static class Channel {
			private const string Channel_ = "Channel";
			public const string ID = Channel_ + "ID";
			public const string Name = Channel_ + "Name";
			public const string Description =  Channel_ + "Description";
			public const string AddDate = Channel_ + "AddDate";
			public const string PublishedAt = Channel_ + "PublishedAt";
			public const string LastRequestTime = "LastRequestTime";
			public const string NextRequestTime= "NextRequestTime";

			public static class Thumbnail {
				private const string Thumbnail_ = "Thumbnail";
				public const string Image = Thumbnail_;
				public const string Url = Thumbnail_ + "Url";
				public const string Path = Thumbnail_ + "Path";
			}
		}
		public static class Live {
			private const string Live_ = "Live";
			public const string ID = Live_ + "ID";
			public const string Title = Live_ + "Title";
			public const string Url = Live_ + "Url";
			public const string Status = Live_ + "Status";
			public const string Description = Live_ + "Description";
			public const string StartTime = Live_ + "StartTime";
			public const string EndTime = Live_ + "EndTime";
		}
	}
}
