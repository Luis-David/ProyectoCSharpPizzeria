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
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenToolStripMenuItem,
            this.consultarOrdenToolStripMenuItem,
            this.verTodasLasOrdenesToolStripMenuItem,
            this.ampliarOrdenToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaOrdenToolStripMenuItem
            // 
            this.nuevaOrdenToolStripMenuItem.Name = "nuevaOrdenToolStripMenuItem";
            this.nuevaOrdenToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.nuevaOrdenToolStripMenuItem.Text = "Nueva Orden ";
            this.nuevaOrdenToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenToolStripMenuItem_Click);
            // 
            // consultarOrdenToolStripMenuItem
            // 
            this.consultarOrdenToolStripMenuItem.Name = "consultarOrdenToolStripMenuItem";
            this.consultarOrdenToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.consultarOrdenToolStripMenuItem.Text = "Consultar Orden";
            this.consultarOrdenToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdenToolStripMenuItem_Click);
            // 
            // verTodasLasOrdenesToolStripMenuItem
            // 
            this.verTodasLasOrdenesToolStripMenuItem.Name = "verTodasLasOrdenesToolStripMenuItem";
            this.verTodasLasOrdenesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.verTodasLasOrdenesToolStripMenuItem.Text = "Ver todas las ordenes";
            this.verTodasLasOrdenesToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasOrdenesToolStripMenuItem_Click);
            // 
            // ampliarOrdenToolStripMenuItem
            // 
            this.ampliarOrdenToolStripMenuItem.Name = "ampliarOrdenToolStripMenuItem";
            this.ampliarOrdenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ampliarOrdenToolStripMenuItem.Text = "Ampliar Catálogo";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(76, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 157);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PizzeriaGestionDePedidos.Properties.Resources.dominos_pizza_cyber_monday_jpg;
            this.pictureBox3.Location = new System.Drawing.Point(0, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(516, 312);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(677, 342);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pizzeria El Becario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

