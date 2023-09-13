using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select codigo, nombre, precio from ARTICULOS");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string) accesoDatos.Lector["codigo"];
                    aux.Nombre = (string) accesoDatos.Lector["nombre"];
                    aux.Precio = (decimal) accesoDatos.Lector["precio"];

                    articulos.Add(aux);
                }

                return articulos;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion();
            }

            
        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try 
            {
                accesoDatos.setearConsulta("insert into ARTICULOS values ('" + articulo.Codigo + "'," +
                    "'" + articulo.Nombre + "'," +
                    "'" + articulo.Descripcion + "', @IdMarca, @IdCategoria," +
                     articulo.Precio + ")");
                accesoDatos.setearParametro("@IdMarca", articulo.Marca.Id);
                accesoDatos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
