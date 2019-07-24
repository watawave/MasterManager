namespace INTEC.Med.MasterManager.Forms
{
    partial class HospCollectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospCollectionForm));
            this.uxDescriptionNameOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uxMdbNameOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uxOpenFolderCommand = new MaterialSkin.Controls.MaterialFlatButton();
            this.uxContextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.uxFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxDescriptionNameOLVCol
            // 
            this.uxDescriptionNameOLVCol.AspectName = "DescriptionName";
            this.uxDescriptionNameOLVCol.DisplayIndex = 1;
            this.uxDescriptionNameOLVCol.IsTileViewColumn = true;
            this.uxDescriptionNameOLVCol.IsVisible = false;
            this.uxDescriptionNameOLVCol.Text = "DescriptionName";
            // 
            // uxMdbNameOLVCol
            // 
            this.uxMdbNameOLVCol.AspectName = "MdbName";
            this.uxMdbNameOLVCol.DisplayIndex = 2;
            this.uxMdbNameOLVCol.IsVisible = false;
            this.uxMdbNameOLVCol.Text = "MdbName";
            // 
            // uxOpenFolderCommand
            // 
            this.uxOpenFolderCommand.AutoSize = true;
            this.uxOpenFolderCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxOpenFolderCommand.BackColor = System.Drawing.SystemColors.Control;
            this.uxOpenFolderCommand.Depth = 0;
            this.uxOpenFolderCommand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uxOpenFolderCommand.Location = new System.Drawing.Point(3, 6);
            this.uxOpenFolderCommand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uxOpenFolderCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxOpenFolderCommand.Name = "uxOpenFolderCommand";
            this.uxOpenFolderCommand.Primary = false;
            this.uxOpenFolderCommand.Size = new System.Drawing.Size(108, 36);
            this.uxOpenFolderCommand.TabIndex = 0;
            this.uxOpenFolderCommand.Text = "資源を追加する";
            this.uxOpenFolderCommand.UseVisualStyleBackColor = false;
            this.uxOpenFolderCommand.Click += new System.EventHandler(this.uxOpenFolderCommand_Click);
            // 
            // uxContextMenu
            // 
            this.uxContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uxContextMenu.Depth = 0;
            this.uxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileToolStripMenuItem});
            this.uxContextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxContextMenu.Name = "materialContextMenuStrip1";
            this.uxContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.uxContextMenu.Size = new System.Drawing.Size(159, 26);
            // 
            // uxFileToolStripMenuItem
            // 
            this.uxFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem});
            this.uxFileToolStripMenuItem.Name = "uxFileToolStripMenuItem";
            this.uxFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.uxFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.uxFileToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.開くOToolStripMenuItem.Text = "開く(O)";
            // 
            // HospCollectionForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 385);
            this.Controls.Add(this.uxOpenFolderCommand);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospCollectionForm";
            this.TabText = "";
            this.uxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn uxDescriptionNameOLVCol;
        private BrightIdeasSoftware.OLVColumn uxMdbNameOLVCol;
        private MaterialSkin.Controls.MaterialFlatButton uxOpenFolderCommand;
        private MaterialSkin.Controls.MaterialContextMenuStrip uxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
    }
}
