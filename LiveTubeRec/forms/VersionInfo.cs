using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class VersionInfo : Form {

		public VersionInfo() {
			InitializeComponent();

			SetupAppInformarion();
		}

		private void SetupAppInformarion() {
			var assembly = Assembly.GetExecutingAssembly();

			T GetCustomAttribute<T>() where T : Attribute =>
				(T)Attribute.GetCustomAttribute(assembly, typeof(T));

			var t1 = GetCustomAttribute<AssemblyTitleAttribute>().Title;                  // "タイトル"
			var r1 = GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;          // "著作権"
			var ver = assembly.GetName().Version;

			AppName.Text = $"{t1} {ver.Major}.{ver.Minor}.{ver.Build}";
			Copyright.Text = r1;
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start($"mailto:{((LinkLabel)sender).Text}");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start(((LinkLabel)sender).Text);

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("https://twitter.com/Sakata_Inu");
		}
	}
}
