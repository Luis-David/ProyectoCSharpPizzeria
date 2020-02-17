namespace PizzeriaGestionDePedidos
{
    partial class NuevaOrden
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.pizzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Menu_Pizzas_Grande = new System.Windows.Forms.CheckedListBox();
            this.Descrip_Pizzas = new System.Windows.Forms.TextBox();
            this.Menu_Pizza_Mediana = new System.Windows.Forms.CheckedListBox();
            this.Menu_Pizza_Chica = new System.Windows.Forms.CheckedListBox();
            this.Fotos_Pizzas = new System.Windows.Forms.PictureBox();
            this.ListaRefrescos = new System.Windows.Forms.CheckedListBox();
            this.labelGrande = new System.Windows.Forms.Label();
            this.labelMediana = new System.Windows.Forms.Label();
            this.labelChica = new System.Windows.Forms.Label();
            this.labelRefrescos = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fotos_Pizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzasToolStripMenuItem,
            this.refrescosToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(698, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // pizzasToolStripMenuItem
            // 
            this.pizzasToolStripMenuItem.Name = "pizzasToolStripMenuItem";
            this.pizzasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pizzasToolStripMenuItem.Text = "Pizzas";
            this.pizzasToolStripMenuItem.Click += new System.EventHandler(this.pizzasToolStripMenuItem_Click);
            // 
            // refrescosToolStripMenuItem
            // 
            this.refrescosToolStripMenuItem.Name = "refrescosToolStripMenuItem";
            this.refrescosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.refrescosToolStripMenuItem.Text = "Refrescos";
            this.refrescosToolStripMenuItem.Click += new System.EventHandler(this.refrescosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finalizar Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ver Orden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu_Pizzas_Grande
            // 
            this.Menu_Pizzas_Grande.FormattingEnabled = true;
            this.Menu_Pizzas_Grande.Items.AddRange(new object[] {
            "Pepperoni\t\t$100",
            "Hawaiana\t\t$100",
            "Carnes Frías\t\t$120",
            "Mexicana\t\t$120",
            "Cuatro Quesos\t\t$120"});
            this.Menu_Pizzas_Grande.Location = new System.Drawing.Point(12, 47);
            this.Menu_Pizzas_Grande.Name = "Menu_Pizzas_Grande";
            this.Menu_Pizzas_Grande.Size = new System.Drawing.Size(173, 79);
            this.Menu_Pizzas_Grande.TabIndex = 6;
            this.Menu_Pizzas_Grande.Visible = false;
            this.Menu_Pizzas_Grande.SelectedIndexChanged += new System.EventHandler(this.Menu_Pizzas_Grande_SelectedIndexChanged);
            // 
            // Descrip_Pizzas
            // 
            this.Descrip_Pizzas.Location = new System.Drawing.Point(505, 121);
            this.Descrip_Pizzas.Multiline = true;
            this.Descrip_Pizzas.Name = "Descrip_Pizzas";
            this.Descrip_Pizzas.Size = new System.Drawing.Size(169, 79);
            this.Descrip_Pizzas.TabIndex = 8;
            this.Descrip_Pizzas.Visible = false;
            this.Descrip_Pizzas.TextChanged += new System.EventHandler(this.Descrip_Pizzas_TextChanged);
            // 
            // Menu_Pizza_Mediana
            // 
            this.Menu_Pizza_Mediana.FormattingEnabled = true;
            this.Menu_Pizza_Mediana.Items.AddRange(new object[] {
            "Pepperoni\t\t$80",
            "Hawaiana\t\t$80",
            "Carnes Frías\t\t$100",
            "Mexicana\t\t$100",
            "Cuatro Quesos\t\t$100"});
            this.Menu_Pizza_Mediana.Location = new System.Drawing.Point(12, 150);
            this.Menu_Pizza_Mediana.Name = "Menu_Pizza_Mediana";
            this.Menu_Pizza_Mediana.Size = new System.Drawing.Size(173, 79);
            this.Menu_Pizza_Mediana.TabIndex = 9;
            this.Menu_Pizza_Mediana.Visible = false;
            this.Menu_Pizza_Mediana.SelectedIndexChanged += new System.EventHandler(this.Menu_Pizza_Mediana_SelectedIndexChanged);
            // 
            // Menu_Pizza_Chica
            // 
            this.Menu_Pizza_Chica.FormattingEnabled = true;
            this.Menu_Pizza_Chica.Items.AddRange(new object[] {
            "Pepperoni\t\t$60",
            "Hawaiana\t\t$60",
            "Carnes Frías\t\t$80",
            "Mexicana\t\t$80",
            "Cuatro Quesos\t\t$80"});
            this.Menu_Pizza_Chica.Location = new System.Drawing.Point(12, 249);
            this.Menu_Pizza_Chica.Name = "Menu_Pizza_Chica";
            this.Menu_Pizza_Chica.Size = new System.Drawing.Size(173, 79);
            this.Menu_Pizza_Chica.TabIndex = 10;
            this.Menu_Pizza_Chica.Visible = false;
            this.Menu_Pizza_Chica.SelectedIndexChanged += new System.EventHandler(this.Menu_Pizza_Chica_SelectedIndexChanged);
            // 
            // Fotos_Pizzas
            // 
            this.Fotos_Pizzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Fotos_Pizzas.ImageLocation = "";
            this.Fotos_Pizzas.Location = new System.Drawing.Point(505, 36);
            this.Fotos_Pizzas.Name = "Fotos_Pizzas";
            this.Fotos_Pizzas.Size = new System.Drawing.Size(169, 79);
            this.Fotos_Pizzas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fotos_Pizzas.TabIndex = 7;
            this.Fotos_Pizzas.TabStop = false;
            this.Fotos_Pizzas.Visible = false;
            this.Fotos_Pizzas.Click += new System.EventHandler(this.Fotos_Pizzas_Click);
            // 
            // ListaRefrescos
            // 
            this.ListaRefrescos.FormattingEnabled = true;
            this.ListaRefrescos.Items.AddRange(new object[] {
            "CocaCola",
            "Pepsi",
            "Manzanita",
            "7up",
            "Merinda",
            "Sangria"});
            this.ListaRefrescos.Location = new System.Drawing.Point(240, 47);
            this.ListaRefrescos.Name = "ListaRefrescos";
            this.ListaRefrescos.Size = new System.Drawing.Size(168, 94);
            this.ListaRefrescos.TabIndex = 11;
            this.ListaRefrescos.Visible = false;
            this.ListaRefrescos.SelectedIndexChanged += new System.EventHandler(this.ListaRefrescos_SelectedIndexChanged);
            // 
            // labelGrande
            // 
            this.labelGrande.AutoSize = true;
            this.labelGrande.BackColor = System.Drawing.Color.White;
            this.labelGrande.Location = new System.Drawing.Point(37, 31);
            this.labelGrande.Name = "labelGrande";
            this.labelGrande.Size = new System.Drawing.Size(80, 13);
            this.labelGrande.TabIndex = 12;
            this.labelGrande.Text = "Pizzas Grandes";
            this.labelGrande.Visible = false;
            // 
            // labelMediana
            // 
            this.labelMediana.AutoSize = true;
            this.labelMediana.BackColor = System.Drawing.Color.White;
            this.labelMediana.Location = new System.Drawing.Point(37, 134);
            this.labelMediana.Name = "labelMediana";
            this.labelMediana.Size = new System.Drawing.Size(86, 13);
            this.labelMediana.TabIndex = 13;
            this.labelMediana.Text = "Pizzas Medianas";
            this.labelMediana.Visible = false;
            // 
            // labelChica
            // 
            this.labelChica.AutoSize = true;
            this.labelChica.BackColor = System.Drawing.Color.White;
            this.labelChica.Location = new System.Drawing.Point(37, 233);
            this.labelChica.Name = "labelChica";
            this.labelChica.Size = new System.Drawing.Size(72, 13);
            this.labelChica.TabIndex = 14;
            this.labelChica.Text = "Pizzas Chicas";
            this.labelChica.Visible = false;
            // 
            // labelRefrescos
            // 
            this.labelRefrescos.AutoSize = true;
            this.labelRefrescos.BackColor = System.Drawing.Color.White;
            this.labelRefrescos.Location = new System.Drawing.Point(279, 31);
            this.labelRefrescos.Name = "labelRefrescos";
            this.labelRefrescos.Size = new System.Drawing.Size(67, 13);
            this.labelRefrescos.TabIndex = 15;
            this.labelRefrescos.Text = "Refrecos 2lt.";
            this.labelRefrescos.Visible = false;
            // 
            // NuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(698, 337);
            this.Controls.Add(this.labelRefrescos);
            this.Controls.Add(this.labelChica);
            this.Controls.Add(this.labelMediana);
            this.Controls.Add(this.labelGrande);
            this.Controls.Add(this.ListaRefrescos);
            this.Controls.Add(this.Menu_Pizza_Chica);
            this.Controls.Add(this.Menu_Pizza_Mediana);
            this.Controls.Add(this.Descrip_Pizzas);
            this.Controls.Add(this.Fotos_Pizzas);
            this.Controls.Add(this.Menu_Pizzas_Grande);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "NuevaOrden";
            this.Text = "NuevaOrden";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fotos_Pizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem pizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox Menu_Pizzas_Grande;
        private System.Windows.Forms.PictureBox Fotos_Pizzas;
        private System.Windows.Forms.TextBox Descrip_Pizzas;
        private System.Windows.Forms.CheckedListBox Menu_Pizza_Mediana;
        private System.Windows.Forms.CheckedListBox Menu_Pizza_Chica;
        private System.Windows.Forms.CheckedListBox ListaRefrescos;
        private System.Windows.Forms.Label labelGrande;
        private System.Windows.Forms.Label labelMediana;
        private System.Windows.Forms.Label labelChica;
        private System.Windows.Forms.Label labelRefrescos;
    }
}