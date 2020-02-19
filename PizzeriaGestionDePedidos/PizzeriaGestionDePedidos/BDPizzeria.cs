using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
        public void guardarOrden(Orden or)
        {
            con.Open();
            //Se guarda la orden en la base de datos
            string query = "insert into orden (fecha,num_ficha) values (";

            query +="'"+ DateTime.Now.ToString("G",
                  CultureInfo.CreateSpecificCulture("en-us")).ToString() + "',"+or.NumFicha+")";
            coman = new NpgsqlCommand(query, con);
            coman.ExecuteNonQuery();

            //Se obtiene el id de la orden que se guardo previamente.
            coman = new NpgsqlCommand("select max(id) from orden", con);
            resp = new NpgsqlDataAdapter(coman);
            DataTable tOrden = new DataTable();
            resp.Fill(tOrden);
            long idOrden = Convert.ToInt64(tOrden.Rows[0]["max"]);


            // se guardan las pizzas y refrescos
            int i = 0;
            query = "";
            foreach (Producto p in or.Productos)
            {
                query += "insert into ";
                query+=Object.ReferenceEquals(p.GetType(), typeof(Pizza)) ? "orden_pizzas":"orden_refrescos";
                query += " values ("+idOrden + "," + p.ID + "," + or.Cantidades[i++] + ");";
            }
            coman = new NpgsqlCommand(query, con);
            coman.ExecuteNonQuery();
            con.Close();

        }
        public List<Orden> getOrdenes()
        {
            List<Orden> ordenes = new List<Orden>();
            List<Producto> productos = new List<Producto>();
            con.Open();
            coman = new NpgsqlCommand("select * from orden;", con);
            resp = new NpgsqlDataAdapter(coman);
            DataTable tOrden = new DataTable();
            resp.Fill(tOrden);
            resp = null;
            Orden orden;
            Pizza pizza;
            Refresco refrescos;
            foreach (DataRow rowOrden in tOrden.Rows)
            {
                orden = new Orden((string)rowOrden["fecha"], Convert.ToInt32(rowOrden["num_ficha"]));
                orden.ID = Convert.ToInt64(rowOrden["id"]);
                coman = new NpgsqlCommand("select * from orden_pizzas where fk_orden=" + orden.ID + ";", con);
                resp = new NpgsqlDataAdapter(coman);
                DataTable tOrdenPizzas = new DataTable();
                resp.Fill(tOrdenPizzas);
                foreach (DataRow rowOrPi in tOrdenPizzas.Rows)
                {
                    coman = new NpgsqlCommand("select * from pizzas where id=" + rowOrPi["fk_pizza"] + ";", con);
                    resp = new NpgsqlDataAdapter(coman);
                    DataTable tp = new DataTable();
                    resp.Fill(tp);
                    pizza = new Pizza((string)tp.Rows[0]["nombre"], Convert.ToDouble(tp.Rows[0]["precio"]), (string)tp.Rows[0]["ingredientes"]);
                    pizza.Size = Convert.ToChar(tp.Rows[0]["size"]);
                    orden.agregarProducto(pizza, Convert.ToInt32(rowOrPi["cantidad"]));
                }
                coman = new NpgsqlCommand("select * from orden_refrescos where fk_orden=" + orden.ID + ";", con);
                resp = new NpgsqlDataAdapter(coman);
                DataTable tOrdenRefrescos = new DataTable();
                resp.Fill(tOrdenRefrescos);
                foreach (DataRow rowOrRe in tOrdenRefrescos.Rows)
                {
                    coman = new NpgsqlCommand("select * from refrescos where id=" + rowOrRe["fk_refrescos"] + ";", con);
                    resp = new NpgsqlDataAdapter(coman);
                    DataTable tr = new DataTable();
                    resp.Fill(tr);
                    refrescos = new Refresco((string)tr.Rows[0]["nombre"], Convert.ToDouble(tr.Rows[0]["precio"]), Convert.ToInt32(tr.Rows[0]["litros"]));
                    orden.agregarProducto(refrescos, Convert.ToInt32(rowOrRe["cantidad"]));
                }

                if (orden.Productos.Count > 0)
                    ordenes.Add(orden);
            }

            con.Close();
            return ordenes;
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
