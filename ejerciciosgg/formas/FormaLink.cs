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
    public partial class FormaLink : Form
    {
        public FormaLink()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://learn.microsoft.com/es-es/visualstudio/get-started/csharp/tutorial-windows-forms-math-quiz-create-project-add-controls?view=vs-2022");
        }
    }
}
