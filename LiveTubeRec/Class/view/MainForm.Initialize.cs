using LiveTubeReport.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTubeReport.View {
	partial class MainForm {
		public void Initialize() {
			InitializeComponent();

			// 設定関連の読み込み
			this.Size = Settings.Default.form_size;

			dcChannelID.ColumnName = Consts.Channel.ID;
			dcChannelName.ColumnName = Consts.Channel.Name;
			dcAddDate.ColumnName = Consts.Channel.AddDate;
			dcDescription.ColumnName = Consts.Channel.Description;
			dcThumbnail.ColumnName = Consts.Channel.Thumbnail.Image;
			dcThumbnailUrl.ColumnName = Consts.Channel.Thumbnail.Url;
			dcThumbnailPath.ColumnName = Consts.Channel.Thumbnail.Path;
			dcLastRequestTime.ColumnName = Consts.Channel.LastRequestTime;
			dcNextRequestTime.ColumnName = Consts.Channel.NextRequestTime;

			dcLiveStatus.ColumnName = Consts.Live.Status;
			dcLiveID.ColumnName = Consts.Live.ID;
			dcLiveTitle.ColumnName = Consts.Live.Title;
			dcLiveDescription.ColumnName = Consts.Live.Description;
			dcLiveUrl.ColumnName = Consts.Live.Url;
			dcLiveStartTime.ColumnName = Consts.Live.StartTime;
			dcLiveEndTime.ColumnName = Consts.Live.EndTime;

			dgvChannelID.DataPropertyName = dcChannelID.ColumnName;
			dgvChannelName.DataPropertyName = dcChannelName.ColumnName;
			dgvAddDate.DataPropertyName = dcAddDate.ColumnName;
			dgvDescription.DataPropertyName = dcDescription.ColumnName;
			dgvThumbnail.DataPropertyName = dcThumbnail.ColumnName;
			dgvLastRequestDate.DataPropertyName = dcLastRequestTime.ColumnName;

			dgvStatus.DataPropertyName = dcLiveStatus.ColumnName;
			dgvLiveID.DataPropertyName = dcLiveID.ColumnName;
			dgvLiveTitle.DataPropertyName = dcLiveTitle.ColumnName;
			dgvLiveURL.DataPropertyName = dcLiveUrl.ColumnName;
			dgvLiveDescription.DataPropertyName = dcLiveDescription.ColumnName;
			dgvLiveStartTime.DataPropertyName = dcLiveStartTime.ColumnName;
			dgvLiveEndTime.DataPropertyName = dcLiveEndTime.ColumnName;

			ToolStripProfessionalRenderer renderer = new ToolStripProfessionalRenderer {
				RoundedEdges = false
			};
			toolStrip.Renderer = renderer;
		}
	}
}
