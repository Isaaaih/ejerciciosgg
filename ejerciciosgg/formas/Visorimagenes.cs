using ejerciciosgg.formas;
using System;
using System    .Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Visorimagenes : Form
    {
        public Visorimagenes()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Load(openFileDialog1.FileName);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Invalidate();
            }
        }

        private void btnZoomIn_Click_Click(object sender, EventArgs e)
        {
            // Ajustar el brillo de la imagen en el PictureBox.
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap adjusted = new Bitmap(original.Width, original.Height);

                float brightnessFactor = 1.5f; 

                for (int x = 0; x < original.Width; x++)
                {
                    for (int y = 0; y < original.Height; y++)
                    {
                        Color originalColor = original.GetPixel(x, y);
                        int newRed = (int)(originalColor.R * brightnessFactor);
                        int newGreen = (int)(originalColor.G * brightnessFactor);
                        int newBlue = (int)(originalColor.B * brightnessFactor);

                        newRed = Math.Max(0, Math.Min(255, newRed));     
                        newGreen = Math.Max(0, Math.Min(255, newGreen));
                        newBlue = Math.Max(0, Math.Min(255, newBlue));

                        Color adjustedColor = Color.FromArgb(newRed, newGreen, newBlue);
                        adjusted.SetPixel(x, y, adjustedColor);
                    }
                }

                pictureBox1.Image = adjusted;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap mirrored = new Bitmap(original.Width, original.Height);

                for (int x = 0; x < original.Width; x++)
                {
                    for (int y = 0; y < original.Height; y++)
                    {
                        Color pixelColor = original.GetPixel(original.Width - x - 1, y);
         
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        mirrored.SetPixel(x, y, pixelColor);
                    }
                }

                pictureBox1.Image = mirrored;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Aplicar un efecto de nitidez a la imagen en el PictureBox.
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap sharpened = new Bitmap(original.Width, original.Height);

                int[,] kernel = {
            { -1, -1, -1 },
            { -1,  9, -1 },
            { -1, -1, -1 }
        };

                int kernelSize = 3;
                int kernelOffset = (kernelSize - 1) / 2;

                for (int x = kernelOffset; x < original.Width - kernelOffset; x++)
                {
                    for (int y = kernelOffset; y < original.Height - kernelOffset; y++)
                    {
                        int newR = 0, newG = 0, newB = 0;

                        for (int i = 0; i < kernelSize; i++)
                        {
                            for (int j = 0; j < kernelSize; j++)
                            {
                                Color pixel = original.GetPixel(x + i - kernelOffset, y + j - kernelOffset);
                                newR += pixel.R * kernel[i, j];
                                newG += pixel.G * kernel[i, j];
                                newB += pixel.B * kernel[i, j];
                            }
                        }

                        newR = Math.Max(0, Math.Min(255, newR)); // Asegura que los valores estén en el rango [0, 255].
                        newG = Math.Max(0, Math.Min(255, newG));
                        newB = Math.Max(0, Math.Min(255, newB));

                        Color sharpenedColor = Color.FromArgb(newR, newG, newB);
                        sharpened.SetPixel(x, y, sharpenedColor);
                    }
                }

                pictureBox1.Image = sharpened;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap grayscale = new Bitmap(original.Width, original.Height);

                for (int x = 0; x < original.Width; x++)
                {
                    for (int y = 0; y < original.Height; y++)
                    {
                        Color originalColor = original.GetPixel(x, y);
                        int average = (originalColor.R + originalColor.G + originalColor.B) / 3;
                        Color grayscaleColor = Color.FromArgb(average, average, average);
                        grayscale.SetPixel(x, y, grayscaleColor);
                    }
                }

                pictureBox1.Image = grayscale;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Informacion home = new Informacion();
            home.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
    }
}