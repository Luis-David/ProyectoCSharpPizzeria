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
        Orden or = new Orden();
        Pizza pg = new Pizza();
        Refresco r = new Refresco();
        List<Orden> orden = new List<Orden>();
        int indice;
        int count = 0;
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
   

        private void Menu_Pizzas_Grande_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //Menu_Pizzas_Grande.CheckedItems.IndexOf();
           
            if (Menu_Pizzas_Grande.GetItemChecked(0)){
                string medida = "Grande";
                string especialidad = "Peperoni";
                int precio = 100;
                PizzaO p1 = new PizzaO(especialidad, medida, precio);
            }


     

        }



        //*************************************ACCIONES PIZZA MEDIANA++++++++++++++++++++++++++++

      

        private void Menu_Pizza_Mediana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //*************************************ACCIONES PIZZA CHICA++++++++++++++++++++++++++++


   

        private void Menu_Pizza_Chica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fotos_Pizzas_Click(object sender, EventArgs e)
        {

        }

        private void Descrip_Pizzas_TextChanged(object sender, EventArgs e)
        {

        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Pizzas_Grande.Visible = true;
            labelGrande.Visible = true;
            Menu_Pizza_Mediana.Visible = true;
            labelMediana.Visible = true;
            Menu_Pizza_Chica.Visible = true;
            labelChica.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            numericUpDown4.Visible = true;
            numericUpDown5.Visible = true;

        }

        private void refrescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaRefrescos.Visible = true;
            labelRefrescos.Visible = true;
        }

        private void ListaRefrescos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatosDeLaOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VerOrden_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            or = new Orden();
            pg = new Pizza();
            r = new Refresco();

            //Pizzas Grandes
            if (Menu_Pizzas_Grande.GetItemChecked(0))
            {
                pg.Precio = 100;
                pg.Nombre = "Pepperoni";
                count = Convert.ToInt32(numericUpDown1.Value);
                or.agregarProducto(pg, count);
            }

            pg = new Pizza();
            if (Menu_Pizzas_Grande.GetItemChecked(1))
            {
                pg.Precio = 100;
                pg.Nombre = "Hawaiana";
                count = Convert.ToInt32(numericUpDown2.Value);
                indice = count;
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizzas_Grande.GetItemChecked(2))
            {
                pg.Precio = 120;
                pg.Nombre = "Carnes Frias";
                count = Convert.ToInt32(numericUpDown3.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizzas_Grande.GetItemChecked(3))
            {
                pg.Precio = 120;
                pg.Nombre = "Mexicana";
                count = Convert.ToInt32(numericUpDown4.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizzas_Grande.GetItemChecked(4))
            {
                pg.Precio = 120;
                pg.Nombre = "Cuatro Quesos";
                count = Convert.ToInt32(numericUpDown5.Value);
                or.agregarProducto(pg, count);
            }

            foreach (var s in Menu_Pizzas_Grande.CheckedItems)
            {
                listBox1.Items.Add(s);
            }

            //Pizzas Mediana
            if (Menu_Pizza_Mediana.GetItemChecked(0))
            {
                pg.Precio = 80;
                pg.Nombre = "Pepperoni";
                count = Convert.ToInt32(numericUpDown6.Value);
                or.agregarProducto(pg, count);
            }

            pg = new Pizza();
            if (Menu_Pizza_Mediana.GetItemChecked(1))
            {
                pg.Precio = 80;
                pg.Nombre = "Hawaiana";
                count = Convert.ToInt32(numericUpDown7.Value);
                indice = count;
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Mediana.GetItemChecked(2))
            {
                pg.Precio = 100;
                pg.Nombre = "Carnes Frias";
                count = Convert.ToInt32(numericUpDown8.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Mediana.GetItemChecked(3))
            {
                pg.Precio = 100;
                pg.Nombre = "Mexicana";
                count = Convert.ToInt32(numericUpDown9.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Mediana.GetItemChecked(4))
            {
                pg.Precio = 100;
                pg.Nombre = "Cuatro Quesos";
                count = Convert.ToInt32(numericUpDown10.Value);
                or.agregarProducto(pg, count);
            }

            foreach (var s in Menu_Pizza_Mediana.CheckedItems)
            {
                listBox1.Items.Add(s);
            }

            //Pizzas Chica
            if (Menu_Pizza_Chica.GetItemChecked(0))
            {
                pg.Precio = 60;
                pg.Nombre = "Pepperoni";
                count = Convert.ToInt32(numericUpDown11.Value);
                or.agregarProducto(pg, count);
            }

            pg = new Pizza();
            if (Menu_Pizza_Chica.GetItemChecked(1))
            {
                pg.Precio = 60;
                pg.Nombre = "Hawaiana";
                count = Convert.ToInt32(numericUpDown12.Value);
                indice = count;
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Chica.GetItemChecked(2))
            {
                pg.Precio = 80;
                pg.Nombre = "Carnes Frias";
                count = Convert.ToInt32(numericUpDown13.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Chica.GetItemChecked(3))
            {
                pg.Precio = 80;
                pg.Nombre = "Mexicana";
                count = Convert.ToInt32(numericUpDown14.Value);
                or.agregarProducto(pg, count);

            }

            pg = new Pizza();
            if (Menu_Pizza_Chica.GetItemChecked(4))
            {
                pg.Precio = 80;
                pg.Nombre = "Cuatro Quesos";
                count = Convert.ToInt32(numericUpDown15.Value);
                or.agregarProducto(pg, count);
            }

            foreach (var s in Menu_Pizza_Chica.CheckedItems)
            {
                listBox1.Items.Add(s);
            }

            //Refrescos
            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(0))
            {
                r.Precio = 15;
                r.Nombre = "Coca Cola";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(1))
            {
                r.Precio = 15;
                r.Nombre = "Pepsi";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }
            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(2))
            {
                r.Precio = 15;
                r.Nombre = "Manzanita";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(3))
            {
                r.Precio = 15;
                r.Nombre = "7Up";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(4))
            {
                r.Precio = 15;
                r.Nombre = "Mirinda";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(5))
            {
                r.Precio = 15;
                r.Nombre = "Sangria";
                or.agregarProducto(r, indice);
                orden.Add(or);
            }
            foreach (string m in ListaRefrescos.CheckedItems)
            {
                listBox1.Items.Add(m);
            }

            listBox1.Items.Add("Total: " + or.getTotal());
        }
    }


    public class PizzaO
    {
        string Especialidad;
        string Medida;
        int Precio;
        int Cantidad;

        public PizzaO(string especialidad,string medida,int precio)
        {
            Especialidad = especialidad;
            Medida = medida;
            Precio = precio;
            Cantidad = 1;

        }

    }


    public class OrdenP
    {
        int NumeroO;
        string Medida;
        string Especialidad;
        string Refresco;


        public OrdenP(int numeroO, string medida,string especialidad, string refresco)
        {
            NumeroO = numeroO;
            Medida = medida;
            Especialidad = especialidad;
            Refresco = refresco;
        }

    }


}
