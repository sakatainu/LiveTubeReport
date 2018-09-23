using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace LiveTubeReport {
	/// <summary>
	/// チャンネルの情報を保持するクラス
	/// </summary>
	public class Channel {
		public string Name { get; set; }  //チェンネル名
		public string ID { get; set; }   //チャンネルID
		public string Description { get; set; }
		public Image Thumbnail { get; set; }  //サムネイル
		public string ThumbnailUrl { get; set; }  //サムネイル
		public string ThumbnailPath { get; set; }  //サムネイル
		public DateTime AddDate { get; set; }
		public Live Live { get; set; }

		public Channel() {
			Live = new Live();
		}

		public override String ToString() {
			return Utils.Serialize(this);
		}
	}
}
