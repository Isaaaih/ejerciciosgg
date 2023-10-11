using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejerciciosgg.formas;
using PictureViewer;

namespace ejerciciosgg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void areaTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formatriangulo home = new formatriangulo();
            home.Show();
            Hide();
        }

        private void conversionDePesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaconversion home = new formaconversion();
            home.Show();
            Hide();
        }

        private void lPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formacorazon home = new formacorazon();
            home.Show();
            Hide();
        }

        private void lPMToolStripMenuItem_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salario home = new salario();
            home.Show();
            Hide();

        }

        private void chicharroneraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formachicharronera home = new formachicharronera();
            home.Show();
            Hide();
        }

        private void pictureViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visorimagenes home = new Visorimagenes();
            home.Show();
            Hide();
        }

        private void ejerciciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
