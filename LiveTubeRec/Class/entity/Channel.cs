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

namespace LiveTubeReport.Entity {
	/// <summary>
	/// チャンネルの情報を保持するクラス
	/// </summary>
	public class Channel {
		public string Name { get; set; }  //チェンネル名
		private string id;
		public string ID {
			get { return this.id; }
			set {
				this.Thumbnail.Path = @".\data\image\" + value + ".png";
				this.id = value;
			}
		}   //チャンネルID
		public string Description { get; set; }
		public DateTime AddDate { get; set; }
		public DateTime PublishedAt { get; set; }
		public Live Live { get; set; }
		public Thumbnail Thumbnail { get; set; }

		public Channel() {
			Live = new Live();
			Thumbnail = new Thumbnail();
		}

		public override String ToString() {
			return Utils.Serialize(this);
		}
	}

	public class Thumbnail {
		public string Url { get; set; }
		private Image image;
		public Image Image {
			get {
				if (this.image != null) return this.image;
				if (this.Path == null) return null;

				Bitmap bmp = null;
				if (!System.IO.File.Exists(this.Path)) {
					bmp = new Bitmap(Utils.loadImageFromURL(this.Url));
					bmp.Save(this.Path, System.Drawing.Imaging.ImageFormat.Png);
				}
				else {
					bmp = new Bitmap(this.Path);
				}

				return bmp;
			}
			set {
				this.image = value;
			}
		}
		/// <summary>
		/// サムネイルパス　サムネイルパスはチャンネルクラスのIDを設定時に自動的に設定されます。
		/// </summary>
		public string Path { get; set; }
	}
}
