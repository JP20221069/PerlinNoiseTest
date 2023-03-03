using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerlinNoiseTest
{
    public partial class Form1 : Form
    {
        bool setseed = false;
        int width;
        int height;
        int octaves;
        float bias;
        float[] p_test;
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_GENERATE_Click(object sender, EventArgs e)
        {
             width = Convert.ToInt32(FIELD_WIDTH.Text);
             height = Convert.ToInt32(FIELD_HEIGHT.Text);
             bias = (float)Convert.ToDouble(FIELD_BIAS.Value);
             octaves = Convert.ToInt32(FIELD_OCTAVES.Value);
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.FillRectangle(sb, 0, 0, width, height);
            if (!setseed)
            {
                p_test = new float[width * height];
                Random r = new Random();
                for (int i = 0; i < width * height; i++)
                {

                    p_test[i] = (float)r.NextDouble();

                }
                setseed = true;
            }
            float[] p_output;
            p_output = Perlin.noise2D(width, height, p_test, octaves, bias);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    /*int pixel_bw = (int)(p_output[y * width + x] * 12.0f);
                    int alpha = 255;
                    Color fg_col = Color.Green;
                    Color bg_col = Color.Green;
                    switch (pixel_bw)
                    {
                        case 0: bg_col = Color.Black; fg_col = Color.Black; alpha=(int)Pixel.SOLID; break;

                        case 1: bg_col = Color.Black; fg_col = Color.DarkGray; alpha = (int)Pixel.QUARTER; break;
                        case 2: bg_col = Color.Black; fg_col = Color.DarkGray; alpha = (int)Pixel.HALF; break;
                        case 3: bg_col = Color.Black; fg_col = Color.DarkGray; alpha = (int)Pixel.THREE_QUARTERS; break;
                        case 4: bg_col = Color.Black; fg_col = Color.DarkGray; alpha = (int)Pixel.SOLID ; break;

                        case 5: bg_col = Color.DarkGray; fg_col = Color.Gray; alpha = (int)Pixel.QUARTER; break;
                        case 6: bg_col = Color.DarkGray; fg_col = Color.Gray; alpha = (int)Pixel.HALF; break;
                        case 7: bg_col = Color.DarkGray; fg_col = Color.Gray; alpha = (int)Pixel.THREE_QUARTERS; break;
                        case 8: bg_col = Color.DarkGray; fg_col = Color.Gray; alpha = (int)Pixel.SOLID; break;

                        case 9: bg_col = Color.Gray; fg_col = Color.White; alpha = (int)Pixel.QUARTER; break;
                        case 10: bg_col = Color.Gray; fg_col = Color.White; alpha = (int)Pixel.HALF; break;
                        case 11: bg_col = Color.Gray; fg_col = Color.White; alpha = (int)Pixel.THREE_QUARTERS; break;
                        case 12: bg_col = Color.Gray; fg_col = Color.White; alpha = (int)Pixel.SOLID; break;
                    }
                    bg_col = Color.FromArgb(alpha, bg_col.R, bg_col.G, bg_col.B);
                    fg_col = Color.FromArgb(alpha, fg_col.R, fg_col.G, fg_col.B);
                    Color c = Utillity.BlendPixel(fg_col,bg_col);*/
                    Color c = Utillity.colorize(p_output[y*width+x]);
                    bmp.SetPixel(x, y, c);
                }
            }
            //string filename = "test" + r.Next(100) + ".png";
            //bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FIELD_BIAS.DecimalPlaces = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_test = new float[width * height];
            Random r = new Random();
            for (int i = 0; i < width * height; i++)
            {

                p_test[i] = (float)r.NextDouble();

            }
            setseed = true;
        }
    }
}
