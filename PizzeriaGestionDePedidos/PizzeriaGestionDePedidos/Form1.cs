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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creditos \n Damian \n Oscar \n Luis");
        }

        private void consultarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarOrden co = new ConsultarOrden();
            co.Owner = this;
            co.ShowDialog();
        }

        private void verTodasLasOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarOrdenes lo = new ListarOrdenes();
            lo.Visible = true;
        }

        private void ampliarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto co = new AgregarProducto();
            co.Owner = this;
            co.ShowDialog();
        }
    }
}
