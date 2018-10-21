namespace LiveTubeReport.View{
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataSet = new System.Data.DataSet();
			this.dataTable = new System.Data.DataTable();
			this.ChannelIDDataColumn = new System.Data.DataColumn();
			this.ChannelNameDataColumn = new System.Data.DataColumn();
			this.DescriptionDataColumn = new System.Data.DataColumn();
			this.ThumbnailUrlDataColumn = new System.Data.DataColumn();
			this.ThumbnailPathDataColumn = new System.Data.DataColumn();
			this.SelectedDataColumn = new System.Data.DataColumn();
			this.IndexDataColumn = new System.Data.DataColumn();
			this.PublishedAtDataColumn = new System.Data.DataColumn();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.SelectedDGVColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IndexDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelIDDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelNameDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PublishedAtDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.ReacquireButton = new System.Windows.Forms.Button();
			this.CheckBox = new System.Windows.Forms.CheckBox();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SelectCount = new System.Windows.Forms.Label();
			this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
			this.ThumbnailDGVColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.ThumbnailDataColumn = new System.Data.DataColumn();
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
            this.ChannelIDDataColumn,
            this.ChannelNameDataColumn,
            this.DescriptionDataColumn,
            this.ThumbnailUrlDataColumn,
            this.ThumbnailPathDataColumn,
            this.ThumbnailDataColumn,
            this.SelectedDataColumn,
            this.IndexDataColumn,
            this.PublishedAtDataColumn});
			this.dataTable.TableName = "Table";
			// 
			// ChannelIDDataColumn
			// 
			this.ChannelIDDataColumn.AllowDBNull = false;
			this.ChannelIDDataColumn.ColumnName = "ChannelID";
			// 
			// ChannelNameDataColumn
			// 
			this.ChannelNameDataColumn.ColumnName = "ChannelName";
			// 
			// DescriptionDataColumn
			// 
			this.DescriptionDataColumn.ColumnName = "Description";
			// 
			// ThumbnailUrlDataColumn
			// 
			this.ThumbnailUrlDataColumn.ColumnName = "ThumbnailUrl";
			// 
			// ThumbnailPathDataColumn
			// 
			this.ThumbnailPathDataColumn.ColumnName = "ThumbnailPath";
			// 
			// SelectedDataColumn
			// 
			this.SelectedDataColumn.AllowDBNull = false;
			this.SelectedDataColumn.ColumnMapping = System.Data.MappingType.Hidden;
			this.SelectedDataColumn.ColumnName = "Selected";
			this.SelectedDataColumn.DataType = typeof(bool);
			this.SelectedDataColumn.DefaultValue = false;
			// 
			// IndexDataColumn
			// 
			this.IndexDataColumn.AutoIncrement = true;
			this.IndexDataColumn.AutoIncrementSeed = ((long)(1));
			this.IndexDataColumn.ColumnMapping = System.Data.MappingType.Hidden;
			this.IndexDataColumn.ColumnName = "Index";
			this.IndexDataColumn.DataType = typeof(int);
			// 
			// PublishedAtDataColumn
			// 
			this.PublishedAtDataColumn.ColumnName = "PublishedAt";
			this.PublishedAtDataColumn.DataType = typeof(System.DateTime);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedDGVColumn,
            this.IndexDGVColumn,
            this.ChannelIDDGVColumn,
            this.ChannelNameDGVColumn,
            this.DescriptionDGVColumn,
            this.PublishedAtDGVColumn,
            this.ThumbnailDGVColumn});
			this.dataGridView.DataMember = "Table";
			this.dataGridView.DataSource = this.dataSet;
			this.dataGridView.Location = new System.Drawing.Point(12, 41);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(760, 410);
			this.dataGridView.TabIndex = 0;
			// 
			// SelectedDGVColumn
			// 
			this.SelectedDGVColumn.DataPropertyName = "Selected";
			this.SelectedDGVColumn.FalseValue = "False";
			this.SelectedDGVColumn.HeaderText = "追加";
			this.SelectedDGVColumn.MinimumWidth = 40;
			this.SelectedDGVColumn.Name = "SelectedDGVColumn";
			this.SelectedDGVColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.SelectedDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.SelectedDGVColumn.TrueValue = "True";
			this.SelectedDGVColumn.Width = 40;
			// 
			// IndexDGVColumn
			// 
			this.IndexDGVColumn.DataPropertyName = "Index";
			this.IndexDGVColumn.HeaderText = "#";
			this.IndexDGVColumn.MinimumWidth = 25;
			this.IndexDGVColumn.Name = "IndexDGVColumn";
			this.IndexDGVColumn.ReadOnly = true;
			this.IndexDGVColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.IndexDGVColumn.Width = 25;
			// 
			// ChannelIDDGVColumn
			// 
			this.ChannelIDDGVColumn.DataPropertyName = "ChannelID";
			this.ChannelIDDGVColumn.HeaderText = "チャンネルID";
			this.ChannelIDDGVColumn.Name = "ChannelIDDGVColumn";
			this.ChannelIDDGVColumn.ReadOnly = true;
			this.ChannelIDDGVColumn.Width = 150;
			// 
			// ChannelNameDGVColumn
			// 
			this.ChannelNameDGVColumn.DataPropertyName = "ChannelName";
			this.ChannelNameDGVColumn.HeaderText = "チャンネル名";
			this.ChannelNameDGVColumn.Name = "ChannelNameDGVColumn";
			this.ChannelNameDGVColumn.ReadOnly = true;
			this.ChannelNameDGVColumn.Width = 200;
			// 
			// DescriptionDGVColumn
			// 
			this.DescriptionDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DescriptionDGVColumn.DataPropertyName = "Description";
			this.DescriptionDGVColumn.HeaderText = "概要";
			this.DescriptionDGVColumn.Name = "DescriptionDGVColumn";
			this.DescriptionDGVColumn.ReadOnly = true;
			// 
			// PublishedAtDGVColumn
			// 
			this.PublishedAtDGVColumn.DataPropertyName = "PublishedAt";
			this.PublishedAtDGVColumn.HeaderText = "登録日";
			this.PublishedAtDGVColumn.Name = "PublishedAtDGVColumn";
			this.PublishedAtDGVColumn.ReadOnly = true;
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(616, 498);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 2;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(697, 498);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "キャンセル";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.DataPropertyName = "Thumbnail";
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.MinimumWidth = 25;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 25;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.DataPropertyName = "Thumbnail";
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.MinimumWidth = 25;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.ReadOnly = true;
			this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn2.Width = 25;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "すべて選択";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.SelectAll_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(96, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "すべて解除";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.DeSelectAll_Click);
			// 
			// ReacquireButton
			// 
			this.ReacquireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ReacquireButton.Location = new System.Drawing.Point(12, 498);
			this.ReacquireButton.Name = "ReacquireButton";
			this.ReacquireButton.Size = new System.Drawing.Size(75, 23);
			this.ReacquireButton.TabIndex = 5;
			this.ReacquireButton.Text = "再取得";
			this.ReacquireButton.UseVisualStyleBackColor = true;
			this.ReacquireButton.Click += new System.EventHandler(this.ReacquireButton_Click);
			// 
			// CheckBox
			// 
			this.CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CheckBox.AutoSize = true;
			this.CheckBox.Checked = true;
			this.CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox.Location = new System.Drawing.Point(93, 502);
			this.CheckBox.Name = "CheckBox";
			this.CheckBox.Size = new System.Drawing.Size(141, 16);
			this.CheckBox.TabIndex = 1;
			this.CheckBox.Text = "別アカウントから取得する";
			this.CheckBox.UseVisualStyleBackColor = true;
			// 
			// dataGridViewImageColumn3
			// 
			this.dataGridViewImageColumn3.DataPropertyName = "Thumbnail";
			this.dataGridViewImageColumn3.HeaderText = "";
			this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn3.MinimumWidth = 25;
			this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
			this.dataGridViewImageColumn3.ReadOnly = true;
			this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn3.Width = 25;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(12, 464);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(760, 23);
			this.progressBar.TabIndex = 9;
			// 
			// SelectCount
			// 
			this.SelectCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectCount.AutoSize = true;
			this.SelectCount.Enabled = false;
			this.SelectCount.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.SelectCount.Location = new System.Drawing.Point(521, 503);
			this.SelectCount.Name = "SelectCount";
			this.SelectCount.Size = new System.Drawing.Size(69, 12);
			this.SelectCount.TabIndex = 10;
			this.SelectCount.Text = "[ 選択数：0 ]";
			// 
			// dataGridViewImageColumn4
			// 
			this.dataGridViewImageColumn4.DataPropertyName = "Thumbnail";
			this.dataGridViewImageColumn4.HeaderText = "";
			this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn4.MinimumWidth = 25;
			this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
			this.dataGridViewImageColumn4.ReadOnly = true;
			this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn4.Width = 25;
			// 
			// ThumbnailDGVColumn
			// 
			this.ThumbnailDGVColumn.DataPropertyName = "Thumbnail";
			this.ThumbnailDGVColumn.HeaderText = "";
			this.ThumbnailDGVColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.ThumbnailDGVColumn.MinimumWidth = 25;
			this.ThumbnailDGVColumn.Name = "ThumbnailDGVColumn";
			this.ThumbnailDGVColumn.ReadOnly = true;
			this.ThumbnailDGVColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ThumbnailDGVColumn.Width = 25;
			// 
			// ThumbnailDataColumn
			// 
			this.ThumbnailDataColumn.ColumnName = "Thumbnail";
			this.ThumbnailDataColumn.DataType = typeof(object);
			// 
			// ChannelSelectForm
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 539);
			this.Controls.Add(this.SelectCount);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.ReacquireButton);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.CheckBox);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "ChannelSelectForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "記録するチャンネルの選択";
			this.Shown += new System.EventHandler(this.ChannelSelectForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Data.DataColumn ChannelIDDataColumn;
		private System.Data.DataColumn ChannelNameDataColumn;
		private System.Data.DataColumn DescriptionDataColumn;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button OKButton;
		private new System.Windows.Forms.Button CancelButton;
		private System.Data.DataColumn ThumbnailPathDataColumn;
		private System.Data.DataColumn ThumbnailUrlDataColumn;
		private System.Data.DataColumn ThumbnailDataColumn;
		private System.Data.DataColumn SelectedDataColumn;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Data.DataColumn IndexDataColumn;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button ReacquireButton;
		private System.Windows.Forms.CheckBox CheckBox;
		internal System.Data.DataSet dataSet;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		private System.Data.DataColumn PublishedAtDataColumn;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn IndexDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelIDDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelNameDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PublishedAtDGVColumn;
		private System.Windows.Forms.DataGridViewImageColumn ThumbnailDGVColumn;
		private System.Data.DataTable dataTable;
		private System.Windows.Forms.Label SelectCount;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
	}
}