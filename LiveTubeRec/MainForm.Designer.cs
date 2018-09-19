namespace LiveTubeReport
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.textBox_Log = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.liveTubeDataSet = new System.Data.DataSet();
			this.tbChannel = new System.Data.DataTable();
			this.dcChannelName = new System.Data.DataColumn();
			this.dcChannelID = new System.Data.DataColumn();
			this.dcLiveID = new System.Data.DataColumn();
			this.dcLiveTitle = new System.Data.DataColumn();
			this.dcLiveUrl = new System.Data.DataColumn();
			this.dcLiveStartTime = new System.Data.DataColumn();
			this.dcLiveEndTime = new System.Data.DataColumn();
			this.dcLiveStatus = new System.Data.DataColumn();
			this.dcLiveLastRequestTime = new System.Data.DataColumn();
			this.dcThumbnailUrl = new System.Data.DataColumn();
			this.dcLiveNextRequestTime = new System.Data.DataColumn();
			this.dcAddDate = new System.Data.DataColumn();
			this.dcThumbnailPath = new System.Data.DataColumn();
			this.dcAppStatus = new System.Data.DataColumn();
			this.textBoxChannelID = new System.Windows.Forms.TextBox();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripItemOption = new System.Windows.Forms.ToolStripMenuItem();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dcDescription = new System.Data.DataColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dcThumbnail = new System.Data.DataColumn();
			this.dgvThumbnail = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgvChannelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvLiveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvLiveTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvLiveURL = new System.Windows.Forms.DataGridViewLinkColumn();
			this.dgvLiveStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvLiveEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvLastRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thumbnailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.liveTubeDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbChannel)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_Log
			// 
			this.textBox_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Log.BackColor = System.Drawing.SystemColors.Window;
			this.textBox_Log.Location = new System.Drawing.Point(12, 18);
			this.textBox_Log.Multiline = true;
			this.textBox_Log.Name = "textBox_Log";
			this.textBox_Log.ReadOnly = true;
			this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_Log.Size = new System.Drawing.Size(893, 103);
			this.textBox_Log.TabIndex = 0;
			this.textBox_Log.TextChanged += new System.EventHandler(this.textBox_Log_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBox_Log);
			this.groupBox1.Location = new System.Drawing.Point(0, 361);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(917, 133);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ログ";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvThumbnail,
            this.dgvChannelID,
            this.dgvChannelName,
            this.dgvLiveID,
            this.dgvStatus,
            this.dgvLiveTitle,
            this.dgvLiveURL,
            this.dgvLiveStartTime,
            this.dgvLiveEndDate,
            this.dgvLastRequestDate,
            this.dgvAddDate,
            this.thumbnailDataGridViewTextBoxColumn});
			this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.dataGridView.DataMember = "Channel";
			this.dataGridView.DataSource = this.liveTubeDataSet;
			this.dataGridView.Location = new System.Drawing.Point(12, 92);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(893, 263);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(99, 26);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
			// 
			// toolStripMenuItemDelete
			// 
			this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
			this.toolStripMenuItemDelete.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItemDelete.Text = "削除";
			this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
			// 
			// liveTubeDataSet
			// 
			this.liveTubeDataSet.DataSetName = "LiveTubeReportData";
			this.liveTubeDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.tbChannel});
			// 
			// tbChannel
			// 
			this.tbChannel.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcChannelName,
            this.dcChannelID,
            this.dcLiveID,
            this.dcLiveTitle,
            this.dcLiveUrl,
            this.dcLiveStartTime,
            this.dcLiveEndTime,
            this.dcLiveStatus,
            this.dcLiveLastRequestTime,
            this.dcThumbnailUrl,
            this.dcLiveNextRequestTime,
            this.dcAddDate,
            this.dcThumbnailPath,
            this.dcAppStatus,
            this.dcThumbnail,
            this.dcDescription});
			this.tbChannel.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ChannelID"}, false)});
			this.tbChannel.TableName = "Channel";
			// 
			// dcChannelName
			// 
			this.dcChannelName.ColumnName = "ChannelName";
			// 
			// dcChannelID
			// 
			this.dcChannelID.AllowDBNull = false;
			this.dcChannelID.Caption = "channelID";
			this.dcChannelID.ColumnName = "ChannelID";
			// 
			// dcLiveID
			// 
			this.dcLiveID.ColumnName = "LiveID";
			// 
			// dcLiveTitle
			// 
			this.dcLiveTitle.ColumnName = "LiveTitle";
			// 
			// dcLiveUrl
			// 
			this.dcLiveUrl.ColumnName = "LiveUrl";
			// 
			// dcLiveStartTime
			// 
			this.dcLiveStartTime.ColumnName = "LiveStartTime";
			this.dcLiveStartTime.DataType = typeof(System.DateTime);
			// 
			// dcLiveEndTime
			// 
			this.dcLiveEndTime.ColumnName = "LiveEndTime";
			this.dcLiveEndTime.DataType = typeof(System.DateTime);
			// 
			// dcLiveStatus
			// 
			this.dcLiveStatus.ColumnMapping = System.Data.MappingType.Hidden;
			this.dcLiveStatus.ColumnName = "LiveStatus";
			this.dcLiveStatus.DataType = typeof(bool);
			this.dcLiveStatus.DefaultValue = false;
			// 
			// dcLiveLastRequestTime
			// 
			this.dcLiveLastRequestTime.ColumnName = "LiveLastRequestTime";
			this.dcLiveLastRequestTime.DataType = typeof(System.DateTime);
			// 
			// dcThumbnailUrl
			// 
			this.dcThumbnailUrl.ColumnName = "ThumbnailUrl";
			// 
			// dcLiveNextRequestTime
			// 
			this.dcLiveNextRequestTime.ColumnName = "LiveNextRequestTime";
			this.dcLiveNextRequestTime.DataType = typeof(System.DateTime);
			// 
			// dcAddDate
			// 
			this.dcAddDate.ColumnName = "AddDate";
			// 
			// dcThumbnailPath
			// 
			this.dcThumbnailPath.Caption = "ThumbnailPath";
			this.dcThumbnailPath.ColumnName = "ThumbnailPath";
			// 
			// dcAppStatus
			// 
			this.dcAppStatus.ColumnMapping = System.Data.MappingType.Hidden;
			this.dcAppStatus.ColumnName = "AppStatus";
			this.dcAppStatus.DataType = typeof(bool);
			this.dcAppStatus.DefaultValue = false;
			// 
			// textBoxChannelID
			// 
			this.textBoxChannelID.AllowDrop = true;
			this.textBoxChannelID.Location = new System.Drawing.Point(6, 19);
			this.textBoxChannelID.Name = "textBoxChannelID";
			this.textBoxChannelID.Size = new System.Drawing.Size(637, 19);
			this.textBoxChannelID.TabIndex = 0;
			this.textBoxChannelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChannelID_KeyPress);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(649, 17);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(75, 23);
			this.buttonInsert.TabIndex = 1;
			this.buttonInsert.Text = "追加";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxChannelID);
			this.groupBox2.Controls.Add(this.buttonInsert);
			this.groupBox2.Location = new System.Drawing.Point(12, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(742, 48);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "記録するチャンネルを追加";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Location = new System.Drawing.Point(760, 32);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(145, 48);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "チャンネルチェック";
			// 
			// button3
			// 
			this.button3.Image = global::LiveTubeReport.Properties.Resources.stop;
			this.button3.Location = new System.Drawing.Point(60, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(25, 25);
			this.button3.TabIndex = 1;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Image = global::LiveTubeReport.Properties.Resources.play;
			this.button1.Location = new System.Drawing.Point(17, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Image = global::LiveTubeReport.Properties.Resources.repeat;
			this.button2.Location = new System.Drawing.Point(103, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(25, 25);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(811, 500);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "[ 状態：";
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.SystemColors.Window;
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
			this.toolStrip.Size = new System.Drawing.Size(917, 25);
			this.toolStrip.TabIndex = 5;
			this.toolStrip.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripDropDownButton1.ShowDropDownArrow = false;
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
			this.toolStripDropDownButton1.Text = "ファイル";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemOption});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripDropDownButton2.ShowDropDownArrow = false;
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(48, 22);
			this.toolStripDropDownButton2.Text = "ツール";
			// 
			// toolStripItemOption
			// 
			this.toolStripItemOption.Name = "toolStripItemOption";
			this.toolStripItemOption.Size = new System.Drawing.Size(118, 22);
			this.toolStripItemOption.Text = "オプション";
			this.toolStripItemOption.Click += new System.EventHandler(this.toolStripItemOption_Click);
			// 
			// 終了ToolStripMenuItem
			// 
			this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
			this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.終了ToolStripMenuItem.Text = "終了";
			// 
			// dcDescription
			// 
			this.dcDescription.ColumnName = "Description";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.DataPropertyName = "Thumbnail";
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn1.Width = 25;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Thumbnail";
			this.dataGridViewTextBoxColumn1.HeaderText = "Thumbnail";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dcThumbnail
			// 
			this.dcThumbnail.ColumnMapping = System.Data.MappingType.Hidden;
			this.dcThumbnail.ColumnName = "Thumbnail";
			this.dcThumbnail.DataType = typeof(object);
			// 
			// dgvThumbnail
			// 
			this.dgvThumbnail.DataPropertyName = "Thumbnail";
			this.dgvThumbnail.HeaderText = "";
			this.dgvThumbnail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dgvThumbnail.Name = "dgvThumbnail";
			this.dgvThumbnail.ReadOnly = true;
			this.dgvThumbnail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvThumbnail.Width = 25;
			// 
			// dgvChannelID
			// 
			this.dgvChannelID.DataPropertyName = "ChannelID";
			this.dgvChannelID.HeaderText = "チャンネルID";
			this.dgvChannelID.Name = "dgvChannelID";
			this.dgvChannelID.ReadOnly = true;
			// 
			// dgvChannelName
			// 
			this.dgvChannelName.DataPropertyName = "ChannelName";
			this.dgvChannelName.HeaderText = "チャンネル名";
			this.dgvChannelName.Name = "dgvChannelName";
			this.dgvChannelName.ReadOnly = true;
			this.dgvChannelName.Width = 150;
			// 
			// dgvLiveID
			// 
			this.dgvLiveID.DataPropertyName = "LiveID";
			this.dgvLiveID.HeaderText = "ライブID";
			this.dgvLiveID.Name = "dgvLiveID";
			this.dgvLiveID.ReadOnly = true;
			// 
			// dgvStatus
			// 
			this.dgvStatus.DataPropertyName = "LiveStatus";
			dataGridViewCellStyle2.NullValue = null;
			this.dgvStatus.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStatus.HeaderText = "状況";
			this.dgvStatus.Name = "dgvStatus";
			this.dgvStatus.ReadOnly = true;
			this.dgvStatus.Width = 60;
			// 
			// dgvLiveTitle
			// 
			this.dgvLiveTitle.DataPropertyName = "LiveTitle";
			this.dgvLiveTitle.HeaderText = "番組名";
			this.dgvLiveTitle.Name = "dgvLiveTitle";
			this.dgvLiveTitle.ReadOnly = true;
			this.dgvLiveTitle.Width = 200;
			// 
			// dgvLiveURL
			// 
			this.dgvLiveURL.DataPropertyName = "LiveUrl";
			this.dgvLiveURL.HeaderText = "配信URL";
			this.dgvLiveURL.MinimumWidth = 100;
			this.dgvLiveURL.Name = "dgvLiveURL";
			this.dgvLiveURL.ReadOnly = true;
			this.dgvLiveURL.Width = 250;
			// 
			// dgvLiveStartTime
			// 
			this.dgvLiveStartTime.DataPropertyName = "LiveStartTime";
			dataGridViewCellStyle3.Format = "G";
			dataGridViewCellStyle3.NullValue = null;
			this.dgvLiveStartTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvLiveStartTime.HeaderText = "放送開始";
			this.dgvLiveStartTime.Name = "dgvLiveStartTime";
			this.dgvLiveStartTime.ReadOnly = true;
			this.dgvLiveStartTime.Width = 110;
			// 
			// dgvLiveEndDate
			// 
			this.dgvLiveEndDate.DataPropertyName = "LiveEndTime";
			dataGridViewCellStyle4.Format = "G";
			dataGridViewCellStyle4.NullValue = null;
			this.dgvLiveEndDate.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvLiveEndDate.HeaderText = "放送終了";
			this.dgvLiveEndDate.Name = "dgvLiveEndDate";
			this.dgvLiveEndDate.ReadOnly = true;
			this.dgvLiveEndDate.Width = 110;
			// 
			// dgvLastRequestDate
			// 
			this.dgvLastRequestDate.DataPropertyName = "LiveLastRequestTime";
			dataGridViewCellStyle5.Format = "G";
			dataGridViewCellStyle5.NullValue = null;
			this.dgvLastRequestDate.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvLastRequestDate.HeaderText = "最終リクエスト";
			this.dgvLastRequestDate.Name = "dgvLastRequestDate";
			this.dgvLastRequestDate.ReadOnly = true;
			this.dgvLastRequestDate.Width = 110;
			// 
			// dgvAddDate
			// 
			this.dgvAddDate.DataPropertyName = "AddDate";
			dataGridViewCellStyle6.Format = "G";
			this.dgvAddDate.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvAddDate.HeaderText = "追加日";
			this.dgvAddDate.Name = "dgvAddDate";
			this.dgvAddDate.ReadOnly = true;
			this.dgvAddDate.Width = 110;
			// 
			// thumbnailDataGridViewTextBoxColumn
			// 
			this.thumbnailDataGridViewTextBoxColumn.DataPropertyName = "Thumbnail";
			this.thumbnailDataGridViewTextBoxColumn.HeaderText = "概要";
			this.thumbnailDataGridViewTextBoxColumn.Name = "thumbnailDataGridViewTextBoxColumn";
			this.thumbnailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(917, 518);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView);
			this.Name = "MainForm";
			this.Text = "LiveTubeReport";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.liveTubeDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbChannel)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxChannelID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
		private System.Data.DataColumn dcChannelName;
		private System.Data.DataColumn dcChannelID;
		private System.Data.DataColumn dcLiveID;
		private System.Data.DataColumn dcLiveTitle;
		private System.Data.DataColumn dcLiveUrl;
		private System.Data.DataColumn dcLiveStartTime;
		private System.Data.DataColumn dcLiveEndTime;
		private System.Data.DataColumn dcLiveStatus;
		private System.Data.DataColumn dcLiveLastRequestTime;
		private System.Data.DataColumn dcThumbnailUrl;
		private System.Data.DataColumn dcLiveNextRequestTime;
		private System.Data.DataColumn dcAddDate;
		private System.Data.DataColumn dcThumbnailPath;
		private System.Data.DataColumn dcAppStatus;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem toolStripItemOption;
		private System.Data.DataColumn dcThumbnail;
		private System.Data.DataSet liveTubeDataSet;
		private System.Data.DataTable tbChannel;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
		private System.Data.DataColumn dcDescription;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dgvThumbnail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvChannelID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvChannelName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveTitle;
		private System.Windows.Forms.DataGridViewLinkColumn dgvLiveURL;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveStartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastRequestDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailDataGridViewTextBoxColumn;
	}
}

