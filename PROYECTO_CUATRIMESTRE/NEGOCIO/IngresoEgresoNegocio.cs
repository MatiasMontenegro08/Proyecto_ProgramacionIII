
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class IngresoEgresoNegocio
    {
        public List<IngEgr> Listar()
        {
            List<IngEgr> lista = new List<IngEgr>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id, Detalle, Fecha, Ingreso, Egreso FROM LibroDiario;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    IngEgr temporal = new IngEgr();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Detalle = (string)conectar.Lector["Detalle"];
                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Ingreso = (decimal)conectar.Lector["Ingreso"];
                    temporal.Egreso = (decimal)conectar.Lector["Egreso"];

                    lista.Add(temporal);
                }
                return lista;
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
                conectar.setearConsulta("DELETE FROM LibroDiario WHERE Id = @id");
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
        public void Agregar(IngEgr nuevo)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("INSERT INTO LibroDiario (Detalle, Fecha, Ingreso, Egreso) VALUES (@Detalle, @Fecha, @Ing, @Egr);");
                conectar.setearParametro("@Detalle", nuevo.Detalle);
                conectar.setearParametro("@Fecha", nuevo.Fecha);
                conectar.setearParametro("@Ing", nuevo.Ingreso);
                conectar.setearParametro("@Egr", nuevo.Egreso);
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
        public void Modificar(IngEgr selecionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE LibroDiario SET Detalle = @Detalle, Fecha = @Fecha, Ingreso = @Ing, Egreso = @Egr WHERE Id = @Id;");
                conectar.setearParametro("@Detalle", selecionado.Detalle);
                conectar.setearParametro("@Fecha", selecionado.Fecha);
                conectar.setearParametro("@Ing", selecionado.Ingreso);
                conectar.setearParametro("@Egr", selecionado.Egreso);
                conectar.setearParametro("@Id", selecionado.Id);
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
                
                conectar.setearConsulta("SELECT COALESCE(SUM(Ingreso - Egreso), 0) AS Total FROM LibroDiario;");
                /*
                 * En la consulta para asegurarnos de que el resultado de no sea nulo. 
                 * Si la suma es nula (es decir, no hay registros en la tabla), COALESCE devolverá el valor 
                 * predeterminado de cero.
                 */
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    IngEgr temporal = new IngEgr();
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
        public List<IngEgr> FiltroDesdeHasta(string fecha1, string fecha2)
        {
            AccesoDato conectar = new AccesoDato();
            List<IngEgr> filtro = new List<IngEgr>();
            try
            {
                string f1 = fecha1, f2 = fecha2;
                conectar.setearConsulta("SELECT Id, Detalle, Fecha, Ingreso, Egreso FROM LibroDiario WHERE CONVERT(date, Fecha, 103) BETWEEN @Fecha1 AND @Fecha2;");
                conectar.setearParametro("@Fecha1", f1);
                conectar.setearParametro("@Fecha2", f2);
                conectar.ejecutarLectura();
                while (conectar.Lector.Read())
                {
                    IngEgr temporal = new IngEgr();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Detalle = (string)conectar.Lector["Detalle"];
                    temporal.Fecha = (string)conectar.Lector["Fecha"];
                    temporal.Ingreso = (decimal)conectar.Lector["Ingreso"];
                    temporal.Egreso = (decimal)conectar.Lector["Egreso"];

                    filtro.Add(temporal);
                }
                return filtro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
