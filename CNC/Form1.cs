using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Media.Image;

namespace CNC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public OpenFileDialog openFileDialog1;

        static Image ResizeImage(Image image, int desWidth, int desHeight)
        {
            int x, y, w, h;

            if (image.Height > image.Width)
            {
                w = (image.Width * desHeight) / image.Height;
                h = desHeight;
                x = (desWidth - w) / 2;
                y = 0;
            }
            else
            {
                w = desWidth;
                h = (image.Height * desWidth) / image.Width;
                x = 0;
                y = (desHeight - h) / 2;
            }

            var bmp = new Bitmap(desWidth, desHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, x, y, w, h);
            }

            return bmp;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Users\\Paul\\Desktop\\Mo";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Image img = Image.FromFile(openFileDialog1.FileName);

                        image.Image = ResizeImage(img, image.Size.Width, image.Size.Height);

                        statusBar.Text = openFileDialog1.FileName;
                        convert.Enabled = true;
                        invert.Enabled = true;

                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public static Bitmap ConvertBlackAndWhite(Bitmap Image, Boolean invert)
        {
            ColorMatrix TempMatrix = new ColorMatrix();
            float v = 9;
            float[][] FloatColorMatrixB = {
                new float[] {v, v, v, 0, 0},
                new float[] {v, v, v, 0, 0},
                new float[] {v, v, v, 0, 0},
                new float[] {0, 0, 0, v, 0},
                new float[] {-v, -v, -v, 0, v}
            };

            float[][] FloatColorMatrixI = {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 1, 1}
            };
            if(invert == false)
                TempMatrix.Matrix = FloatColorMatrixB;
            else
                TempMatrix.Matrix = FloatColorMatrixI;

            return TempMatrix.Apply(Image);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(image.Image);
            Image img = ConvertBlackAndWhite(a, false);
            image.Image = img;
        }

        private void invert_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(image.Image);
            Image img = ConvertBlackAndWhite(a, true);
            image.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
