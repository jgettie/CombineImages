using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CombineImages
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                foreach (var fileName in OpenFileDialog.FileNames)
                    lstImages.Items.Add(fileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstImages.SelectedItem != null)
            {
                var filename = (string)lstImages.SelectedItem;
                Process.Start("mspaint", $"\"{filename}\"");
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (lstImages.SelectedItem != null)
            {
                lstImages.Items.Remove(lstImages.SelectedItem);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lstImages.Items.Clear();
        }

        private void btnCombineImages_Click(object sender, EventArgs e)
        {
            if (lstImages.Items.Count == 0)
            {
                MessageBox.Show(this, "You must add some images first.", "Combine Images");
                return;
            }

            var result = SaveFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var sourceFileNames = new List<string>();
                foreach (string fileName in lstImages.Items)
                {
                    sourceFileNames.Add(fileName);
                }
                CombineImagesProgressDialog.CombineImages(this, SaveFileDialog.FileName, sourceFileNames);
            }
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedItem == null)
            {
                return;
            }

            try
            {
                var fileName = (string)lstImages.SelectedItem;
                var image = GetImageFromFile(fileName);
                picImage.Image = image;
                tslblFileName.Text = fileName;
                tslblFileName.ToolTipText = fileName;
                tslblWidth.Text = $"Width: {image.Width}";
                tslblHeight.Text = $"Height: {image.Height}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Could not open the file.\n{ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Image GetImageFromFile(string fileName)
        {
            var stream = new FileStream(fileName, FileMode.Open);
            var image = Image.FromStream(stream);
            stream.Close();
            return image;
        }
    }
}
