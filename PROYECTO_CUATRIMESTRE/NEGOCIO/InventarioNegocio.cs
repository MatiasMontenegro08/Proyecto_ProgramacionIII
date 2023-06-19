using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class InventarioNegocio
    {
        public List<Inventario> Listar()
        {
            List<Inventario> listaInv = new List<Inventario>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT I.Id, I.Id_Producto, I.Fecha, I.Entrada, I.Salida, I.Disponible, P.Nombre FROM InventarioProducto I, Producto P WHERE I.Id_Producto = P.Id_producto;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Inventario temporal = new Inventario();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Entrada = (int)conectar.Lector["Entrada"];
                    temporal.Salida = (int)conectar.Lector["Salida"];
                    temporal.CantidadDisp = (int)conectar.Lector["Disponible"];

                    temporal.Producto = new Producto();
                    temporal.Producto.Nombre = (string)conectar.Lector["Nombre"];

                    listaInv.Add(temporal);
                }
                return listaInv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarFijo(int registro)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("DELETE FROM InventarioProducto WHERE Id = @id");
                conectar.setearParametro("@id", registro);
                conectar.ejecutarAccion();
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
        public void Agregar(Inventario nuevo)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("INSERT INTO InventarioProducto (Id_Producto, Fecha, Entrada, Salida) VALUES (@IdProd, @Fecha, @Entrada, @Salida);");
                conectar.setearParametro("@IdProd", nuevo.Producto.Id);
                conectar.setearParametro("@Entrada", nuevo.Entrada);
                conectar.setearParametro("@Salida", nuevo.Salida);
                conectar.setearParametro("@Fecha", nuevo.Fecha);
                conectar.ejecutarAccion();
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
        public void Modificar(Inventario seleccionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE InventarioProducto SET Id_Producto = @IdProd, Fecha = @Fecha, Entrada = @Entrada, Salida = @Salida WHERE Id = @Id;");
                conectar.setearParametro("IdProd", seleccionado.Producto.Id);
                conectar.setearParametro("@Fecha", seleccionado.Fecha);
                conectar.setearParametro("@Entrada", seleccionado.Entrada);
                conectar.setearParametro("@Salida", seleccionado.Salida);
                conectar.setearParametro("@Id", seleccionado.Id);
                conectar.ejecutarAccion();
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
        public List<Inventario> ListarPorProducto(int seleccionado)
        {
            List<Inventario> lista = new List<Inventario>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT DISTINCT I.Id, I.Id_Producto, P.Nombre, I.Fecha, I.Entrada, I.Salida FROM  InventarioProducto I JOIN Producto P ON I.Id_producto = P.Id_producto WHERE I.Id_producto = @Id;");
                conectar.setearParametro("@Id", seleccionado);
                conectar.ejecutarLectura();
                while (conectar.Lector.Read())
                {
                    Inventario temporal = new Inventario();
                    temporal.Id = (int)conectar.Lector["Id"];

                    temporal.Producto = new Producto();
                    temporal.Producto.Nombre = (string)(conectar.Lector["Nombre"]);
                    temporal.Producto.Id = (int)(conectar.Lector["Id_Producto"]);

                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Entrada = (int)conectar.Lector["Entrada"];
                    temporal.Salida = (int)conectar.Lector["Salida"];

                    lista.Add(temporal);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ListarDisponible(int seleccionado)
        {
            int cantidad = 0;
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT SUM(entrada - salida) AS Disponible FROM InventarioProducto WHERE Id_Producto = @id GROUP BY Id_Producto;");
                conectar.setearParametro("@id", seleccionado);
                conectar.ejecutarLectura();
                while (conectar.Lector.Read())
                {
                    Inventario temporal = new Inventario();
                    temporal.CantidadDisp = (int)conectar.Lector["Disponible"];
                    cantidad += temporal.CantidadDisp;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
