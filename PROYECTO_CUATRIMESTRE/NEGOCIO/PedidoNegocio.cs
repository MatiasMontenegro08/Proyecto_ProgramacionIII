using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class PedidoNegocio
    {
        public List<Pedido> Listar()
        {
            List<Pedido> listaPedido = new List<Pedido>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id, Detalle, Fecha_Entrega, Primera_Entrega, Fecha_Retiro, Segunda_Entrega, Total, Forma_Pago, Forma_Pago2 FROM PlanillaEntregas;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Pedido temporal = new Pedido();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Detalle = (string)conectar.Lector["Detalle"];
                    temporal.FechaEntrega = (string)conectar.Lector["Fecha_Entrega"];
                    temporal.PrimEntrega = (decimal)conectar.Lector["Primera_Entrega"];
                    temporal.FechaRetiro = (string)conectar.Lector["Fecha_Retiro"];
                    temporal.SegEntrega = (decimal)conectar.Lector["Segunda_Entrega"];
                    if (!(conectar.Lector["Forma_Pago"] is DBNull))
                    {
                        temporal.FormaPago = (string)conectar.Lector["Forma_Pago"];
                    }
                    if (!(conectar.Lector["Forma_Pago2"] is DBNull))
                    {
                        temporal.FormaPago2 = (string)conectar.Lector["Forma_Pago2"];
                    }
                    temporal.Total = (decimal)conectar.Lector["Total"];

                    listaPedido.Add(temporal);
                }
                return listaPedido;
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
        public void Agregar(Pedido nuevo)
        {
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("INSERT INTO PlanillaEntregas (Detalle, Fecha_Entrega, Primera_Entrega, Fecha_Retiro, Segunda_Entrega, Forma_Pago, Total) VALUES (@Detalle, @Fecha1, @Entrega1, @Fecha2, @Entrega2, @FormPago, @Entrega1 + @Entrega2);");
                datos.setearParametro("@Detalle", nuevo.Detalle);
                datos.setearParametro("@Fecha1", nuevo.FechaEntrega);
                datos.setearParametro("@Entrega1", nuevo.PrimEntrega);
                datos.setearParametro("@Fecha2", nuevo.FechaRetiro);
                datos.setearParametro("@Entrega2", nuevo.SegEntrega);
                datos.setearParametro("@FormPago", nuevo.FormaPago);
                //El total se sumaría con los valores de entrega 1 y entrega 2

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
        public void Modificar (Pedido seleccionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE PlanillaEntregas SET Detalle = @Detalle, Fecha_Entrega = @Fecha1, Primera_Entrega = @Entrega1, Fecha_Retiro = @Fecha2, Segunda_Entrega = @Entrega2, Forma_Pago = @FormPago WHERE Id = @Id;");
                conectar.setearParametro("@Detalle", seleccionado.Detalle);
                conectar.setearParametro("@Fecha1", seleccionado.FechaEntrega);
                conectar.setearParametro("@Entrega1", seleccionado.PrimEntrega);
                conectar.setearParametro("@Fecha2", seleccionado.FechaRetiro);
                conectar.setearParametro("@Entrega2", seleccionado.SegEntrega);
                conectar.setearParametro("@FormPago", seleccionado.FormaPago);
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
        public void ActualizarTotal(Pedido seleccionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE PlanillaEntregas SET  Total = (Primera_Entrega + Segunda_Entrega) WHERE Id = @Id;");
                conectar.setearParametro("@Id", seleccionado.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarFijo(int seleccionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("DELETE FROM PlanillaEntregas WHERE Id = @Id;");
                conectar.setearParametro("@Id", seleccionado);
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
        public decimal ObtenerTotal()
        {
            AccesoDato conectar = new AccesoDato();
            decimal total = 0;
            try
            {

                conectar.setearConsulta("SELECT COALESCE(SUM(Total), 0) AS Total FROM PlanillaEntregas;");
                /*
                 * En la consulta para asegurarnos de que el resultado de no sea nulo. 
                 * Si la suma es nula (es decir, no hay registros en la tabla), COALESCE devolverá el valor 
                 * predeterminado de cero.
                 */
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Pedido temporal = new Pedido();
                    temporal.Total = (decimal)conectar.Lector["Total"];
                    total += temporal.Total;
                }
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
