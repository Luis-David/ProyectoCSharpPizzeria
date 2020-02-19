using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaGestionDePedidos
{
    public partial class ConsultarOrden : Form
    {
        BDPizzeria bDPizzeria = new BDPizzeria();
        public ConsultarOrden()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contenido = 0;

            try
            {
                contenido = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException formate)
            {
                MessageBox.Show("Debe ingresar un numero");
            }
            foreach (Orden o in bDPizzeria.getOrdenes())
            {
                if (contenido == o.NumFicha)
                {

                    listBox1.Items.Add("Fecha: " + o.Fecha);
                    listBox1.Items.Add("Numero de Ficha: " + o.NumFicha);

                    int i = 0;
                    foreach (Producto x in o.Productos)
                    {
                        listBox1.Items.Add("Nombre: " + x.Nombre + "\n Precio: $" + x.Precio + "\n Cantidad: " + o.Cantidades[i++]);
                    }
                    listBox1.Items.Add("Total: $" + o.getTotal());
                }
                else
                {
                    MessageBox.Show("Esa ficha no existe");
                }

            }
        }
    }
}
