using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport {
	public partial class ChannelSelectForm : Form {
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();

		public object argument { get; set; }

		public ChannelSelectForm() {
			InitializeComponent();
		}

		private void ChannelSelectForm_Load(object sender, EventArgs e) {
			
			int a = 0;
			foreach(var dic in (List<Dictionary<string, object>>)argument) {
				DataRow row = dataTable.NewRow();
				row["ChannelID"] = dic[Consts.Channel.ID];
				row["ChannelName"] = dic[Consts.Channel.Name];
				row["Description"] = dic[Consts.Channel.Description];
				row["Thumbnails"] = dic[Consts.Channel.Thumbnail];

				dataTable.Rows.Add(row);
				a++;
			}

			logger.Debug("a : " + a);
		}
	}
}
