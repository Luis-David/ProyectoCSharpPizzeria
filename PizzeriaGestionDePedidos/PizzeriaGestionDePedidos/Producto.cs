using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaGestionDePedidos
{
    public class Producto
    {
        long id;
        string nombre;
        double precio;
        string descripción;
        string urlImagen;
        public Producto() { }
        public Producto(String nombre, double precio) {
            Nombre = nombre;
            Precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
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
        public long ID
        {
            get{return id;}
            set { id = value; }
        }
        public string UrlImagen
        {
            get { return urlImagen; }
            set { urlImagen = value; }
        }
    }
}
