﻿using System;
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
                conectar.setearConsulta("SELECT P.Id_pedido, P.Id_producto, P.Costo, P.Cantidad_pedido, P.Fecha, P.Id_proveedor, prod.Nombre 'Producto', Prove.Nombre_prov 'Proveedor' FROM Pedido P, Producto prod, Proveedor Prove WHERE p.Id_producto = prod.Id_producto and p.Id_proveedor = Prove.Id_Proveedor;");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    Pedido temporal = new Pedido();
                    temporal.Id = (int)conectar.Lector["Id_pedido"];
                    temporal.IdProducto = (int)conectar.Lector["Id_producto"];
                    temporal.CantidadProducto = (int)conectar.Lector["Cantidad_pedido"];
                    if (!(conectar.Lector["Fecha"] is DBNull))
                    {
                        temporal.FechaPedido = (string)conectar.Lector["Fecha"];
                    }
                    temporal.IdProveedor = (int)conectar.Lector["Id_proveedor"];
                    temporal.Producto = (string)conectar.Lector["Producto"];
                    temporal.Proveedor = (string)conectar.Lector["Proveedor"];

                    if (!(conectar.Lector["Costo"] is DBNull))
                    {
                        temporal.Costo = (decimal)conectar.Lector["Costo"];
                    }
                    
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
                datos.setearConsulta("INSERT INTO Pedido (Id_producto, Cantidad_pedido, Fecha, Id_proveedor, Costo) values (@IdProducto, @Canti, @Fecha, @Idprove, @Costo);");
                datos.setearParametro("@IdProducto", nuevo.IdProducto);
                datos.setearParametro("@Canti", nuevo.CantidadProducto);
                datos.setearParametro("@Fecha", nuevo.FechaPedido);
                datos.setearParametro("@Idprove", nuevo.IdProveedor);
                datos.setearParametro("@Costo", nuevo.Costo);

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
