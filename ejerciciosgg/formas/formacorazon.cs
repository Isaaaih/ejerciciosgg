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
    public partial class formacorazon : Form
    {
        public formacorazon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                  if (edad >= 0)
                {
                    int fcm = 220 - edad;
                    lblResultad.Text = $"Su Frecuencia Cardíaca Máxima es: {fcm} LPM (latidos por minuto)";
                }
                else
                {
                    MessageBox.Show("La edad no puede ser un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida como número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }

}
