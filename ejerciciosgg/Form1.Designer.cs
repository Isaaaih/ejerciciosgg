
namespace ejerciciosgg
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionDePesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chicharroneraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem,
            this.ejerciciosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaTrianguloToolStripMenuItem,
            this.conversionDePesosToolStripMenuItem,
            this.lPMToolStripMenuItem,
            this.salarioToolStripMenuItem,
            this.chicharroneraToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // areaTrianguloToolStripMenuItem
            // 
            this.areaTrianguloToolStripMenuItem.Name = "areaTrianguloToolStripMenuItem";
            this.areaTrianguloToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.areaTrianguloToolStripMenuItem.Text = "Area Triangulo";
            this.areaTrianguloToolStripMenuItem.Click += new System.EventHandler(this.areaTrianguloToolStripMenuItem_Click);
            // 
            // conversionDePesosToolStripMenuItem
            // 
            this.conversionDePesosToolStripMenuItem.Name = "conversionDePesosToolStripMenuItem";
            this.conversionDePesosToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.conversionDePesosToolStripMenuItem.Text = "Conversion de pesos";
            this.conversionDePesosToolStripMenuItem.Click += new System.EventHandler(this.conversionDePesosToolStripMenuItem_Click);
            // 
            // lPMToolStripMenuItem
            // 
            this.lPMToolStripMenuItem.Name = "lPMToolStripMenuItem";
            this.lPMToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.lPMToolStripMenuItem.Text = "LPM";
            this.lPMToolStripMenuItem.Click += new System.EventHandler(this.lPMToolStripMenuItem_Click);
            this.lPMToolStripMenuItem.DisplayStyleChanged += new System.EventHandler(this.lPMToolStripMenuItem_DisplayStyleChanged);
            // 
            // salarioToolStripMenuItem
            // 
            this.salarioToolStripMenuItem.Name = "salarioToolStripMenuItem";
            this.salarioToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.salarioToolStripMenuItem.Text = "Salario";
            this.salarioToolStripMenuItem.Click += new System.EventHandler(this.salarioToolStripMenuItem_Click);
            // 
            // chicharroneraToolStripMenuItem
            // 
            this.chicharroneraToolStripMenuItem.Name = "chicharroneraToolStripMenuItem";
            this.chicharroneraToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.chicharroneraToolStripMenuItem.Text = "Chicharronera";
            this.chicharroneraToolStripMenuItem.Click += new System.EventHandler(this.chicharroneraToolStripMenuItem_Click);
            // 
            // ejerciciosToolStripMenuItem1
            // 
            this.ejerciciosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureViewerToolStripMenuItem});
            this.ejerciciosToolStripMenuItem1.Name = "ejerciciosToolStripMenuItem1";
            this.ejerciciosToolStripMenuItem1.Size = new System.Drawing.Size(93, 29);
            this.ejerciciosToolStripMenuItem1.Text = "Guiados";
            this.ejerciciosToolStripMenuItem1.Click += new System.EventHandler(this.ejerciciosToolStripMenuItem1_Click);
            // 
            // pictureViewerToolStripMenuItem
            // 
            this.pictureViewerToolStripMenuItem.Name = "pictureViewerToolStripMenuItem";
            this.pictureViewerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pictureViewerToolStripMenuItem.Text = "Picture Viewer";
            this.pictureViewerToolStripMenuItem.Click += new System.EventHandler(this.pictureViewerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ejerciciosgg.Properties.Resources.ae24303c_7183_40f1_a51f_2928ddd4100e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionDePesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chicharroneraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pictureViewerToolStripMenuItem;
    }
}

