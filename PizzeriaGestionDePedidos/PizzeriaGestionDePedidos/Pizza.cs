using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaGestionDePedidos
{
    class Pizza : Producto
    {
        string ingredientes;
        char size;
        public Pizza() { }
        public Pizza(String nombre,double precio, string ingredientes):base(nombre,precio) {
            Ingredientes = ingredientes;
        }

        public string Ingredientes
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }
        public char Size
        {
            get { return size; }
            set { size = value; }
        }

    }
}
