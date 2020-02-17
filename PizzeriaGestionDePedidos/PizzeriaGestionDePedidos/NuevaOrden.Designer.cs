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
            this.Menu_Pizzas_Grande = new System.Windows.Forms.CheckedListBox();
            this.Menu_Pizza_Mediana = new System.Windows.Forms.CheckedListBox();
            this.Menu_Pizza_Chica = new System.Windows.Forms.CheckedListBox();
            this.ListaRefrescos = new System.Windows.Forms.CheckedListBox();
            this.labelGrande = new System.Windows.Forms.Label();
            this.labelMediana = new System.Windows.Forms.Label();
            this.labelChica = new System.Windows.Forms.Label();
            this.labelRefrescos = new System.Windows.Forms.Label();
            this.DatosDeLaOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerOrden = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip3.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(611, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finalizar Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ListaRefrescos.Location = new System.Drawing.Point(273, 47);
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
            this.labelRefrescos.Location = new System.Drawing.Point(322, 31);
            this.labelRefrescos.Name = "labelRefrescos";
            this.labelRefrescos.Size = new System.Drawing.Size(67, 13);
            this.labelRefrescos.TabIndex = 15;
            this.labelRefrescos.Text = "Refrecos 2lt.";
            this.labelRefrescos.Visible = false;
            // 
            // DatosDeLaOrden
            // 
            this.DatosDeLaOrden.Location = new System.Drawing.Point(517, 62);
            this.DatosDeLaOrden.Multiline = true;
            this.DatosDeLaOrden.Name = "DatosDeLaOrden";
            this.DatosDeLaOrden.Size = new System.Drawing.Size(169, 151);
            this.DatosDeLaOrden.TabIndex = 16;
            this.DatosDeLaOrden.Visible = false;
            this.DatosDeLaOrden.TextChanged += new System.EventHandler(this.DatosDeLaOrden_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(556, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Datos de la Orden";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VerOrden
            // 
            this.VerOrden.Location = new System.Drawing.Point(517, 223);
            this.VerOrden.Name = "VerOrden";
            this.VerOrden.Size = new System.Drawing.Size(75, 23);
            this.VerOrden.TabIndex = 18;
            this.VerOrden.Text = "Ver Orden";
            this.VerOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VerOrden.UseMnemonic = false;
            this.VerOrden.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox1.Location = new System.Drawing.Point(191, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(19, 17);
            this.listBox1.TabIndex = 19;
            // 
            // NuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(698, 337);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.VerOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosDeLaOrden);
            this.Controls.Add(this.labelRefrescos);
            this.Controls.Add(this.labelChica);
            this.Controls.Add(this.labelMediana);
            this.Controls.Add(this.labelGrande);
            this.Controls.Add(this.ListaRefrescos);
            this.Controls.Add(this.Menu_Pizza_Chica);
            this.Controls.Add(this.Menu_Pizza_Mediana);
            this.Controls.Add(this.Menu_Pizzas_Grande);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "NuevaOrden";
            this.Text = "NuevaOrden";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem pizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox Menu_Pizzas_Grande;
        private System.Windows.Forms.CheckedListBox Menu_Pizza_Mediana;
        private System.Windows.Forms.CheckedListBox Menu_Pizza_Chica;
        private System.Windows.Forms.CheckedListBox ListaRefrescos;
        private System.Windows.Forms.Label labelGrande;
        private System.Windows.Forms.Label labelMediana;
        private System.Windows.Forms.Label labelChica;
        private System.Windows.Forms.Label labelRefrescos;
        private System.Windows.Forms.TextBox DatosDeLaOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerOrden;
        private System.Windows.Forms.ListBox listBox1;
    }
}