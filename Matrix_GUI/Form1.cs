using Microsoft.VisualBasic.ApplicationServices;
using System.Media;

namespace Matrix_GUI
{
    public partial class Form1 : Form
    {
        private Bitmap? OriginalImg;
        private Bitmap? ThresholdingImg;
        private Bitmap? GrayImg;
        private Bitmap? SepiaImg;
        private Bitmap? NegativeImg;

        private readonly object originalImgLock = new object();
        private readonly object lockInput = new object();
        private readonly object lockOutput = new object();

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "JPG files (.jpg)|*.jpg";
            //openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                OriginalImg = new Bitmap(file);
                pictureBox1.Image = OriginalImg;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (OriginalImg == null)
            {
                MessageBox.Show("No valid image selected!");
            }
            else
            {
                int width = OriginalImg.Width;
                int height = OriginalImg.Height;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                ThresholdingImg = new Bitmap(OriginalImg);
                GrayImg = new Bitmap(OriginalImg);
                SepiaImg = new Bitmap(OriginalImg);
                NegativeImg = new Bitmap(OriginalImg);
                Action grayScaleAction = () => pictureBox2.Image = GrayScale(GrayImg, width, height);
                Action negativeAction = () => pictureBox3.Image = Negative(NegativeImg, width, height);
                Action thresholdAction = () => pictureBox4.Image = Threshold(ThresholdingImg, 100, width, height);
                Action sepiaAction = () => pictureBox5.Image = Sepia(SepiaImg, width, height);

                Parallel.Invoke(grayScaleAction, negativeAction, thresholdAction, sepiaAction);

                if (openFileDialog1.FileName == "C:\\Users\\eryk5\\Documents\\GitHub\\platformy_programistyczne_.Net_Java\\Matrix_GUI\\media\\mike.png")
                {
                    playMike();
                }
            }
        }
        public Bitmap GrayScale(Bitmap input, int width, int height)
        {
            Bitmap GrayImg = new Bitmap(input.Width, input.Height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor;
                    lock (lockInput)
                    {
                        pixelColor = input.GetPixel(x, y);
                    }
                    int grayscale = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color newColor = Color.FromArgb(grayscale, grayscale, grayscale);
                    lock (lockOutput)
                    {
                        GrayImg.SetPixel(x, y, newColor);
                    }
                }
            }

