using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTubeReport
{
	public class Live
	{
		public string ID { get; set; }  //ライブID
		public string Title { get; set; }  //ライブタイトル
		public string URL { get; set; } //ライブURL
		public string Description { get; set; }
		public DateTime StartTime { get; set; } //放送開始時間
		public DateTime EndTime { get; set; } //放送終了時間
	}
}
