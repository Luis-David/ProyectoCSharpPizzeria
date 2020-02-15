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
        public Pizza() { }
        public Pizza(String nombre,double precio, string ingredientes):base(nombre,precio) {
            Ingrediente = ingredientes;
        }

        public string Ingrediente
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }


    }
}
