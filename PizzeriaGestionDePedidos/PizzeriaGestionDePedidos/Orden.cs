using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzeriaGestionDePedidos
{
    class Orden
    {
        List<Producto> productos;
        List<int> cantidades;
        DateTime fecha;
        static int numFicha;

        public Orden()
        {
            productos = new List<Producto>();
            cantidades = new List<int>();
            fecha = DateTime.Now;
            numFicha++;
        }
        public void agregarProducto(Producto p,int cantidad)
        {
            productos.Add(p);
            cantidades.Add(cantidad);
        }
        public double getTotal()
        {
            double total=0;
            int[] c = cantidades.ToArray();
            int i = 0;
            foreach(var p in productos)
            {
                total += (p.Precio * c[i++]);
            }
            return total;
        }
        public string getInfo()
        {
            string cadena="";
            int[] c = cantidades.ToArray();
            int i = 0;
            cadena += "\nProducto\tPrecio\tCantidad\tSubtotal";
            foreach(var p in productos)
            {
                cadena += "\n "+p.Nombre+"\t\t"+p.Precio+"\t"+c[i]+"\t"+(p.Precio*c[i++]);
            }
            cadena += "\nTotal: " + getTotal();
            return cadena;
        }
    }
}
