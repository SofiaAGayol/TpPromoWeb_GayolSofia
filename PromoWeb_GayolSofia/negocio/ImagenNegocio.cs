using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Imagen imagen = new Imagen();

                    imagen.Id = (int)accesoDatos.Lector["Id"];
                    imagen.IdArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    imagen.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    lista.Add(imagen);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener el listado");
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public List<Imagen> listar(int IdArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo=" + IdArticulo);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Imagen imagen = new Imagen();

                    imagen.Id = (int)accesoDatos.Lector["Id"];
                    imagen.IdArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    imagen.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    lista.Add(imagen);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener el listado");
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES ( IdArticulo, ImagenUrl) " + "VALUES (@IdArticulo, @ImagenUrl)" + "SELECT SCOPE_IDENTITY();");

                datos.setearParametro("@IdArticulo", nuevo.IdArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("DELETE FROM IMAGENES WHERE Id = " + id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw new Exception("Error al eliminar");
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        
        }
    }
}

