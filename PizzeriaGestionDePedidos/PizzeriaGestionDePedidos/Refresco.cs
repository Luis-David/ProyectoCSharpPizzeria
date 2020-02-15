using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaGestionDePedidos
{
    class Refresco:Producto
    {
        int litros;

        public Refresco() { }
        public Refresco(String nombre,double precio, int litros):base(nombre,precio)
        {
            Litros = litros;
        }
          
        public int Litros
        {
            get { return litros; }
            set { litros = value > 0 ? value : 0; }
        }
    }
}
