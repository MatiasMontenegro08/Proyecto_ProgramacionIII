﻿using System;
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
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Nombre = (string)conectar.Lector["Nombre"];
                    temporal.Descripcion = (string)conectar.Lector["Description"];
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
            try
            {
                AccesoDato datos = new AccesoDato();
                datos.setearConsulta("DELETE FROM Producto WHERE Id_producto = @id");
                datos.setearParametro("@id", producto);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Agregar(Producto nuevo)
        {
            AccesoDato datos = new AccesoDato();
            try
            {
                datos.setearConsulta("INSERT INTO Producto ()");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
