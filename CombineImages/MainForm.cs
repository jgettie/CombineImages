using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CombineImages
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChooseImages_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                lstImages.Items.Clear();
                foreach (var fileName in OpenFileDialog.FileNames)
                    lstImages.Items.Add(fileName);
            }
        }

        private void btnCombineImages_Click(object sender, EventArgs e)
        {
            if (lstImages.Items.Count == 0)
            {
                MessageBox.Show(this, "You must choose some images first.", "Combine Images");
                return;
            }

            var result = SaveFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    CombineImages(SaveFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, $"Failed to combine the images.{Environment.NewLine}{Environment.NewLine}{ex}", "Combine Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CombineImages(string fileName)
        {
            var images = new List<Bitmap>();

            foreach (var item in lstImages.Items)
            {
                images.Add(new Bitmap(Image.FromFile((string)item)));
            }

            int width = 0;
            int height = 0;

            foreach (var image in images)
            {
                width += image.Width;
                if (image.Height > height)
                    height = image.Height;
            }

            var bitmap = new Bitmap(width, height);

            int offset = 0;

            foreach (var image in images)
            {
                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < image.Height; y++)
                        bitmap.SetPixel(x + offset, y, image.GetPixel(x, y));

                offset += image.Width;
            }

            bitmap.Save(fileName);
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileName = (string)lstImages.SelectedItem;
            grpSelectedImage.Text = fileName;
            var image = Image.FromFile(fileName);
            tslblWidth.Text = $"Width: {image.Width}";
            tslblHeight.Text = $"Height: {image.Height}";
            picImage.Image = image;
        }
    }
}
