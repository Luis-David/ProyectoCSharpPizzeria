using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzeriaGestionDePedidos
{
    class Orden
    {
        long id;
        List<Producto> productos;
        List<int> cantidades;
        string fecha;
        int numFicha;
        static int numFichas;

        public Orden()
        {
            productos = new List<Producto>();
            cantidades = new List<int>();
            fecha = DateTime.Now.ToString();
            numFicha=numFichas++;
        }
        public Orden(string fecha,int numFicha)
        {
            productos = new List<Producto>();
            cantidades = new List<int>();
            this.fecha = fecha;
            this.numFicha=numFicha;
        }
        public int NumFicha
        {
            get { return numFicha; }
            set { numFicha = value; }
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
        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
        public List<int> Cantidades
        {
            get { return cantidades; }
            set { cantidades = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
