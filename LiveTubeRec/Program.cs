using LiveTubeReport.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport {
	static class Program {
		private static System.Threading.Mutex _mutex;

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
			var assembly = Assembly.GetExecutingAssembly();

			T GetCustomAttribute<T>() where T : Attribute =>
				(T)Attribute.GetCustomAttribute(assembly, typeof(T));

			var t1 = GetCustomAttribute<AssemblyTitleAttribute>().Title;                  // "タイトル"

			_mutex = new System.Threading.Mutex(false, t1);
			//ミューテックスの所有権を要求する
			if (_mutex.WaitOne(0, false) == false) {
				//すでに起動していると判断して終了
				MessageBox.Show("多重起動はできません。");
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
