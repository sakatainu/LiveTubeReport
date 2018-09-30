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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataSet = new System.Data.DataSet();
			this.dataTable = new System.Data.DataTable();
			this.ChannelIDDataColumn = new System.Data.DataColumn();
			this.ChannelNameDataColumn = new System.Data.DataColumn();
			this.DescriptionDataColumn = new System.Data.DataColumn();
			this.ThumbnailUrlDataColumn = new System.Data.DataColumn();
			this.ThumbnailPathDataColumn = new System.Data.DataColumn();
			this.SelectedDataColumn = new System.Data.DataColumn();
			this.IndexDataColumn = new System.Data.DataColumn();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.PublishedAtDataColumn = new System.Data.DataColumn();
			this.SelectedDGVColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IndexDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelIDDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelNameDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PublishedAtDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.ThumbnailDGVColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.ThumbnailDataColumn = new System.Data.DataColumn();
			this.progressBar = new System.Windows.Forms.ProgressBar();
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
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
			this.dataGridView.Location = new System.Drawing.Point(12, 96);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(760, 363);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(598, 512);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(697, 512);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "キャンセル";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(443, 517);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "[ 選択数";
			// 
			// lblCount
			// 
			this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(498, 517);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(19, 12);
			this.lblCount.TabIndex = 3;
			this.lblCount.Text = "0 ]";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 67);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "すべて選択";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(96, 67);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "すべて解除";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(211, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(484, 44);
			this.label3.TabIndex = 7;
			this.label3.Text = "*１ 登録チャンネルを取得する際にブラウザでログイン画面が表示されることがあります。\r\n*２ 登録チャンネルの取得に時間が掛かる場合があります。";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 506);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "再取得";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(96, 510);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(151, 16);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "別のアカウントから取得する";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// PublishedAtDataColumn
			// 
			this.PublishedAtDataColumn.ColumnName = "PublishedAt";
			this.PublishedAtDataColumn.DataType = typeof(System.DateTime);
			// 
			// SelectedDGVColumn
			// 
			this.SelectedDGVColumn.DataPropertyName = "Selected";
			this.SelectedDGVColumn.FalseValue = "False";
			this.SelectedDGVColumn.HeaderText = "選択";
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
			this.ChannelIDDGVColumn.HeaderText = "ID";
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
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 465);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(760, 23);
			this.progressBar.TabIndex = 9;
			// 
			// ChannelSelectForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(784, 547);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView);
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "ChannelSelectForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "記録するチャンネルの選択";
			this.Load += new System.EventHandler(this.ChannelSelectForm_Load);
			this.Shown += new System.EventHandler(this.ChannelSelectForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Data.DataTable dataTable;
		private System.Data.DataColumn ChannelIDDataColumn;
		private System.Data.DataColumn ChannelNameDataColumn;
		private System.Data.DataColumn DescriptionDataColumn;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.DataColumn ThumbnailPathDataColumn;
		private System.Data.DataColumn ThumbnailUrlDataColumn;
		private System.Data.DataColumn ThumbnailDataColumn;
		private System.Data.DataColumn SelectedDataColumn;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Data.DataColumn IndexDataColumn;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.CheckBox checkBox1;
		internal System.Data.DataSet dataSet;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		private System.Data.DataColumn PublishedAtDataColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn IndexDGVColumn;
		private System.Windows.Forms.DataGridViewImageColumn ThumbnailDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelIDDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelNameDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PublishedAtDGVColumn;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}