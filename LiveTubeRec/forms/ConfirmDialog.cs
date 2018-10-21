using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	public partial class ConfirmDialog : Form {
		public ConfirmDialog() {
			InitializeComponent();

			//描画先とするImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g = Graphics.FromImage(canvas);
			g.DrawIcon(SystemIcons.Question, 240, 0);
			g.Dispose();

			pictureBox1.Image = canvas;
		}

		private void button1_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}

		private void button2_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}
	}
}
