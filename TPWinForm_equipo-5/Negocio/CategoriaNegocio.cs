using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    categorias.Add(aux);
                }

                return categorias;
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

        public bool Save(Categoria obj)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            bool resultado = false;
            try
            {
                string consulta;
                if(obj.Id == 0)
                {
                    consulta = "INSERT INTO CATEGORIAS (Descripcion) VALUES ('" + obj.Descripcion + "')";
                }
                else
                {
                    consulta = "UPDATE CATEGORIAS SET Descripcion = '"+obj.Descripcion+"' WHERE Id = "+ obj.Id;
                }
                accesoDatos.setearConsulta(consulta);
                accesoDatos.ejecutarLectura();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
            return resultado;
        }
    }
}
