
namespace CombineImages
{
    partial class MainForm
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
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAddImages = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCombineImages = new System.Windows.Forms.Button();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.grpImages = new System.Windows.Forms.GroupBox();
            this.tlpImageList = new System.Windows.Forms.TableLayoutPanel();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.grpSelectedImage = new System.Windows.Forms.GroupBox();
            this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tslblWidth = new System.Windows.Forms.ToolStripLabel();
            this.tslblHeight = new System.Windows.Forms.ToolStripLabel();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearList = new System.Windows.Forms.Button();
            this.tslblFileName = new System.Windows.Forms.ToolStripLabel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.grpImages.SuspendLayout();
            this.tlpImageList.SuspendLayout();
            this.grpSelectedImage.SuspendLayout();
            this.ToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer.ContentPanel.SuspendLayout();
            this.ToolStripContainer.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "All Files|*.*";
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.Title = "Choose Images";
            // 
            // btnAddImages
            // 
            this.btnAddImages.AutoSize = true;
            this.btnAddImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddImages.Location = new System.Drawing.Point(3, 3);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(36, 23);
            this.btnAddImages.TabIndex = 2;
            this.btnAddImages.Text = "Add";
            this.btnAddImages.UseVisualStyleBackColor = true;
            this.btnAddImages.Click += new System.EventHandler(this.btnAddImages_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "bmp";
            this.SaveFileDialog.Filter = "Bitmaps|*.bmp";
            this.SaveFileDialog.Title = "Choose The Target Bitmap File";
            // 
            // btnCombineImages
            // 
            this.btnCombineImages.AutoSize = true;
            this.btnCombineImages.Location = new System.Drawing.Point(352, 424);
            this.btnCombineImages.Name = "btnCombineImages";
            this.btnCombineImages.Size = new System.Drawing.Size(95, 23);
            this.btnCombineImages.TabIndex = 3;
            this.btnCombineImages.Text = "Combine Images";
            this.btnCombineImages.UseVisualStyleBackColor = true;
            this.btnCombineImages.Click += new System.EventHandler(this.btnCombineImages_Click);
            // 
            // spcMain
            // 
            this.tlpMain.SetColumnSpan(this.spcMain, 3);
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(3, 3);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.grpImages);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.grpSelectedImage);
            this.spcMain.Size = new System.Drawing.Size(794, 415);
            this.spcMain.SplitterDistance = 264;
            this.spcMain.TabIndex = 4;
            // 
            // grpImages
            // 
            this.grpImages.Controls.Add(this.tlpImageList);
            this.grpImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImages.Location = new System.Drawing.Point(0, 0);
            this.grpImages.Name = "grpImages";
            this.grpImages.Size = new System.Drawing.Size(264, 415);
            this.grpImages.TabIndex = 2;
            this.grpImages.TabStop = false;
            this.grpImages.Text = "Images";
            // 
            // tlpImageList
            // 
            this.tlpImageList.ColumnCount = 3;
            this.tlpImageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageList.Controls.Add(this.btnRemoveImage, 1, 0);
            this.tlpImageList.Controls.Add(this.btnClearList, 2, 0);
            this.tlpImageList.Controls.Add(this.btnAddImages, 0, 0);
            this.tlpImageList.Controls.Add(this.lstImages, 0, 1);
            this.tlpImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImageList.Location = new System.Drawing.Point(3, 16);
            this.tlpImageList.Name = "tlpImageList";
            this.tlpImageList.RowCount = 2;
            this.tlpImageList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpImageList.Size = new System.Drawing.Size(258, 396);
            this.tlpImageList.TabIndex = 1;
            // 
            // lstImages
            // 
            this.tlpImageList.SetColumnSpan(this.lstImages, 3);
            this.lstImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(3, 32);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(252, 361);
            this.lstImages.TabIndex = 0;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // grpSelectedImage
            // 
            this.grpSelectedImage.Controls.Add(this.ToolStripContainer);
            this.grpSelectedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelectedImage.Location = new System.Drawing.Point(0, 0);
            this.grpSelectedImage.Name = "grpSelectedImage";
            this.grpSelectedImage.Size = new System.Drawing.Size(526, 415);
            this.grpSelectedImage.TabIndex = 0;
            this.grpSelectedImage.TabStop = false;
            // 
            // ToolStripContainer
            // 
            // 
            // ToolStripContainer.BottomToolStripPanel
            // 
            this.ToolStripContainer.BottomToolStripPanel.Controls.Add(this.ToolStrip);
            // 
            // ToolStripContainer.ContentPanel
            // 
            this.ToolStripContainer.ContentPanel.Controls.Add(this.ImagePanel);
            this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(520, 371);
            this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer.LeftToolStripPanelVisible = false;
            this.ToolStripContainer.Location = new System.Drawing.Point(3, 16);
            this.ToolStripContainer.Name = "ToolStripContainer";
            this.ToolStripContainer.RightToolStripPanelVisible = false;
            this.ToolStripContainer.Size = new System.Drawing.Size(520, 396);
            this.ToolStripContainer.TabIndex = 0;
            this.ToolStripContainer.Text = "toolStripContainer1";
            this.ToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblWidth,
            this.tslblHeight,
            this.tslblFileName});
            this.ToolStrip.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(163, 25);
            this.ToolStrip.TabIndex = 0;
            // 
            // tslblWidth
            // 
            this.tslblWidth.Name = "tslblWidth";
            this.tslblWidth.Size = new System.Drawing.Size(42, 22);
            this.tslblWidth.Text = "Width:";
            // 
            // tslblHeight
            // 
            this.tslblHeight.Name = "tslblHeight";
            this.tslblHeight.Size = new System.Drawing.Size(46, 22);
            this.tslblHeight.Text = "Height:";
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.picImage);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(520, 371);
            this.ImagePanel.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(8, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(120, 120);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoScroll = true;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.spcMain, 0, 0);
            this.tlpMain.Controls.Add(this.btnCombineImages, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 5;
            // 
            // btnClearList
            // 
            this.btnClearList.AutoSize = true;
            this.btnClearList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearList.Location = new System.Drawing.Point(108, 3);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(41, 23);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tslblFileName
            // 
            this.tslblFileName.Name = "tslblFileName";
            this.tslblFileName.Size = new System.Drawing.Size(63, 22);
            this.tslblFileName.Text = "File Name:";
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AutoSize = true;
            this.btnRemoveImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveImage.Location = new System.Drawing.Point(45, 3);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(57, 23);
            this.btnRemoveImage.TabIndex = 4;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "Combine Images";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.grpImages.ResumeLayout(false);
            this.tlpImageList.ResumeLayout(false);
            this.tlpImageList.PerformLayout();
            this.grpSelectedImage.ResumeLayout(false);
            this.ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer.ResumeLayout(false);
            this.ToolStripContainer.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnAddImages;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnCombineImages;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.GroupBox grpImages;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.GroupBox grpSelectedImage;
        private System.Windows.Forms.ToolStripContainer ToolStripContainer;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel tslblWidth;
        private System.Windows.Forms.ToolStripLabel tslblHeight;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TableLayoutPanel tlpImageList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.ToolStripLabel tslblFileName;
        private System.Windows.Forms.Button btnRemoveImage;
    }
}

