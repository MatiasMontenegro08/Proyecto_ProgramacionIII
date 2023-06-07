using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Pedido
    {
        public int Id { get; set; }
        [DisplayName("Producto")]
        public int IdProducto { get; set; }
        [DisplayName("Fecha")]
        public string FechaPedido { get; set; }
        public string Producto { get; set; }
        [DisplayName("Cantidad")]
        public int CantidadProducto { get; set; }
        public decimal Costo { get; set; }

        [DisplayName("Proveedor")]
        public int IdProveedor { get; set; }
        
        public string Proveedor { get; set; }

    }
}
