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
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataColumn7 = new System.Data.DataColumn();
			this.dataColumn8 = new System.Data.DataColumn();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
			this.ChannelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
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
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
			this.dataTable.TableName = "Table";
			// 
			// dataColumn1
			// 
			this.dataColumn1.AllowDBNull = false;
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
			this.dataColumn4.ColumnName = "ThumbnailUrl";
			// 
			// dataColumn5
			// 
			this.dataColumn5.ColumnName = "ThumbnailPath";
			// 
			// dataColumn6
			// 
			this.dataColumn6.ColumnName = "Thumbnail";
			this.dataColumn6.DataType = typeof(object);
			// 
			// dataColumn7
			// 
			this.dataColumn7.AllowDBNull = false;
			this.dataColumn7.ColumnMapping = System.Data.MappingType.Hidden;
			this.dataColumn7.ColumnName = "Selected";
			this.dataColumn7.DataType = typeof(bool);
			this.dataColumn7.DefaultValue = false;
			// 
			// dataColumn8
			// 
			this.dataColumn8.ColumnMapping = System.Data.MappingType.Hidden;
			this.dataColumn8.ColumnName = "Index";
			this.dataColumn8.DataType = typeof(int);
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
            this.Selected,
            this.Index,
            this.Thumbnail,
            this.ChannelID,
            this.ChannelName,
            this.Description});
			this.dataGridView.DataMember = "Table";
			this.dataGridView.DataSource = this.dataSet;
			this.dataGridView.Location = new System.Drawing.Point(12, 56);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(776, 341);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
			// 
			// Selected
			// 
			this.Selected.DataPropertyName = "Selected";
			this.Selected.FalseValue = "False";
			this.Selected.HeaderText = "選択";
			this.Selected.MinimumWidth = 40;
			this.Selected.Name = "Selected";
			this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Selected.TrueValue = "True";
			this.Selected.Width = 40;
			// 
			// Index
			// 
			this.Index.DataPropertyName = "Index";
			this.Index.HeaderText = "#";
			this.Index.MinimumWidth = 25;
			this.Index.Name = "Index";
			this.Index.ReadOnly = true;
			this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Index.Width = 25;
			// 
			// Thumbnail
			// 
			this.Thumbnail.DataPropertyName = "Thumbnail";
			this.Thumbnail.HeaderText = "";
			this.Thumbnail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Thumbnail.MinimumWidth = 25;
			this.Thumbnail.Name = "Thumbnail";
			this.Thumbnail.ReadOnly = true;
			this.Thumbnail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Thumbnail.Width = 25;
			// 
			// ChannelID
			// 
			this.ChannelID.DataPropertyName = "ChannelID";
			this.ChannelID.HeaderText = "ID";
			this.ChannelID.Name = "ChannelID";
			this.ChannelID.ReadOnly = true;
			this.ChannelID.Width = 150;
			// 
			// ChannelName
			// 
			this.ChannelName.DataPropertyName = "ChannelName";
			this.ChannelName.HeaderText = "チャンネル名";
			this.ChannelName.Name = "ChannelName";
			this.ChannelName.ReadOnly = true;
			this.ChannelName.Width = 200;
			// 
			// Description
			// 
			this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "概要";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(614, 415);
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
			this.button2.Location = new System.Drawing.Point(713, 415);
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
			this.label1.Location = new System.Drawing.Point(459, 420);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "[ 選択数";
			// 
			// lblCount
			// 
			this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(514, 420);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(19, 12);
			this.lblCount.TabIndex = 3;
			this.lblCount.Text = "0 ]";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "すべて選択";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(103, 27);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "すべて解除";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ChannelSelectForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
			this.Text = "監視チャンネルの選択";
			this.Shown += new System.EventHandler(this.ChannelSelectForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Data.DataSet dataSet;
		private System.Data.DataTable dataTable;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Data.DataColumn dataColumn8;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
		private System.Windows.Forms.DataGridViewTextBoxColumn Index;
		private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
	}
}