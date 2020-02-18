﻿using System;
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
        //List<Orden> orden = new List<Orden>();
        List<NumericUpDown> textNumericos = new List<NumericUpDown>();

        int indice;
        int count = 0;
        public NuevaOrden()
        {
            InitializeComponent();
            textNumericos.Add(numericUpDown1);
            textNumericos.Add(numericUpDown2);
            textNumericos.Add(numericUpDown3);
            textNumericos.Add(numericUpDown4);
            textNumericos.Add(numericUpDown5);
            textNumericos.Add(numericUpDown6);
            textNumericos.Add(numericUpDown7);
            textNumericos.Add(numericUpDown8);
            textNumericos.Add(numericUpDown9);
            textNumericos.Add(numericUpDown10);
            textNumericos.Add(numericUpDown11);
            textNumericos.Add(numericUpDown12);
            textNumericos.Add(numericUpDown13);
            textNumericos.Add(numericUpDown14);
            textNumericos.Add(numericUpDown15);
            textNumericos.Add(numericUpDown16);
            textNumericos.Add(numericUpDown17);
            textNumericos.Add(numericUpDown18);
            textNumericos.Add(numericUpDown19);
            textNumericos.Add(numericUpDown20);
            textNumericos.Add(numericUpDown21);
            textNumericos.Add(numericUpDown22);
            textNumericos.Add(numericUpDown23);
            textNumericos.Add(numericUpDown24);
            textNumericos.Add(numericUpDown25);
            textNumericos.Add(numericUpDown26);
            textNumericos.Add(numericUpDown27);
            textNumericos.Add(numericUpDown28);
            textNumericos.Add(numericUpDown29);
            textNumericos.Add(numericUpDown30);
            textNumericos.Add(numericUpDown31);
            textNumericos.Add(numericUpDown32);
            textNumericos.Add(numericUpDown33);

            foreach(NumericUpDown n in textNumericos)
            {
                n.Value = 1;
            }
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

            //Refrescos 2Lts.
            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(0))
            {
                r.Precio = 35;
                r.Nombre = "Coca Cola";
                count = Convert.ToInt32(numericUpDown16.Value);
                or.agregarProducto(r, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(1))
            {
                r.Precio = 35;
                r.Nombre = "Pepsi";
                count = Convert.ToInt32(numericUpDown17.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(2))
            {
                r.Precio = 30;
                r.Nombre = "Manzanita";
                count = Convert.ToInt32(numericUpDown18.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(3))
            {
                r.Precio = 30;
                r.Nombre = "7Up";
                count = Convert.ToInt32(numericUpDown19.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(4))
            {
                r.Precio = 25;
                r.Nombre = "Mirinda";
                count = Convert.ToInt32(numericUpDown20.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (ListaRefrescos.GetItemChecked(5))
            {
                r.Precio = 25;
                r.Nombre = "Sangria";
                count = Convert.ToInt32(numericUpDown21.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            foreach (string m in ListaRefrescos.CheckedItems)
            {
                listBox1.Items.Add(m);
            }

            //Refrescos 1Lt.
            r = new Refresco();
            if (refrescos1.GetItemChecked(0))
            {
                r.Precio = 25;
                r.Nombre = "Coca Cola";
                count = Convert.ToInt32(numericUpDown22.Value);
                or.agregarProducto(r, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos1.GetItemChecked(1))
            {
                r.Precio = 25;
                r.Nombre = "Pepsi";
                count = Convert.ToInt32(numericUpDown23.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            r = new Refresco();
            if (refrescos1.GetItemChecked(2))
            {
                r.Precio = 20;
                r.Nombre = "Manzanita";
                count = Convert.ToInt32(numericUpDown24.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos1.GetItemChecked(3))
            {
                r.Precio = 20;
                r.Nombre = "7Up";
                count = Convert.ToInt32(numericUpDown25.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos1.GetItemChecked(4))
            {
                r.Precio = 20;
                r.Nombre = "Mirinda";
                count = Convert.ToInt32(numericUpDown26.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos1.GetItemChecked(5))
            {
                r.Precio = 20;
                r.Nombre = "Sangria";
                count = Convert.ToInt32(numericUpDown27.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            foreach (string m in refrescos1.CheckedItems)
            {
                listBox1.Items.Add(m);
            }

            //Refrescos 375ml.
            r = new Refresco();
            if (refrescos375.GetItemChecked(0))
            {
                r.Precio = 20;
                r.Nombre = "Coca Cola";
                count = Convert.ToInt32(numericUpDown28.Value);
                or.agregarProducto(r, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos375.GetItemChecked(1))
            {
                r.Precio = 20;
                r.Nombre = "Pepsi";
                count = Convert.ToInt32(numericUpDown29.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            r = new Refresco();
            if (refrescos375.GetItemChecked(2))
            {
                r.Precio = 15;
                r.Nombre = "Manzanita";
                count = Convert.ToInt32(numericUpDown30.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos375.GetItemChecked(3))
            {
                r.Precio = 15;
                r.Nombre = "7Up";
                count = Convert.ToInt32(numericUpDown31.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos375.GetItemChecked(4))
            {
                r.Precio = 15;
                r.Nombre = "Mirinda";
                count = Convert.ToInt32(numericUpDown32.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }

            r = new Refresco();
            if (refrescos375.GetItemChecked(5))
            {
                r.Precio = 15;
                r.Nombre = "Sangria";
                count = Convert.ToInt32(numericUpDown33.Value);
                or.agregarProducto(pg, count);
                //orden.Add(or);
            }
            foreach (string m in refrescos375.CheckedItems)
            {
                listBox1.Items.Add(m);
            }

            listBox1.Items.Add("Total: " + or.getTotal());
            BDPizzeria bd = new BDPizzeria();
            bd.guardarOrden(or);
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
