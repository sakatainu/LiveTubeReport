using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LiveTubeReport {
	public class Schedule {
		public static List<Dictionary<string, string>> ReadOnUserLocal() {
			return Task.Run(async () => {
				var scheduleUrl = new Uri("https://virtual-youtuber.userlocal.jp/schedules");

				// 指定したサイトのHTMLをストリームで取得する
				var doc = default(IHtmlDocument);
				using (var client = new HttpClient())
				using (var stream = await client.GetStreamAsync(scheduleUrl)) {
					// AngleSharp.Parser.Html.HtmlParserオブジェクトにHTMLをパースさせる
					var parser = new HtmlParser();
					doc = await parser.ParseAsync(stream);
				}

				var list = new List<Dictionary<string, string>>();
				// HTMLからtitleタグの値(サイトのタイトルとして表示される部分)を取得する
				var table = doc.QuerySelectorAll(".table.table-bordered.table-sm > tbody > tr");

				var dateDic = new Dictionary<string, string>();
				foreach (var item in table) {
					if (item.ChildElementCount == 1) {
						var dateText = item.FirstElementChild.TextContent.Trim();

						var monthReg = @"\d{1,2}月";
						var dayReg = @"\d{1,2}日";
						if (Regex.IsMatch(dateText, monthReg + dayReg)) {
							dateDic["date"] = Regex.Match(dateText, monthReg + dayReg).Value;
						}
						else {
							dateDic["date"] = Regex.Match(dateDic["date"], @"\d{1,2}月").Value + dateText;
						}
						continue;
					}

					if (item.ChildElementCount == 2) {
						dateDic["hour"] = item.FirstElementChild.TextContent.Trim();

						foreach (var div in item.LastElementChild.Children) {
							dateDic["minute"] = div.FirstElementChild.TextContent.Trim();

							var date = DateTime.Parse(dateDic["date"] + dateDic["hour"] + dateDic["minute"]);

							Console.WriteLine(date);

							foreach (var user in div.LastElementChild.QuerySelectorAll("div > span")) {
								var liveInfo = user.GetElementsByTagName("a");
								var liveTitleElement = liveInfo.First();
								var userName = liveInfo.Last().TextContent;

								var baseUrl = liveTitleElement.Attributes[2].Value;

								var dic = new Dictionary<string, string> {
									["liveStartTime"] = date.ToString(),
									["liveUrl"] = new Uri(scheduleUrl, baseUrl).ToString(),
									["liveTitle"] = liveTitleElement.TextContent,
									["user"] = userName
								};

								list.Add(dic);
							}
						}
					}

					if (item.ChildElementCount > 2) {
						continue;
					}
				}

				return list;
			}).Result;
		}

		private static Uri ExchangeUrl(Uri url) {
			var webreq = (HttpWebRequest)WebRequest.Create(url);
			using (var webres = (HttpWebResponse)webreq.GetResponse()) {
				return webres.ResponseUri;
			}
		}
	}
}
