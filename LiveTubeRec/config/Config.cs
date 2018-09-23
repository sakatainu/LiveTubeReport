using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTubeReport
{
	public class Config
	{
		public static string ApiKey { get; set; }
		public static string YTDLPath { get; set; }
		public static int ChannelNumMax { get; set; }

		public Config(string iniPath)
		{
			//ファイルを指定して初期化
			IniFile ini = new IniFile(iniPath);

			Config.ApiKey = ini["API", "key"];
			Config.YTDLPath = ini["YouTubeDL", "path"];
			Config.ChannelNumMax = int.Parse( ini["Channel", "max"]);
		}
	}
}
