namespace INTEC.Med.MasterManager {
    partial class MainMDIForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDIForm));
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle7 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle8 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle9 = new BrightIdeasSoftware.HeaderStateStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.uxMainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle7;
            this.headerFormatStyle1.Normal = headerStateStyle8;
            this.headerFormatStyle1.Pressed = headerStateStyle9;
            // 
            // uxMainDockPanel
            // 
            this.uxMainDockPanel.BackColor = System.Drawing.SystemColors.Control;
            this.uxMainDockPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.uxMainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxMainDockPanel.DockBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxMainDockPanel.DockLeftPortion = 600D;
            this.uxMainDockPanel.DockTopPortion = 200D;
            this.uxMainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.SystemMdi;
            this.uxMainDockPanel.Location = new System.Drawing.Point(2, 64);
            this.uxMainDockPanel.Name = "uxMainDockPanel";
            this.uxMainDockPanel.Size = new System.Drawing.Size(562, 463);
            this.uxMainDockPanel.TabIndex = 19;
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 529);
            this.Controls.Add(this.uxMainDockPanel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMDIForm";
            this.Padding = new System.Windows.Forms.Padding(2, 64, 2, 2);
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMDIForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel uxMainDockPanel;
    }
}

