using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            List<Producto> listaprod = new List<Producto>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id_producto, Nombre, Descripcion, PrecioUnit, Imagen FROM Producto;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Producto temporal = new Producto();
                    temporal.Id = (int)conectar.Lector["Id_producto"];
                    temporal.Nombre = (string)conectar.Lector["Nombre"];
                    temporal.Descripcion = (string)conectar.Lector["Descripcion"];
                    temporal.PrecioUnitario = (decimal)conectar.Lector["PrecioUnit"];
                    temporal.ImgUrl = (string)conectar.Lector["Imagen"];

                    listaprod.Add(temporal);
                }
                return listaprod;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conectar.cerrarConexion();
            }
        }
        public void EliminarFijo(int producto)
        {
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("DELETE FROM Producto WHERE Id_producto = @id");
                datos.setearParametro("@id", producto);
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
        public void Agregar(Producto nuevo)
        {
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("INSERT INTO Producto (Nombre, Descripcion, PrecioUnit, Imagen) VALUES (@Nombre, @Desc, @Precio, @Img);");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Desc", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.PrecioUnitario);
                datos.setearParametro("@Img", nuevo.ImgUrl);

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
        public void Modificar(Producto seleccionado)
        {
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("UPDATE Producto SET Nombre = @Nombre, Descripcion = @Desc, PrecioUnit = @Precio, Imagen = @Img WHERE Id_producto = @Id;");
                datos.setearParametro("@Nombre", seleccionado.Nombre);
                datos.setearParametro("@Desc", seleccionado.Descripcion);
                datos.setearParametro("@Precio", seleccionado.PrecioUnitario);
                datos.setearParametro("@Img", seleccionado.ImgUrl);
                datos.setearParametro("@Id", seleccionado.Id);
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
    }
}
