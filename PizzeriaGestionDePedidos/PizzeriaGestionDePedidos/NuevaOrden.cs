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
    public partial class NuevaOrden : Form
    {
        public NuevaOrden()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //*************************************ACCIONES PIZZA GRANDE++++++++++++++++++++++++++++
        private void Pizza_Grande_Click(object sender, EventArgs e)
        {
            Menu_Pizzas_Grande.Visible = true;
            Menu_Pizza_Mediana.Visible = false;
            Menu_Pizza_Chica.Visible = false;

        }

        private void Menu_Pizzas_Grande_SelectedIndexChanged(object sender, EventArgs e)
        {


                Fotos_Pizzas.Visible = true;
                Fotos_Pizzas.ImageLocation = "C:/Users/damia/source/repos/ProyectoCSharpPizzeria/PizzeriaGestionDePedidos/PizzeriaGestionDePedidos/img/pepperoni.jpg";
            

        }



        //*************************************ACCIONES PIZZA MEDIANA++++++++++++++++++++++++++++

        private void Pizza_Mediana_Click(object sender, EventArgs e)
        {

            Menu_Pizzas_Grande.Visible = false;
            Menu_Pizza_Mediana.Visible = true;
            Menu_Pizza_Chica.Visible = false;
        }

        private void Menu_Pizza_Mediana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //*************************************ACCIONES PIZZA CHICA++++++++++++++++++++++++++++


        private void Pizza_Chica_Click(object sender, EventArgs e)
        {
            Menu_Pizzas_Grande.Visible = false;
            Menu_Pizza_Mediana.Visible = false;
            Menu_Pizza_Chica.Visible = true;
        }

        private void Menu_Pizza_Chica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fotos_Pizzas_Click(object sender, EventArgs e)
        {

        }

        private void Descrip_Pizzas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
