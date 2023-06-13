using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
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
                conectar.setearConsulta("select I.Id_Inventario, Prod.Nombre, I.Id_Producto, I.Cant_disponible, I.Fecha_Actualizado from Inventario I, Producto Prod WHERE I.Id_Producto = Prod.Id_producto;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Inventario temporal = new Inventario();
                    temporal.Id = (int)conectar.Lector["I.Id_Inventario"];
                    temporal.Fecha = (string)conectar.Lector["I.Fecha_Actualizado"];
                    temporal.ProductoId = (int)conectar.Lector["I.Id_Producto"];
                    temporal.CantidadDisp = (int)conectar.Lector["I.Cant_disponible"];
                    temporal.NombreProd = (string)conectar.Lector["Prod.Nombre"];
                    
                    listaInv.Add(temporal);
                }
                return listaInv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarFijo(int pedido)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("DELETE FROM Inventario WHERE Id_Inventario = @id");
                conectar.setearParametro("@id", pedido);
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
                conectar.setearConsulta("INSERT INTO Inventario (Id_Producto, Cant_disponible, Fecha_Actualizado) VALUES (@IdProd, @Cant, @Fecha);");
                conectar.setearParametro("@IdProd", nuevo.ProductoId);
                conectar.setearParametro("@Cant", nuevo.CantidadDisp);
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
                conectar.setearConsulta("UPDATE Inventario SET Id_Producto = @IdProd, Cant_disponible = @Cant, Fecha_Actualizado = @Fecha, WHERE Id_Inventario = @Id;");
                conectar.setearParametro("@IdProd", seleccionado.ProductoId);
                conectar.setearParametro("@Cant", seleccionado.CantidadDisp);
                conectar.setearParametro("@Fecha", seleccionado.Fecha);
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
    }
}
