namespace INTEC.Med.MasterManager.Forms
{
    partial class MDBSelectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.uxSelectFolderCommand = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Location = new System.Drawing.Point(12, 144);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(525, 336);
            this.objectListView1.TabIndex = 26;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(109, 84);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(351, 23);
            this.materialSingleLineTextField1.TabIndex = 25;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // uxSelectFolderCommand
            // 
            this.uxSelectFolderCommand.AutoSize = true;
            this.uxSelectFolderCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxSelectFolderCommand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxSelectFolderCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uxSelectFolderCommand.Depth = 0;
            this.uxSelectFolderCommand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxSelectFolderCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxSelectFolderCommand.Location = new System.Drawing.Point(8, 79);
            this.uxSelectFolderCommand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uxSelectFolderCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxSelectFolderCommand.Name = "uxSelectFolderCommand";
            this.uxSelectFolderCommand.Primary = false;
            this.uxSelectFolderCommand.Size = new System.Drawing.Size(94, 36);
            this.uxSelectFolderCommand.TabIndex = 24;
            this.uxSelectFolderCommand.Text = "フォルダを選ぶ";
            this.uxSelectFolderCommand.UseVisualStyleBackColor = false;
            this.uxSelectFolderCommand.Click += new System.EventHandler(this.uxSelectFolderCommand_Click);
            // 
            // MDBSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 519);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.uxSelectFolderCommand);
            this.Name = "MDBSelectorForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MDBSelectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton uxSelectFolderCommand;
    }
}