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
        Orden or = new Orden();
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
            //label2.Text = contenido;
            label2.Visible = true;
           /* for (int i = 0; i < contenido; i++)
            {
                label2.Text = "Numero de pedido: " + (i + 1).ToString() + or.getInfo();
            }*/
        }
    }
}
