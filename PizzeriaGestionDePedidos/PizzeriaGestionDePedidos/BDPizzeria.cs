using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaGestionDePedidos
{
    class BDPizzeria
    {
        NpgsqlConnection con;
        NpgsqlCommand coman;
        NpgsqlDataAdapter resp;
        public BDPizzeria()
        {

            con = new NpgsqlConnection();
            con.ConnectionString = "User ID=postgres; Password= 'hola123.,'; Host=127.0.0.1; Port=5432; Database=pizzeria;";
            con.Open();
            con.Close();
        }
        public List<Producto> getProductos()
        {
            List<Producto> productos = new List<Producto>();
            con.Open();
            coman = new NpgsqlCommand("select * from pizzas;", con);
            resp = new NpgsqlDataAdapter(coman);
            DataTable tpizzas = new DataTable();
            resp.Fill(tpizzas);

            Pizza p;
            foreach (DataRow fila in tpizzas.Rows)
            {
                p = new Pizza();
                p.ID = Convert.ToInt64(fila["id"]);
                p.Nombre =(string)fila["nombre"];
                p.Precio = Convert.ToDouble(fila["Precio"]);
                p.Descripcion = (string)fila["descripcion"];
                p.Ingredientes = (string)fila["ingredientes"];
                p.Size = Convert.ToChar(fila["size"]);
                p.UrlImagen= (string)fila["url_imagen"];
                productos.Add(p);
            }
            coman = new NpgsqlCommand("select * from refrescos;", con);
            resp = new NpgsqlDataAdapter(coman);
            DataTable tRefrescos = new DataTable();
            resp.Fill(tRefrescos);

            Refresco r;
            foreach (DataRow fila in tRefrescos.Rows)
            {
                r = new Refresco();
                r.ID = Convert.ToInt64(fila["id"]);
                r.Nombre = (string)fila["nombre"];
                r.Precio = Convert.ToDouble(fila["Precio"]);
                r.Descripcion = (string)fila["descripcion"];
                r.UrlImagen = (string)fila["url_imagen"];
                r.Litros = Convert.ToInt32(fila["litros"]);
                productos.Add(r);
            }

            con.Close();
            return productos;
        }
        public void guardarProducto(Producto p)
        {
            con.Open();
            string querysql = "insert into ";
            string valores=" values('";
            string tabla;
            Pizza pizza;
            Refresco r;
            tabla= Object.ReferenceEquals(p.GetType(),typeof(Pizza)) ? "pizzas":"refrescos";

            querysql += tabla + " (nombre,precio, descripcion,url_imagen,";
            valores += p.Nombre + "'," +
                p.Precio + ",'" +
                p.Descripcion + "','" +
                p.UrlImagen + "', ";
            if (tabla.Equals("pizzas"))
            {
                querysql += "ingredientes,size)";
                pizza = (Pizza)p;
                valores +="'"+ pizza.Ingredientes + "','"+pizza.Size+"'";
            }
            else
            {
                querysql += "litros)";
                r = (Refresco)p;
                valores += r.Litros;
            }
            valores += ")";
            querysql += valores;
            coman = new NpgsqlCommand(querysql, con);
            coman.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
