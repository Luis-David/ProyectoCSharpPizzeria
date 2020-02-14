namespace PizzeriaGestionDePedidos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenToolStripMenuItem,
            this.consultarOrdenToolStripMenuItem,
            this.verTodasLasOrdenesToolStripMenuItem,
            this.ampliarOrdenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaOrdenToolStripMenuItem
            // 
            this.nuevaOrdenToolStripMenuItem.Name = "nuevaOrdenToolStripMenuItem";
            this.nuevaOrdenToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.nuevaOrdenToolStripMenuItem.Text = "Nueva Orden ";
            // 
            // consultarOrdenToolStripMenuItem
            // 
            this.consultarOrdenToolStripMenuItem.Name = "consultarOrdenToolStripMenuItem";
            this.consultarOrdenToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.consultarOrdenToolStripMenuItem.Text = "Consultar Orden";
            // 
            // verTodasLasOrdenesToolStripMenuItem
            // 
            this.verTodasLasOrdenesToolStripMenuItem.Name = "verTodasLasOrdenesToolStripMenuItem";
            this.verTodasLasOrdenesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.verTodasLasOrdenesToolStripMenuItem.Text = "Ver todas las ordenes";
            // 
            // ampliarOrdenToolStripMenuItem
            // 
            this.ampliarOrdenToolStripMenuItem.Name = "ampliarOrdenToolStripMenuItem";
            this.ampliarOrdenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ampliarOrdenToolStripMenuItem.Text = "Ampliar Catálogo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pizzeria El Becario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarOrdenToolStripMenuItem;
    }
}

