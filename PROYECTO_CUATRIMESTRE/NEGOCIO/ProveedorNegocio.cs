using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ProveedorNegocio
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> listaProvee = new List<Proveedor>();
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id_Proveedor, Nombre_prov, Direccion, Telefono, Correo, PaginaWeb FROM Proveedor;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Proveedor temporal = new Proveedor();
                    temporal.Id = (int)conectar.Lector["Id_Proveedor"];
                    temporal.NombreProv = (string)conectar.Lector["Nombre_prov"];
                    temporal.DireccionProv = (string)conectar.Lector["Direccion"];
                    temporal.TelProv = (string)conectar.Lector["Telefono"];
                    if (!(conectar.Lector["Correo"] is DBNull))
                    {
                        temporal.EmailProv = (string)conectar.Lector["Correo"];
                    }
                    if (!(conectar.Lector["PaginaWeb"] is DBNull))
                    {
                        temporal.PaginaWebProv = (string)conectar.Lector["PaginaWeb"];
                    }
                    listaProvee.Add(temporal);
                }
                return listaProvee;
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
        public void EliminarFijo(int id)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("DELETE FROM Proveedor WHERE Id_proveedor = @id;");
                conectar.setearParametro("@id", id);
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
        public void Agregar(Proveedor nuevo)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("INSERT INTO Proveedor (Id_Proveedor, Nombre_prov, Direccion, Telefono, Correo, PaginaWeb) VALUES (@Nombre, @Dire, @Tel, @Email, @PagWeb);");
                conectar.setearParametro("@Nombre", nuevo.NombreProv);
                conectar.setearParametro("@Dire", nuevo.DireccionProv);
                conectar.setearParametro("@Tel", nuevo.TelProv);
                conectar.setearParametro("@Email", nuevo.EmailProv);
                conectar.setearParametro("PagWeb", nuevo.PaginaWebProv);
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
        public void Modificar(Proveedor seleccionado)
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("UPDATE Proveedor SET Nombre_prov = @Nombre, Direccion = @Dire, Telefono = @Tel, Correo = @Email, PaginaWeb = @PagWeb WHERE Id_Proveedor = @Id;");
                conectar.setearParametro("@Nombre", seleccionado.NombreProv);
                conectar.setearParametro("@Dire", seleccionado.DireccionProv);
                conectar.setearParametro("@Tel", seleccionado.TelProv);
                conectar.setearParametro("@Email", seleccionado.EmailProv);
                conectar.setearParametro("PagWeb", seleccionado.PaginaWebProv);
                conectar.setearParametro("Id", seleccionado.Id);
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
