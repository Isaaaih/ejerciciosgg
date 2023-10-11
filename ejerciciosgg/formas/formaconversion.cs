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
    public partial class formaconversion : Form
    {
        public formaconversion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                if (!decimal.TryParse(txtCantidadPesos.Text, out decimal cantidadPesos) || cantidadPesos < 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida en pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (!decimal.TryParse(txtValorDolar.Text, out decimal valorDolar) || valorDolar < 0)
                {
                    MessageBox.Show("Ingrese un valor válido para el dólar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (!decimal.TryParse(txtValorEuro.Text, out decimal valorEuro) || valorEuro < 0)
                {
                    MessageBox.Show("Ingrese un valor válido para el euro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                decimal cantidadDolares = cantidadPesos * (decimal)0.5 / valorDolar;
                decimal cantidadEuros = cantidadPesos * (decimal)0.5 / valorEuro;

               
                MessageBox.Show($"Total en dólares: {cantidadDolares}\nTotal en euros: {cantidadEuros}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formaconversion_Load(object sender, EventArgs e)
        {

        }
    }
}
