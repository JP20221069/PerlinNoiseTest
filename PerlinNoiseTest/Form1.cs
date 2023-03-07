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
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_GENERATE_Click(object sender, EventArgs e)
        {
            try
            {
                LB_STATUS.Text = "Please wait, working . . .";
                PICTURE_STATUS.Image = imageList1.Images["PIC_QUESTION.png"];
                width = Convert.ToInt32(FIELD_WIDTH.Text);
                height = Convert.ToInt32(FIELD_HEIGHT.Text);
                bias = (float)Convert.ToDouble(FIELD_BIAS.Value);
                octaves = Convert.ToInt32(FIELD_OCTAVES.Value);
                bmp = new Bitmap(width, height);
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
                string str = "";
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int pixel_bw = (int)(p_output[y * width + x] * 12.0f);
                        Color c = Utillity.colorize(p_output[y * width + x]);
                        bmp.SetPixel(x, y, c);
                    }

                }
                pictureBox1.Image = bmp;
                LB_STATUS.Text = "Done!";
                
                PICTURE_STATUS.Image = imageList1.Images["PIC_OK.png"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PICTURE_STATUS.Image = imageList1.Images["PIC_ERROR.png"];
                LB_STATUS.Text = "Error!";
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FIELD_BIAS.DecimalPlaces = 2;
            PICTURE_STATUS.Image = imageList1.Images["PIC_QUESTION.png"];
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

        private void saveSeedAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string filename = "test" + r.Next(100) + ".png";
            try
            {
                bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("File successfully saved as " + filename + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = saveFileDialog1.FileName;
                    bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("File successfully saved as " + filename + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perlin Noise Bitmap Maker V 1.2. <c> 2023-2033 JP Programi.\nPerlin noise function ported to C# from Javidx9's work in C++.\nThis project is licensed under the GNU GPL v3 License.\nFor any bugs and questions, email 365tito@gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
