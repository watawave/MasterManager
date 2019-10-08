namespace INTEC.Med.MasterManager {
	partial class TableCollectionForm {
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
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCollectionForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uxTableFilterText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.uxTakenSecondsLabel = new System.Windows.Forms.Label();
            this.uxTableCollection = new BrightIdeasSoftware.ObjectListView();
            this.uxFilterClearCommand = new MaterialSkin.Controls.MaterialFlatButton();
            this.uxTableCollectionOLV = new BrightIdeasSoftware.ObjectListView();
            this.uxTableNameOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uxDescriptionNameOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.uxMdbNameOLVCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTableCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTableCollectionOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxTableFilterText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxTakenSecondsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uxTableCollection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uxFilterClearCommand, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 608);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // uxTableFilterText
            // 
            this.uxTableFilterText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxTableFilterText.Depth = 0;
            this.uxTableFilterText.Hint = "PLEASE INPUT KEYWORDS";
            this.uxTableFilterText.Location = new System.Drawing.Point(53, 8);
            this.uxTableFilterText.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxTableFilterText.Name = "uxTableFilterText";
            this.uxTableFilterText.PasswordChar = '\0';
            this.uxTableFilterText.SelectedText = "";
            this.uxTableFilterText.SelectionLength = 0;
            this.uxTableFilterText.SelectionStart = 0;
            this.uxTableFilterText.Size = new System.Drawing.Size(434, 23);
            this.uxTableFilterText.TabIndex = 1;
            this.uxTableFilterText.UseSystemPasswordChar = false;
            // 
            // uxTakenSecondsLabel
            // 
            this.uxTakenSecondsLabel.AutoSize = true;
            this.uxTakenSecondsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTakenSecondsLabel.Font = new System.Drawing.Font("Meiryo UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uxTakenSecondsLabel.Location = new System.Drawing.Point(3, 588);
            this.uxTakenSecondsLabel.Name = "uxTakenSecondsLabel";
            this.uxTakenSecondsLabel.Size = new System.Drawing.Size(44, 20);
            this.uxTakenSecondsLabel.TabIndex = 18;
            // 
            // uxTableCollection
            // 
            this.uxTableCollection.CellEditUseWholeCell = false;
            this.tableLayoutPanel1.SetColumnSpan(this.uxTableCollection, 3);
            this.uxTableCollection.Cursor = System.Windows.Forms.Cursors.Default;
            this.uxTableCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTableCollection.Location = new System.Drawing.Point(3, 43);
            this.uxTableCollection.Name = "uxTableCollection";
            this.uxTableCollection.Size = new System.Drawing.Size(524, 542);
            this.uxTableCollection.TabIndex = 2;
            this.uxTableCollection.UseCompatibleStateImageBehavior = false;
            this.uxTableCollection.View = System.Windows.Forms.View.Details;
            // 
            // uxFilterClearCommand
            // 
            this.uxFilterClearCommand.AutoSize = true;
            this.uxFilterClearCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxFilterClearCommand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxFilterClearCommand.Depth = 0;
            this.uxFilterClearCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFilterClearCommand.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uxFilterClearCommand.Location = new System.Drawing.Point(494, 6);
            this.uxFilterClearCommand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uxFilterClearCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.uxFilterClearCommand.Name = "uxFilterClearCommand";
            this.uxFilterClearCommand.Primary = false;
            this.uxFilterClearCommand.Size = new System.Drawing.Size(32, 28);
            this.uxFilterClearCommand.TabIndex = 3;
            this.uxFilterClearCommand.Text = "C";
            this.uxFilterClearCommand.UseVisualStyleBackColor = false;
            this.uxFilterClearCommand.Click += new System.EventHandler(this.uxFilterClearCommand_Click);
            // 
            // uxTableCollectionOLV
            // 
            this.uxTableCollectionOLV.AllColumns.Add(this.uxTableNameOLVCol);
            this.uxTableCollectionOLV.AllColumns.Add(this.uxDescriptionNameOLVCol);
            this.uxTableCollectionOLV.AllColumns.Add(this.uxMdbNameOLVCol);
            this.uxTableCollectionOLV.AllowColumnReorder = true;
            this.uxTableCollectionOLV.AllowDrop = true;
            this.uxTableCollectionOLV.CellEditUseWholeCell = false;
            this.uxTableCollectionOLV.CheckBoxes = true;
            this.uxTableCollectionOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxTableNameOLVCol});
            this.uxTableCollectionOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.uxTableCollectionOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTableCollectionOLV.FullRowSelect = true;
            this.uxTableCollectionOLV.HeaderWordWrap = true;
            this.uxTableCollectionOLV.HideSelection = false;
            this.uxTableCollectionOLV.IncludeColumnHeadersInCopy = true;
            this.uxTableCollectionOLV.Location = new System.Drawing.Point(0, 0);
            this.uxTableCollectionOLV.Name = "uxTableCollectionOLV";
            this.uxTableCollectionOLV.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.uxTableCollectionOLV.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uxTableCollectionOLV.OverlayText.BorderWidth = 2F;
            this.uxTableCollectionOLV.OverlayText.Rotation = -20;
            this.uxTableCollectionOLV.OverlayText.Text = "test";
            this.uxTableCollectionOLV.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.uxTableCollectionOLV.ShowCommandMenuOnRightClick = true;
            this.uxTableCollectionOLV.ShowGroups = false;
            this.uxTableCollectionOLV.ShowHeaderInAllViews = false;
            this.uxTableCollectionOLV.ShowItemToolTips = true;
            this.uxTableCollectionOLV.Size = new System.Drawing.Size(530, 608);
            this.uxTableCollectionOLV.SortGroupItemsByPrimaryColumn = false;
            this.uxTableCollectionOLV.TabIndex = 38;
            this.uxTableCollectionOLV.TriStateCheckBoxes = true;
            this.uxTableCollectionOLV.UseAlternatingBackColors = true;
            this.uxTableCollectionOLV.UseCellFormatEvents = true;
            this.uxTableCollectionOLV.UseCompatibleStateImageBehavior = false;
            this.uxTableCollectionOLV.UseFilterIndicator = true;
            this.uxTableCollectionOLV.UseFiltering = true;
            this.uxTableCollectionOLV.UseHotItem = true;
            this.uxTableCollectionOLV.View = System.Windows.Forms.View.Details;
            // 
            // uxTableNameOLVCol
            // 
            this.uxTableNameOLVCol.AspectName = "TableName";
            this.uxTableNameOLVCol.Text = "TableName";
            this.uxTableNameOLVCol.ToolTipText = "";
            this.uxTableNameOLVCol.Width = 600;
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
            // TableCollectionForm
            // 
            this.ClientSize = new System.Drawing.Size(530, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uxTableCollectionOLV);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableCollectionForm";
            this.TabText = "";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTableCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTableCollectionOLV)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public MaterialSkin.Controls.MaterialSingleLineTextField uxTableFilterText;
        private System.Windows.Forms.Label uxTakenSecondsLabel;
        private BrightIdeasSoftware.ObjectListView uxTableCollectionOLV;
        private BrightIdeasSoftware.OLVColumn uxTableNameOLVCol;
        private BrightIdeasSoftware.OLVColumn uxDescriptionNameOLVCol;
        private BrightIdeasSoftware.OLVColumn uxMdbNameOLVCol;
        private BrightIdeasSoftware.ObjectListView uxTableCollection;
        private MaterialSkin.Controls.MaterialFlatButton uxFilterClearCommand;
    }
}
