namespace LiveTubeReport.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvThumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvChannelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLiveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLiveTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLiveURL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dgvLiveDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLiveStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLiveEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.liveTubeDataSet = new System.Data.DataSet();
            this.tbChannel = new System.Data.DataTable();
            this.dcChannelID = new System.Data.DataColumn();
            this.dcChannelName = new System.Data.DataColumn();
            this.dcDescription = new System.Data.DataColumn();
            this.dcAddDate = new System.Data.DataColumn();
            this.dcLiveID = new System.Data.DataColumn();
            this.dcLiveTitle = new System.Data.DataColumn();
            this.dcLiveUrl = new System.Data.DataColumn();
            this.dcLiveStatus = new System.Data.DataColumn();
            this.dcLiveDescription = new System.Data.DataColumn();
            this.dcLiveStartTime = new System.Data.DataColumn();
            this.dcLiveEndTime = new System.Data.DataColumn();
            this.dcThumbnail = new System.Data.DataColumn();
            this.dcThumbnailUrl = new System.Data.DataColumn();
            this.dcThumbnailPath = new System.Data.DataColumn();
            this.dcLastRequestTime = new System.Data.DataColumn();
            this.dcNextRequestTime = new System.Data.DataColumn();
            this.AddChannelTextBox = new System.Windows.Forms.TextBox();
            this.AddChannelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.StartChannelChakkingButton = new System.Windows.Forms.Button();
            this.CheckChannelNowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenCurrentFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableNoticeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.GetSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.youTubeトップページVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeLiveトップページLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ScheduleDGV = new System.Windows.Forms.DataGridView();
            this.ExternalAppsDataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveTubeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChannel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalAppsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(903, 379);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.TextChanged += new System.EventHandler(this.TextBox_Log_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
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
            this.dgvLiveDescription,
            this.dgvLiveStartTime,
            this.dgvLiveEndTime,
            this.dgvLastRequestDate,
            this.dgvAddDate,
            this.dgvDescription});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataMember = "Channel";
            this.dataGridView.DataSource = this.liveTubeDataSet;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(903, 379);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
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
            // dgvLiveDescription
            // 
            this.dgvLiveDescription.DataPropertyName = "LiveDescription";
            this.dgvLiveDescription.HeaderText = "放送概要";
            this.dgvLiveDescription.Name = "dgvLiveDescription";
            this.dgvLiveDescription.ReadOnly = true;
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
            // dgvLiveEndTime
            // 
            this.dgvLiveEndTime.DataPropertyName = "LiveEndTime";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvLiveEndTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLiveEndTime.HeaderText = "放送終了";
            this.dgvLiveEndTime.Name = "dgvLiveEndTime";
            this.dgvLiveEndTime.ReadOnly = true;
            this.dgvLiveEndTime.Width = 110;
            // 
            // dgvLastRequestDate
            // 
            this.dgvLastRequestDate.DataPropertyName = "LastRequestTime";
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
            // dgvDescription
            // 
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "概要";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
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
            this.dcChannelID,
            this.dcChannelName,
            this.dcDescription,
            this.dcAddDate,
            this.dcLiveID,
            this.dcLiveTitle,
            this.dcLiveUrl,
            this.dcLiveStatus,
            this.dcLiveDescription,
            this.dcLiveStartTime,
            this.dcLiveEndTime,
            this.dcThumbnail,
            this.dcThumbnailUrl,
            this.dcThumbnailPath,
            this.dcLastRequestTime,
            this.dcNextRequestTime});
            this.tbChannel.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ChannelID"}, false)});
            this.tbChannel.TableName = "channel";
            // 
            // dcChannelID
            // 
            this.dcChannelID.AllowDBNull = false;
            this.dcChannelID.Caption = "channelID";
            this.dcChannelID.ColumnName = "ChannelID";
            // 
            // dcChannelName
            // 
            this.dcChannelName.ColumnName = "ChannelName";
            // 
            // dcDescription
            // 
            this.dcDescription.ColumnName = "Description";
            // 
            // dcAddDate
            // 
            this.dcAddDate.ColumnName = "AddDate";
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
            // dcLiveStatus
            // 
            this.dcLiveStatus.ColumnMapping = System.Data.MappingType.Hidden;
            this.dcLiveStatus.ColumnName = "LiveStatus";
            this.dcLiveStatus.DataType = typeof(bool);
            this.dcLiveStatus.DefaultValue = false;
            // 
            // dcLiveDescription
            // 
            this.dcLiveDescription.ColumnName = "LiveDescription";
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
            // dcThumbnail
            // 
            this.dcThumbnail.ColumnMapping = System.Data.MappingType.Hidden;
            this.dcThumbnail.ColumnName = "Thumbnail";
            this.dcThumbnail.DataType = typeof(object);
            // 
            // dcThumbnailUrl
            // 
            this.dcThumbnailUrl.ColumnName = "ThumbnailUrl";
            // 
            // dcThumbnailPath
            // 
            this.dcThumbnailPath.Caption = "ThumbnailPath";
            this.dcThumbnailPath.ColumnName = "ThumbnailPath";
            // 
            // dcLastRequestTime
            // 
            this.dcLastRequestTime.ColumnName = "LastRequestTime";
            this.dcLastRequestTime.DataType = typeof(System.DateTime);
            // 
            // dcNextRequestTime
            // 
            this.dcNextRequestTime.ColumnName = "NextRequestTime";
            this.dcNextRequestTime.DataType = typeof(System.DateTime);
            // 
            // AddChannelTextBox
            // 
            this.AddChannelTextBox.AllowDrop = true;
            this.AddChannelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChannelTextBox.Location = new System.Drawing.Point(6, 19);
            this.AddChannelTextBox.Name = "AddChannelTextBox";
            this.AddChannelTextBox.Size = new System.Drawing.Size(637, 19);
            this.AddChannelTextBox.TabIndex = 0;
            this.AddChannelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChannelID_KeyPress);
            // 
            // AddChannelButton
            // 
            this.AddChannelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChannelButton.Location = new System.Drawing.Point(649, 17);
            this.AddChannelButton.Name = "AddChannelButton";
            this.AddChannelButton.Size = new System.Drawing.Size(75, 23);
            this.AddChannelButton.TabIndex = 1;
            this.AddChannelButton.Text = "追加";
            this.AddChannelButton.UseVisualStyleBackColor = true;
            this.AddChannelButton.Click += new System.EventHandler(this.AddChannelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddChannelTextBox);
            this.groupBox2.Controls.Add(this.AddChannelButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "記録するチャンネルを追加";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.StartChannelChakkingButton);
            this.groupBox3.Controls.Add(this.CheckChannelNowButton);
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
            this.button3.Click += new System.EventHandler(this.StopChannelChakkingButton_Click);
            // 
            // StartChannelChakkingButton
            // 
            this.StartChannelChakkingButton.Image = global::LiveTubeReport.Properties.Resources.play;
            this.StartChannelChakkingButton.Location = new System.Drawing.Point(17, 16);
            this.StartChannelChakkingButton.Name = "StartChannelChakkingButton";
            this.StartChannelChakkingButton.Size = new System.Drawing.Size(25, 25);
            this.StartChannelChakkingButton.TabIndex = 0;
            this.StartChannelChakkingButton.UseVisualStyleBackColor = true;
            this.StartChannelChakkingButton.Click += new System.EventHandler(this.StartChannelChakkingButton_Click);
            // 
            // CheckChannelNowButton
            // 
            this.CheckChannelNowButton.Image = global::LiveTubeReport.Properties.Resources.repeat;
            this.CheckChannelNowButton.Location = new System.Drawing.Point(103, 16);
            this.CheckChannelNowButton.Name = "CheckChannelNowButton";
            this.CheckChannelNowButton.Size = new System.Drawing.Size(25, 25);
            this.CheckChannelNowButton.TabIndex = 2;
            this.CheckChannelNowButton.UseVisualStyleBackColor = true;
            this.CheckChannelNowButton.Click += new System.EventHandler(this.CheckChannelNowButton_Click);
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
            this.EnableNoticeToolStripDropDownButton,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton4});
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
            this.OpenCurrentFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton1.Text = "ファイル(&F)";
            // 
            // OpenCurrentFolderToolStripMenuItem
            // 
            this.OpenCurrentFolderToolStripMenuItem.Name = "OpenCurrentFolderToolStripMenuItem";
            this.OpenCurrentFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.OpenCurrentFolderToolStripMenuItem.Text = "フォルダを開く(&F)";
            this.OpenCurrentFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ExitToolStripMenuItem.Text = "終了(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EnableNoticeToolStripDropDownButton
            // 
            this.EnableNoticeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EnableNoticeToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("EnableNoticeToolStripDropDownButton.Image")));
            this.EnableNoticeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnableNoticeToolStripDropDownButton.Name = "EnableNoticeToolStripDropDownButton";
            this.EnableNoticeToolStripDropDownButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EnableNoticeToolStripDropDownButton.ShowDropDownArrow = false;
            this.EnableNoticeToolStripDropDownButton.Size = new System.Drawing.Size(62, 22);
            this.EnableNoticeToolStripDropDownButton.Text = "通知(&N)";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemOption,
            this.GetSubscriptionsToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton2.Text = "ツール(&T)";
            // 
            // toolStripItemOption
            // 
            this.toolStripItemOption.Name = "toolStripItemOption";
            this.toolStripItemOption.Size = new System.Drawing.Size(309, 22);
            this.toolStripItemOption.Text = "LiveTubeReportの設定(&S)...";
            this.toolStripItemOption.Click += new System.EventHandler(this.toolStripItemOption_Click);
            // 
            // GetSubscriptionsToolStripMenuItem
            // 
            this.GetSubscriptionsToolStripMenuItem.Name = "GetSubscriptionsToolStripMenuItem";
            this.GetSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.GetSubscriptionsToolStripMenuItem.Text = "登録チャンネルから記録するチャンネルを取得(&C)...";
            this.GetSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.OpenChannelSelectFormToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeトップページVToolStripMenuItem,
            this.youTubeLiveトップページLToolStripMenuItem,
            this.toolStripSeparator2,
            this.バージョン情報ToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton4.ShowDropDownArrow = false;
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton4.Text = "ヘルプ(H)";
            // 
            // youTubeトップページVToolStripMenuItem
            // 
            this.youTubeトップページVToolStripMenuItem.Name = "youTubeトップページVToolStripMenuItem";
            this.youTubeトップページVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.youTubeトップページVToolStripMenuItem.Text = "YouTubeトップページ(&V)";
            this.youTubeトップページVToolStripMenuItem.Click += new System.EventHandler(this.OpenYoutubeTopToolStripMenuItem_Click);
            // 
            // youTubeLiveトップページLToolStripMenuItem
            // 
            this.youTubeLiveトップページLToolStripMenuItem.Name = "youTubeLiveトップページLToolStripMenuItem";
            this.youTubeLiveトップページLToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.youTubeLiveトップページLToolStripMenuItem.Text = "YouTubeLiveトップページ(&L)";
            this.youTubeLiveトップページLToolStripMenuItem.Click += new System.EventHandler(this.OpenYouTubeLiveTopToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報(&A)...";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.OpenVersionInfoToolStripMenuItem_Click);
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 411);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "チャンネル";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ログ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ScheduleDGV);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(909, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "スケジュール";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ScheduleDGV
            // 
            this.ScheduleDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDGV.Location = new System.Drawing.Point(3, 3);
            this.ScheduleDGV.Name = "ScheduleDGV";
            this.ScheduleDGV.RowTemplate.Height = 21;
            this.ScheduleDGV.Size = new System.Drawing.Size(903, 379);
            this.ScheduleDGV.TabIndex = 0;
            // 
            // ExternalAppsDataSet
            // 
            this.ExternalAppsDataSet.DataSetName = "ExternalApps";
            this.ExternalAppsDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Items";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "app_path";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "arg";
            this.dataColumn2.DefaultValue = "{live_url}";
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataMember = "Items";
            this.bindingSource1.DataSource = this.ExternalAppsDataSet;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 17);
            this.MinimumSize = new System.Drawing.Size(350, 240);
            this.Name = "MainForm";
            this.Text = "LiveTubeReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liveTubeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChannel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalAppsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox AddChannelTextBox;
        private System.Windows.Forms.Button AddChannelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
		private System.Data.DataColumn dcChannelID;
		private System.Data.DataColumn dcChannelName;
		private System.Data.DataColumn dcDescription;
		private System.Data.DataColumn dcAddDate;
		private System.Data.DataColumn dcLiveID;
		private System.Data.DataColumn dcLiveTitle;
		private System.Data.DataColumn dcLiveUrl;
		private System.Data.DataColumn dcLiveDescription;
		private System.Data.DataColumn dcLiveStatus;
		private System.Data.DataColumn dcLiveStartTime;
		private System.Data.DataColumn dcLiveEndTime;
		private System.Data.DataColumn dcThumbnail;
		private System.Data.DataColumn dcThumbnailUrl;
		private System.Data.DataColumn dcThumbnailPath;
		private System.Data.DataColumn dcLastRequestTime;
		private System.Data.DataColumn dcNextRequestTime;
		private System.Windows.Forms.Button StartChannelChakkingButton;
		private System.Windows.Forms.Button CheckChannelNowButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem toolStripItemOption;
		private System.Data.DataSet liveTubeDataSet;
		private System.Data.DataTable tbChannel;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.DataGridViewImageColumn dgvThumbnail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvChannelID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvChannelName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveTitle;
		private System.Windows.Forms.DataGridViewLinkColumn dgvLiveURL;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveStartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLiveEndTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastRequestDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
		private System.Windows.Forms.ToolStripMenuItem OpenCurrentFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton EnableNoticeToolStripDropDownButton;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripMenuItem GetSubscriptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youTubeトップページVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youTubeLiveトップページLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		public System.Data.DataSet ExternalAppsDataSet;
		public System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView ScheduleDGV;
	}
}

