namespace PizzeriaGestionDePedidos
{
    partial class AgregarProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbRefresco = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tbLitros = new System.Windows.Forms.TextBox();
            this.lbLitros = new System.Windows.Forms.Label();
            this.btImagen = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIngredientes = new System.Windows.Forms.Label();
            this.tbIngredientes = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(149, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(149, 67);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label2.Location = new System.Drawing.Point(79, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lbSize.Location = new System.Drawing.Point(79, 138);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(64, 18);
            this.lbSize.TabIndex = 6;
            this.lbSize.Text = "Tamaño:";
            this.lbSize.Click += new System.EventHandler(this.label3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.rbPizza.Location = new System.Drawing.Point(39, 24);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(66, 22);
            this.rbPizza.TabIndex = 7;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbRefresco
            // 
            this.rbRefresco.AutoSize = true;
            this.rbRefresco.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.rbRefresco.Location = new System.Drawing.Point(39, 57);
            this.rbRefresco.Name = "rbRefresco";
            this.rbRefresco.Size = new System.Drawing.Size(90, 22);
            this.rbRefresco.TabIndex = 8;
            this.rbRefresco.TabStop = true;
            this.rbRefresco.Text = "Refresco";
            this.rbRefresco.UseVisualStyleBackColor = true;
            this.rbRefresco.CheckedChanged += new System.EventHandler(this.rbRefresco_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSize);
            this.panel1.Controls.Add(this.tbLitros);
            this.panel1.Controls.Add(this.lbLitros);
            this.panel1.Controls.Add(this.btImagen);
            this.panel1.Controls.Add(this.tbDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbIngredientes);
            this.panel1.Controls.Add(this.tbIngredientes);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPrecio);
            this.panel1.Controls.Add(this.lbSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(138, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 310);
            this.panel1.TabIndex = 10;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Chica",
            "Mediana",
            "Grande",
            "Familiar"});
            this.cbSize.Location = new System.Drawing.Point(149, 136);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 14;
            // 
            // tbLitros
            // 
            this.tbLitros.Location = new System.Drawing.Point(149, 136);
            this.tbLitros.Name = "tbLitros";
            this.tbLitros.Size = new System.Drawing.Size(100, 20);
            this.tbLitros.TabIndex = 13;
            // 
            // lbLitros
            // 
            this.lbLitros.AutoSize = true;
            this.lbLitros.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lbLitros.Location = new System.Drawing.Point(79, 139);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(64, 18);
            this.lbLitros.TabIndex = 12;
            this.lbLitros.Text = "Litros:";
            // 
            // btImagen
            // 
            this.btImagen.BackColor = System.Drawing.Color.IndianRed;
            this.btImagen.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btImagen.Location = new System.Drawing.Point(80, 256);
            this.btImagen.Name = "btImagen";
            this.btImagen.Size = new System.Drawing.Size(169, 33);
            this.btImagen.TabIndex = 11;
            this.btImagen.Text = "Cargar Imagen";
            this.btImagen.UseVisualStyleBackColor = false;
            this.btImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(149, 104);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label3.Location = new System.Drawing.Point(39, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción:";
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.AutoSize = true;
            this.lbIngredientes.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lbIngredientes.Location = new System.Drawing.Point(31, 174);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(112, 18);
            this.lbIngredientes.TabIndex = 8;
            this.lbIngredientes.Text = "Ingredientes:";
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.Location = new System.Drawing.Point(149, 174);
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Size = new System.Drawing.Size(100, 20);
            this.tbIngredientes.TabIndex = 7;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(699, 359);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(618, 359);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(75, 23);
            this.btRegresar.TabIndex = 13;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PizzeriaGestionDePedidos.Properties.Resources.no_imagen;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(524, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbRefresco);
            this.Controls.Add(this.rbPizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSize;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton rbRefresco;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIngredientes;
        private System.Windows.Forms.TextBox tbIngredientes;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.TextBox tbLitros;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.ComboBox cbSize;
    }
}