            return GrayImg;
        }

        public Bitmap Negative(Bitmap input, int width, int height)
        {
            Bitmap NegativeImg = new Bitmap(input.Width, input.Height);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = input.GetPixel(x, y);
                    Color newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    NegativeImg.SetPixel(x, y, newColor);
                }
            }

            return NegativeImg;
        }

        public Bitmap Threshold(Bitmap input, int threshold, int width, int height)
        {
            Bitmap ThresholdingImg = new Bitmap(input.Width, input.Height);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = input.GetPixel(x, y);
                    int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color newColor = avg >= threshold ? Color.White : Color.Black;
                    ThresholdingImg.SetPixel(x, y, newColor);
                }
            }

            return ThresholdingImg;
        }

        public Bitmap Sepia(Bitmap input, int width, int height)
        {
            Bitmap SepiaImg = new Bitmap(input.Width, input.Height);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = input.GetPixel(x, y);
                    int sepiaR = (int)(pixelColor.R * 0.393 + pixelColor.G * 0.769 + pixelColor.B * 0.189);
                    int sepiaG = (int)(pixelColor.R * 0.349 + pixelColor.G * 0.686 + pixelColor.B * 0.168);
                    int sepiaB = (int)(pixelColor.R * 0.272 + pixelColor.G * 0.534 + pixelColor.B * 0.131);

                    sepiaR = Math.Min(255, sepiaR);
                    sepiaG = Math.Min(255, sepiaG);
                    sepiaB = Math.Min(255, sepiaB);

                    Color newColor = Color.FromArgb(sepiaR, sepiaG, sepiaB);
                    SepiaImg.SetPixel(x, y, newColor);
                }
            }

            return SepiaImg;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void playMike()
        {
            SoundPlayer mikeSound = new SoundPlayer(@"C:\Users\eryk5\Documents\GitHub\platformy_programistyczne_.Net_Java\Matrix_GUI\media\mike.wav");
            mikeSound.Play();
        }


        // This part of code implements Parallel calculations of single instances of images with many threads.


        //public Bitmap GrayScale(Bitmap input)
        //{
        //    Bitmap GrayImg = new Bitmap(input.Width, input.Height);

        //    int height = input.Height;
        //    int width = input.Width;
        //    object lockInput = new object();
        //    object lockOutput = new object();

        //    Parallel.For(0, height, y =>
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Color originalColor;
        //            lock (lockInput)
        //            {
        //                originalColor = input.GetPixel(x, y);
        //            }

        //            int grayscale = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
        //            Color newColor = Color.FromArgb(grayscale, grayscale, grayscale);

        //            lock (lockOutput)
        //            {
        //                GrayImg.SetPixel(x, y, newColor);
        //            }
        //        } 
        //    });

        //    return GrayImg;
        //}

        //public Bitmap Negative(Bitmap input)
        //{
        //    Bitmap NegativeImg = new Bitmap(input.Width, input.Height);

        //    int height = input.Height;
        //    int width = input.Width;
        //    object lockInput = new object();
        //    object lockOutput = new object();

        //    Parallel.For(0, height, y =>
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Color pixelColor;
        //            lock (lockInput)
        //            {
        //                pixelColor = input.GetPixel(x, y);
        //            }
        //            Color newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
        //            lock (lockOutput)
        //            {
        //                NegativeImg.SetPixel(x, y, newColor);
        //            }

        //        }
        //    });

        //    return NegativeImg;
        //}

        //public Bitmap Threshold(Bitmap input, int threshold)
        //{
        //    Bitmap ThresholdingImg = new Bitmap(input.Width, input.Height);

        //    int height = input.Height;
        //    int width = input.Width;
        //    object lockInput = new object();
        //    object lockOutput = new object();

        //    Parallel.For(0, height, y =>
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Color pixelColor;
        //            lock (lockInput)
        //            {
        //                pixelColor = input.GetPixel(x, y);
        //            }
        //            int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
        //            Color newColor = avg >= threshold ? Color.White : Color.Black;
        //            lock (lockOutput)
        //            {
        //                ThresholdingImg.SetPixel(x, y, newColor);
        //            }
        //        }
        //    });

        //    return ThresholdingImg;
        //}

        //public Bitmap Sepia(Bitmap input)
        //{
        //    Bitmap SepiaImg = new Bitmap(input.Width, input.Height);

        //    int height = input.Height;
        //    int width = input.Width;
        //    object lockInput = new object();
        //    object lockOutput = new object();

        //    Parallel.For(0, height, y =>
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Color pixelColor;
        //            lock (lockInput)
        //            {
        //                pixelColor = input.GetPixel(x, y);
        //            }
        //            int sepiaR = (int)(pixelColor.R * 0.393 + pixelColor.G * 0.769 + pixelColor.B * 0.189);
        //            int sepiaG = (int)(pixelColor.R * 0.349 + pixelColor.G * 0.686 + pixelColor.B * 0.168);
        //            int sepiaB = (int)(pixelColor.R * 0.272 + pixelColor.G * 0.534 + pixelColor.B * 0.131);

        //            sepiaR = Math.Min(255, sepiaR);
        //            sepiaG = Math.Min(255, sepiaG);
        //            sepiaB = Math.Min(255, sepiaB);

        //            Color newColor = Color.FromArgb(sepiaR, sepiaG, sepiaB);
        //            lock (lockOutput)
        //            {
        //                SepiaImg.SetPixel(x, y, newColor);

        //            }
        //        }
        //    });

        //    return SepiaImg;
        //}

    }
}
