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
    public partial class formatriangulo : Form
    {
        public formatriangulo()
        {
            InitializeComponent();
        }

        private void formatriangulo_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float baseT = float.Parse(textoBase.Text);
            float alturaT = float.Parse(textoAltura.Text);
            MessageBox.Show("El area es:" + baseT * alturaT / 2, "Resultado");
        }

    }
}
