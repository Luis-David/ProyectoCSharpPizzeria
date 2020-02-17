using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PizzeriaGestionDePedidos
{
    public partial class AgregarProducto : Form
    {
        BDPizzeria bdPizzeria;
        public AgregarProducto()
        {
            bdPizzeria = new BDPizzeria();
            InitializeComponent();
            cbSize.SelectedIndex=0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbLitros.Visible = false;
            lbIngredientes.Visible = true;
            lbSize.Visible = true;

            tbLitros.Visible = false;
            tbIngredientes.Visible = true;
            cbSize.Visible = true;
            
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbRefresco_CheckedChanged(object sender, EventArgs e)
        {
            lbLitros.Visible = true;
            lbIngredientes.Visible = false;
            lbSize.Visible = false;

            tbLitros.Visible = true;
            tbIngredientes.Visible = false;
            cbSize.Visible = false;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string opcion=rbPizza.Checked ? "pizza":"refresco";
            string urlImagen = "C:\\Users\\Public\\Pictures\\"+Path.GetFileName(openFileDialog1.FileName);
            Producto producto=null;
            try
            {
                if (opcion.Equals("pizza"))
                {
                    if (validarCampos("pizza"))
                    {

                        Pizza pizza = new Pizza();
                        pizza.Nombre = tbNombre.Text;
                        pizza.Precio = Convert.ToDouble(tbPrecio.Text);
                        pizza.Descripcion = tbDescripcion.Text;
                        pizza.Ingredientes = tbIngredientes.Text;
                        pizza.Size = cbSize.Text[0];
                        pizza.UrlImagen = urlImagen;
                        producto = pizza;
                    }
                }
                else
                {
                    if (validarCampos("refresco"))
                    {
                        Refresco p = new Refresco();
                        p.Nombre = tbNombre.Text;
                        p.Precio = Convert.ToDouble(tbPrecio.Text);
                        p.Descripcion = tbDescripcion.Text;
                        p.UrlImagen = urlImagen;
                        p.Litros = Convert.ToInt32(tbLitros.Text);
                        producto = p;
                    }
                }
                if (producto != null)
                {
                    bdPizzeria.guardarProducto(producto);
                    FileInfo f = new FileInfo(openFileDialog1.FileName);
                    f.CopyTo(producto.UrlImagen);

                    MessageBox.Show("Se agregó correctamente el nuevo producto. ");
                    limipiarVentana();
                }
                
                
                
                

            }
            catch(FormatException excep)
            {
                MessageBox.Show("Error: se debe de especificar en numeros.");
            }
            catch(FileNotFoundException excep)
            {
                MessageBox.Show("Debe de seleccionar una imagen");
            }
            catch(IOException exceo)
            {
                MessageBox.Show("El nombre de la imagen ya existe. Elige otro o cambia el nombre de la imagen.");

            }
        }
        public bool validarCampos(string producto)
        {
            bool exito = true;
            if (tbNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo nombre no debe de estar vacio");
                exito = false;
            }
            if (tbPrecio.Text.Trim().Length == 0) {
                MessageBox.Show("Se debe de poner un precio.");
                exito = false;
            }
            if (producto.Equals("pizza"))
            {
                if (tbIngredientes.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe de escribir los ingredientes de la nueva pizza a agregar.");
                    exito = false;

                }
            }
            else
            {
                if (tbLitros.Text.Trim().Length== 0)
                {
                    MessageBox.Show("El campo litros no debe de quedar vacio.");
                    exito = false;
                }
            }
            return exito;
        }
        public void limipiarVentana()
        {
            tbNombre.Text="";
            tbPrecio.Text = "";
            tbDescripcion.Text = "";
            tbIngredientes.Text = "";
            cbSize.SelectedIndex=0;
            tbLitros.Text = "";
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
