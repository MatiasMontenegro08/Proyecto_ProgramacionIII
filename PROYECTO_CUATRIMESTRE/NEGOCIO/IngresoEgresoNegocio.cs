using System;
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
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("SELECT Id, Detalle, Fecha, Ingreso, Egreso FROM LibroDiario;");
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
