using System.Drawing.Drawing2D;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap? img;

        private void Threshold(int threshold, Bitmap? image)
        {
            Bitmap thresholdedBitmap = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color originalColor = image.GetPixel(x, y);
                    int grayValue = (int)(originalColor.R * 0.299 + originalColor.G * 0.587 + originalColor.B * 0.114);
                    Color newColor;
                    if (grayValue < threshold)
                    {
                        newColor = Color.Black;
                    }
                    else
                    {
                        newColor = Color.White;
                    }
                    thresholdedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBoxTreshold.Image = thresholdedBitmap;
        }

        private void GrayScale(Bitmap? image)
        {
            Bitmap grayScaleBitmap = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayScaleBitmap.SetPixel(x, y, newColor);
                }
            }
            pictureBoxGray.Image = grayScaleBitmap;
        }
        private void Negative(Bitmap? image)
        {
            Bitmap negativeBitmap = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int newR = 255 - pixelColor.R;
                    int newG = 255 - pixelColor.G;
                    int newB = 255 - pixelColor.B;

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    negativeBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBoxNegative.Image = negativeBitmap;
        }

        private void FlipImage(Bitmap? image)
        {
            Bitmap flipBitmap = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    flipBitmap.SetPixel(img.Width - 1 - x, y, pixelColor);
                }
            }
            pictureBoxFlip.Image = flipBitmap;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBoxOriginal.Image = img;
            }

        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                int numOfThreads = 4;
                Thread[] threads = new Thread[numOfThreads];

                threads[0] = new Thread(() => Threshold(70, (Bitmap)img.Clone()));
                threads[1] = new Thread(() => Negative((Bitmap)img.Clone()));
                threads[2] = new Thread(() => GrayScale((Bitmap)img.Clone()));
                threads[3] = new Thread(() => FlipImage((Bitmap)img.Clone()));

                foreach (Thread thread in threads) thread.Start();
                foreach (Thread thread in threads) thread.Join();
            }
        }
    }
}
