namespace LiveTubeReport.View {
	partial class PopupForm {
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
			this.components = new System.ComponentModel.Container();
			this.imgChannel = new System.Windows.Forms.PictureBox();
			this.lblChannelName = new System.Windows.Forms.Label();
			this.lblLiveTitle = new System.Windows.Forms.Label();
			this.lblLiveDescription = new System.Windows.Forms.Label();
			this.tpLiveDescription = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imgChannel)).BeginInit();
			this.SuspendLayout();
			// 
			// imgChannel
			// 
			this.imgChannel.Location = new System.Drawing.Point(13, 13);
			this.imgChannel.Name = "imgChannel";
			this.imgChannel.Size = new System.Drawing.Size(60, 60);
			this.imgChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgChannel.TabIndex = 0;
			this.imgChannel.TabStop = false;
			this.imgChannel.Click += new System.EventHandler(this.NotificationForm_Click);
			// 
			// lblChannelName
			// 
			this.lblChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblChannelName.AutoSize = true;
			this.lblChannelName.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblChannelName.Location = new System.Drawing.Point(88, 12);
			this.lblChannelName.Name = "lblChannelName";
			this.lblChannelName.Size = new System.Drawing.Size(62, 12);
			this.lblChannelName.TabIndex = 1;
			this.lblChannelName.Text = "チェンネル名";
			this.lblChannelName.Click += new System.EventHandler(this.NotificationForm_Click);
			// 
			// lblLiveTitle
			// 
			this.lblLiveTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLiveTitle.AutoEllipsis = true;
			this.lblLiveTitle.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblLiveTitle.Location = new System.Drawing.Point(87, 30);
			this.lblLiveTitle.Name = "lblLiveTitle";
			this.lblLiveTitle.Size = new System.Drawing.Size(227, 15);
			this.lblLiveTitle.TabIndex = 2;
			this.lblLiveTitle.Text = "放送タイトル";
			this.lblLiveTitle.Click += new System.EventHandler(this.NotificationForm_Click);
			// 
			// lblLiveDescription
			// 
			this.lblLiveDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLiveDescription.AutoEllipsis = true;
			this.lblLiveDescription.Location = new System.Drawing.Point(88, 51);
			this.lblLiveDescription.Name = "lblLiveDescription";
			this.lblLiveDescription.Size = new System.Drawing.Size(236, 24);
			this.lblLiveDescription.TabIndex = 4;
			this.lblLiveDescription.Text = "放送概要";
			this.lblLiveDescription.Click += new System.EventHandler(this.NotificationForm_Click);
			// 
			// NotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 86);
			this.Controls.Add(this.lblLiveDescription);
			this.Controls.Add(this.lblLiveTitle);
			this.Controls.Add(this.lblChannelName);
			this.Controls.Add(this.imgChannel);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(100, 125);
			this.Name = "NotificationForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "通知画面";
			this.Load += new System.EventHandler(this.NotificationForm_Load);
			this.Click += new System.EventHandler(this.NotificationForm_Click);
			((System.ComponentModel.ISupportInitialize)(this.imgChannel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imgChannel;
		private System.Windows.Forms.Label lblChannelName;
		private System.Windows.Forms.Label lblLiveTitle;
		private System.Windows.Forms.Label lblLiveDescription;
		private System.Windows.Forms.ToolTip tpLiveDescription;
	}
}