namespace LiveTubeReport.View {
	partial class VersionInfo {
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
			this.AppName = new System.Windows.Forms.Label();
			this.Copyright = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AppName
			// 
			this.AppName.AutoSize = true;
			this.AppName.Location = new System.Drawing.Point(55, 22);
			this.AppName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.AppName.Name = "AppName";
			this.AppName.Size = new System.Drawing.Size(85, 12);
			this.AppName.TabIndex = 0;
			this.AppName.Text = "LiveTubeReport";
			// 
			// Copyright
			// 
			this.Copyright.AutoSize = true;
			this.Copyright.Location = new System.Drawing.Point(55, 44);
			this.Copyright.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.Copyright.Name = "Copyright";
			this.Copyright.Size = new System.Drawing.Size(147, 12);
			this.Copyright.TabIndex = 0;
			this.Copyright.Text = "Copyright (C) 2018 さかた犬.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 88);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "ブログ";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(115, 88);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(128, 12);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://sakatainu.orz.hm/";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 110);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "Twitter";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(115, 110);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(67, 12);
			this.linkLabel2.TabIndex = 2;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "@Sakata_Inu";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 66);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "メール";
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(115, 66);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(106, 12);
			this.linkLabel3.TabIndex = 1;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "skatainu@gmail.com";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(55, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(294, 30);
			this.label6.TabIndex = 4;
			this.label6.Text = "不具合報告や機能要望などは上記のいずれかまで\r\nお問い合わせください。";
			// 
			// VersionInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 171);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Copyright);
			this.Controls.Add(this.AppName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VersionInfo";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "バージョン情報";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AppName;
		private System.Windows.Forms.Label Copyright;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label6;
	}
}