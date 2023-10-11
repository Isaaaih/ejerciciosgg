using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosgg.formas
{
    public partial class formachicharronera : Form
    {
        public formachicharronera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (double.TryParse(txtA.Text, out double a) &&
                    double.TryParse(txtB.Text, out double b) &&
                    double.TryParse(txtC.Text, out double c))
                {
                    double discriminante = b * b - 4 * a * c;

                    if (discriminante > 0)
                    {
                        double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                        lblResultado.Text = $"Las raíces son reales y diferentes:\nX1 = {x1}\nX2 = {x2}";
                    }
                    else if (discriminante == 0)
                    {
                        double x = -b / (2 * a);
                        lblResultado.Text = $"La ecuación tiene una raíz real doble:\nX = {x}";
                    }
                    else
                    {
                        double realPart = -b / (2 * a);
                        double imaginaryPart = Math.Sqrt(-discriminante) / (2 * a);
                            lblResultado.Text = $"Las raíces son complejas o imaginarias:\nX1 = {realPart} + {imaginaryPart}i\nX2 = {realPart} - {imaginaryPart}i";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese coeficientes válidos para a, b y c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
