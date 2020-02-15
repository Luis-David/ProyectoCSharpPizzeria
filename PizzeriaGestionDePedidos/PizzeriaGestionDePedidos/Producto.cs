using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaGestionDePedidos
{
    class Producto
    {
        string nombre;
        double precio;
        string descripción;

        public Producto() { }
        public Producto(String nombre, double precio) {
            Nombre = nombre;
            Precio = precio;
        }

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { if (value > 0) precio = value; }
        }
        public string Descripcion
        {
            get { return descripción; }
            set { descripción = value; }
        }
    }
}
