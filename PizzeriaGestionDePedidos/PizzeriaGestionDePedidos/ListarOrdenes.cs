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
    public partial class ListarOrdenes : Form
    {
        BDPizzeria bdPizzeria = new BDPizzeria();
        string s, t;

        public ListarOrdenes()
        {

            InitializeComponent();
        }

        private void ListarOrdenes_Load(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            var p = bdPizzeria.getOrdenes();
            if (p.Count == 0)
            {
                MessageBox.Show("No hay registros");
                this.Close();
            }
            else
            {
                foreach (Orden o in p)
                {
                    listBox1.Items.Add("Fecha: " + o.Fecha);
                    listBox1.Items.Add("Numero de Ficha: " + o.NumFicha);

                    int i = 0;

                    foreach (Producto x in o.Productos)
                    {
                        listBox1.Items.Add("Nombre: " + x.Nombre + "\n Precio: $" + x.Precio + "\n Cantidad: " + o.Cantidades[i++]);
                    }
                    listBox1.Items.Add("Total: $" + o.getTotal());

                    listBox1.Items.Add("------------------------------------------------------------------------------------------");
                }
            }

            


        }
    }
}
