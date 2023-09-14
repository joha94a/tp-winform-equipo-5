using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                accesoDatos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, Precio, M.Id, M.Descripcion marca, C.Id, C.Descripcion categoria, IdMarca, IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca AND C.Id = A.IdCategoria;");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string) accesoDatos.Lector["codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["descripcion"];
                    aux.Precio = (decimal) accesoDatos.Lector["precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["categoria"];

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
