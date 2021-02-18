
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
            this.lstImages = new System.Windows.Forms.ListBox();
            this.grpImages = new System.Windows.Forms.GroupBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseImages = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCombineImages = new System.Windows.Forms.Button();
            this.grpImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstImages
            // 
            this.lstImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(3, 16);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(770, 300);
            this.lstImages.TabIndex = 0;
            // 
            // grpImages
            // 
            this.grpImages.Controls.Add(this.lstImages);
            this.grpImages.Location = new System.Drawing.Point(12, 12);
            this.grpImages.Name = "grpImages";
            this.grpImages.Size = new System.Drawing.Size(776, 319);
            this.grpImages.TabIndex = 1;
            this.grpImages.TabStop = false;
            this.grpImages.Text = "Images";
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
            this.btnChooseImages.Location = new System.Drawing.Point(15, 337);
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
            this.btnCombineImages.Location = new System.Drawing.Point(111, 337);
            this.btnCombineImages.Name = "btnCombineImages";
            this.btnCombineImages.Size = new System.Drawing.Size(95, 23);
            this.btnCombineImages.TabIndex = 3;
            this.btnCombineImages.Text = "Combine Images";
            this.btnCombineImages.UseVisualStyleBackColor = true;
            this.btnCombineImages.Click += new System.EventHandler(this.btnCombineImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCombineImages);
            this.Controls.Add(this.btnChooseImages);
            this.Controls.Add(this.grpImages);
            this.Name = "MainForm";
            this.Text = "Combine Images";
            this.grpImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.GroupBox grpImages;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnChooseImages;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnCombineImages;
    }
}

