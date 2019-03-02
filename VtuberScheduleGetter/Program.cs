using LiveTubeReport;
using System;

namespace VtuberScheduleGetter {
	class Program {
		static void Main (string[] args) {
			var list = Schedule.ReadOnUserLocal();

			foreach (var item in list) {
				Console.WriteLine($"liveStartTime : {item["liveStartTime"]}; liveTitle : {item["liveTitle"]}; user : {item["user"]} ");
			}

			Console.WriteLine("hogehoge");
		}
	}
}
