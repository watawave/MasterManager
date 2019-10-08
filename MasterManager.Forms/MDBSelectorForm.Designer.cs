using System;

namespace INTEC.Med.MasterManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.uxSelectMDBFolderCommand = new MaterialSkin.Controls.MaterialFlatButton();
            this.uxSelectedMDBFolderPathText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.uxSelectedMDBFolderItemsDataListView = new BrightIdeasSoftware.DataListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSelectedMDBFolderItemsDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 65);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxSelectedMDBFolderItemsDataListView);
            this.splitContainer1.Size = new System.Drawing.Size(552, 731);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 27;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uxSelectMDBFolderCommand);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uxSelectedMDBFolderPathText);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.splitContainer2.Size = new System.Drawing.Size(552, 32);
            this.splitContainer2.SplitterDistance = 87;
            this.splitContainer2.TabIndex = 0;
            // 
            // uxSelectMDBFolderCommand
            // 
            this.uxSelectMDBFolderCommand.AutoSize = true;
            this.uxSelectMDBFolderCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxSelectMDBFolderCommand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxSelectMDBFolderCommand.Depth = 0;
            this.uxSelectMDBFolderCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSelectMDBFolderCommand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uxSelectMDBFolderCommand.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uxSelectMDBFolderCommand.Location = new System.Drawing.Point(0, 0);
            this.uxSelectMDBFolderCommand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uxSelectMDBFolderCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxSelectMDBFolderCommand.Name = "uxSelectMDBFolderCommand";
            this.uxSelectMDBFolderCommand.Primary = false;
            this.uxSelectMDBFolderCommand.Size = new System.Drawing.Size(87, 32);
            this.uxSelectMDBFolderCommand.TabIndex = 25;
            this.uxSelectMDBFolderCommand.Text = "開く";
            this.uxSelectMDBFolderCommand.UseVisualStyleBackColor = false;
            this.uxSelectMDBFolderCommand.Click += new System.EventHandler(this.UxSelectMDBFolderCommand_Click);
            // 
            // uxSelectedMDBFolderPathText
            // 
            this.uxSelectedMDBFolderPathText.AccessibleName = "1234";
            this.uxSelectedMDBFolderPathText.Depth = 0;
            this.uxSelectedMDBFolderPathText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSelectedMDBFolderPathText.Hint = "empty";
            this.uxSelectedMDBFolderPathText.Location = new System.Drawing.Point(0, 5);
            this.uxSelectedMDBFolderPathText.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxSelectedMDBFolderPathText.Name = "uxSelectedMDBFolderPathText";
            this.uxSelectedMDBFolderPathText.PasswordChar = '\0';
            this.uxSelectedMDBFolderPathText.SelectedText = "";
            this.uxSelectedMDBFolderPathText.SelectionLength = 0;
            this.uxSelectedMDBFolderPathText.SelectionStart = 0;
            this.uxSelectedMDBFolderPathText.Size = new System.Drawing.Size(461, 23);
            this.uxSelectedMDBFolderPathText.TabIndex = 26;
            this.uxSelectedMDBFolderPathText.UseSystemPasswordChar = false;
            // 
            // uxSelectedMDBFolderItemsDataListView
            // 
            this.uxSelectedMDBFolderItemsDataListView.CellEditUseWholeCell = false;
            this.uxSelectedMDBFolderItemsDataListView.DataSource = null;
            this.uxSelectedMDBFolderItemsDataListView.Location = new System.Drawing.Point(244, 146);
            this.uxSelectedMDBFolderItemsDataListView.Name = "uxSelectedMDBFolderItemsDataListView";
            this.uxSelectedMDBFolderItemsDataListView.Size = new System.Drawing.Size(121, 97);
            this.uxSelectedMDBFolderItemsDataListView.TabIndex = 0;
            this.uxSelectedMDBFolderItemsDataListView.UseCompatibleStateImageBehavior = false;
            this.uxSelectedMDBFolderItemsDataListView.View = System.Windows.Forms.View.Details;
            // 
            // MDBSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 799);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MDBSelectorForm";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MDBSelectorForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSelectedMDBFolderItemsDataListView)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialFlatButton uxSelectMDBFolderCommand;
        private MaterialSkin.Controls.MaterialSingleLineTextField uxSelectedMDBFolderPathText;
        private BrightIdeasSoftware.DataListView uxSelectedMDBFolderItemsDataListView;
    }
}