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

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                foreach (var fileName in OpenFileDialog.FileNames)
                    lstImages.Items.Add(fileName);
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

            Image prevImage = null;
            var areAllImagesTheSameSize = true;

            foreach (var item in lstImages.Items)
            {
                var image = new Bitmap(Image.FromFile((string)item));
                images.Add(image);

                if (prevImage != null && areAllImagesTheSameSize)
                {
                    if (image.Width != prevImage.Width || image.Height != prevImage.Height)
                    {
                        areAllImagesTheSameSize = false;
                    }
                }

                prevImage = image;
            }

            if (areAllImagesTheSameSize)
            {
                CombineImagesOfSameSize(fileName, images);
            }
            else
            {
                CombineImagesOfDifferentSizes(fileName, images);
            }
        }

        private void CombineImagesOfSameSize(string fileName, List<Bitmap> images)
        {
            var numberOfColumns = ChooseColumnsDialog.ChooseColumnCount(this, images.Count);
            var numberOfRows = images.Count / numberOfColumns;
            if (images.Count % numberOfColumns != 0)
            {
                numberOfRows++;
            }
            var width = images[0].Width * numberOfColumns;
            var height = images[0].Height * numberOfRows;

            var bitmap = new Bitmap(width, height);

            int index = 0;
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    var xOffset = col * images[index].Width;
                    var yOffset = row * images[index].Height;

                    for (int x = 0; x < images[index].Width; x++)
                    {
                        for (int y = 0; y < images[index].Height; y++)
                        {
                            bitmap.SetPixel(x + xOffset, y + yOffset, images[index].GetPixel(x, y));
                        }
                    }

                    index++;
                    if (index >= images.Count)
                    {
                        break;
                    }
                }
            }

            bitmap.Save(fileName);
        }

        private void CombineImagesOfDifferentSizes(string fileName, List<Bitmap> images)
        {
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
            if (lstImages.SelectedItem == null)
            {
                return;
            }

            try
            {
                var fileName = (string)lstImages.SelectedItem;
                var image = Image.FromFile(fileName);
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
    }
}
