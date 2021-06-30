using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CombineImages
{
    public partial class CombineImagesProgressDialog : Form
    {
        public static void CombineImages(Form owner, string targetFileName, List<string> sourceFileNames)
        {
            var dialog = new CombineImagesProgressDialog(targetFileName, sourceFileNames);
            dialog.ShowDialog(owner);
        }

        private string TargetFileName { get; }
        private List<string> SourceFileNames { get; }

        private CombineImagesProgressDialog(string targetFileName, List<string> sourceFileNames)
        {
            InitializeComponent();

            TargetFileName = targetFileName;
            SourceFileNames = sourceFileNames;
        }

        private void CombineImagesProgressDialog_Load(object sender, EventArgs e)
        {
            CombineImagesTimer.Start();
        }

        private void CombineImagesTimer_Tick(object sender, EventArgs e)
        {
            CombineImagesTimer.Stop();
            try
            {
                CombineImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to combine the images.{Environment.NewLine}{ex}", "Combine Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void CombineImages()
        {
            var images = new List<Bitmap>();

            Image prevImage = null;
            var areAllImagesTheSameSize = true;

            ProgressBar.Maximum = SourceFileNames.Count * 2;

            foreach (var fileName in SourceFileNames)
            {
                var image = new Bitmap(GetImageFromFile(fileName));
                images.Add(image);

                if (prevImage != null && areAllImagesTheSameSize)
                {
                    if (image.Width != prevImage.Width || image.Height != prevImage.Height)
                    {
                        areAllImagesTheSameSize = false;
                    }
                }

                prevImage = image;

                ProgressBar.Value++;
            }

            if (areAllImagesTheSameSize)
            {
                CombineImagesOfSameSize(images);
            }
            else
            {
                CombineImagesOfDifferentSizes(images);
            }
        }

        private static Image GetImageFromFile(string fileName)
        {
            var stream = new FileStream(fileName, FileMode.Open);
            var image = Image.FromStream(stream);
            stream.Close();
            return image;
        }

        private void CombineImagesOfSameSize(List<Bitmap> images)
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

                    ProgressBar.Value++;

                    index++;
                    if (index >= images.Count)
                    {
                        break;
                    }
                }
            }

            bitmap.Save(TargetFileName);
            Process.Start(TargetFileName);
        }

        private void CombineImagesOfDifferentSizes(List<Bitmap> images)
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

            ProgressBar.Maximum += images.Count;

            foreach (var image in images)
            {
                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < image.Height; y++)
                        bitmap.SetPixel(x + offset, y, image.GetPixel(x, y));

                offset += image.Width;

                ProgressBar.Value++;
            }

            bitmap.Save(TargetFileName);
            Process.Start(TargetFileName);
        }
    }
}
