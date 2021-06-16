
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
            this.btnChooseImages = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCombineImages = new System.Windows.Forms.Button();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.grpImages = new System.Windows.Forms.GroupBox();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.grpSelectedImage = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblWidth = new System.Windows.Forms.ToolStripLabel();
            this.tslblHeight = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.grpImages.SuspendLayout();
            this.grpSelectedImage.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "All Files|*.*";
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.Title = "Choose Images";
            // 
            // btnChooseImages
            // 
            this.btnChooseImages.AutoSize = true;
            this.btnChooseImages.Location = new System.Drawing.Point(304, 424);
            this.btnChooseImages.Name = "btnChooseImages";
            this.btnChooseImages.Size = new System.Drawing.Size(90, 23);
            this.btnChooseImages.TabIndex = 2;
            this.btnChooseImages.Text = "Choose Images";
            this.btnChooseImages.UseVisualStyleBackColor = true;
            this.btnChooseImages.Click += new System.EventHandler(this.btnChooseImages_Click);
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
            this.btnCombineImages.Location = new System.Drawing.Point(400, 424);
            this.btnCombineImages.Name = "btnCombineImages";
            this.btnCombineImages.Size = new System.Drawing.Size(95, 23);
            this.btnCombineImages.TabIndex = 3;
            this.btnCombineImages.Text = "Combine Images";
            this.btnCombineImages.UseVisualStyleBackColor = true;
            this.btnCombineImages.Click += new System.EventHandler(this.btnCombineImages_Click);
            // 
            // spcMain
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.spcMain, 4);
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
            this.grpImages.Controls.Add(this.lstImages);
            this.grpImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImages.Location = new System.Drawing.Point(0, 0);
            this.grpImages.Name = "grpImages";
            this.grpImages.Size = new System.Drawing.Size(264, 415);
            this.grpImages.TabIndex = 2;
            this.grpImages.TabStop = false;
            this.grpImages.Text = "Images";
            // 
            // lstImages
            // 
            this.lstImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(3, 16);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(258, 396);
            this.lstImages.TabIndex = 0;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // grpSelectedImage
            // 
            this.grpSelectedImage.Controls.Add(this.toolStripContainer1);
            this.grpSelectedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelectedImage.Location = new System.Drawing.Point(0, 0);
            this.grpSelectedImage.Name = "grpSelectedImage";
            this.grpSelectedImage.Size = new System.Drawing.Size(526, 415);
            this.grpSelectedImage.TabIndex = 0;
            this.grpSelectedImage.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(520, 371);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(520, 396);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblWidth,
            this.tslblHeight});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnChooseImages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.spcMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCombineImages, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 371);
            this.panel1.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(520, 371);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Combine Images";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.grpImages.ResumeLayout(false);
            this.grpSelectedImage.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnChooseImages;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnCombineImages;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.GroupBox grpImages;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.GroupBox grpSelectedImage;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblWidth;
        private System.Windows.Forms.ToolStripLabel tslblHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImage;
    }
}

