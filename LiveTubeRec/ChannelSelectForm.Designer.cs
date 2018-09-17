namespace LiveTubeReport {
	partial class ChannelSelectForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dataSet = new System.Data.DataSet();
			this.dataTable = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.channelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.channelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thumbnailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
			// 
			// dataTable
			// 
			this.dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
			this.dataTable.TableName = "Table";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "ChannelID";
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "ChannelName";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "Description";
			// 
			// dataColumn4
			// 
			this.dataColumn4.ColumnName = "Thumbnails";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.channelIDDataGridViewTextBoxColumn,
            this.channelNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.thumbnailsDataGridViewTextBoxColumn});
			this.dataGridView.DataMember = "Table";
			this.dataGridView.DataSource = this.dataSet;
			this.dataGridView.Location = new System.Drawing.Point(12, 48);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.Size = new System.Drawing.Size(776, 341);
			this.dataGridView.TabIndex = 0;
			// 
			// channelIDDataGridViewTextBoxColumn
			// 
			this.channelIDDataGridViewTextBoxColumn.DataPropertyName = "ChannelID";
			this.channelIDDataGridViewTextBoxColumn.HeaderText = "ChannelID";
			this.channelIDDataGridViewTextBoxColumn.Name = "channelIDDataGridViewTextBoxColumn";
			this.channelIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// channelNameDataGridViewTextBoxColumn
			// 
			this.channelNameDataGridViewTextBoxColumn.DataPropertyName = "ChannelName";
			this.channelNameDataGridViewTextBoxColumn.HeaderText = "ChannelName";
			this.channelNameDataGridViewTextBoxColumn.Name = "channelNameDataGridViewTextBoxColumn";
			this.channelNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// thumbnailsDataGridViewTextBoxColumn
			// 
			this.thumbnailsDataGridViewTextBoxColumn.DataPropertyName = "Thumbnails";
			this.thumbnailsDataGridViewTextBoxColumn.HeaderText = "Thumbnails";
			this.thumbnailsDataGridViewTextBoxColumn.Name = "thumbnailsDataGridViewTextBoxColumn";
			this.thumbnailsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ChannelSelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Name = "ChannelSelectForm";
			this.Text = "CannelSelectForm";
			this.Load += new System.EventHandler(this.ChannelSelectForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Data.DataSet dataSet;
		private System.Data.DataTable dataTable;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn channelIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn channelNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailsDataGridViewTextBoxColumn;
	}
}