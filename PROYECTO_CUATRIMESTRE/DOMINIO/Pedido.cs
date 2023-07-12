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
        public string Detalle { get; set; }
        [DisplayName("Fecha")]
        public string FechaEntrega { get; set; }
        [DisplayName("Primera Entrega")]
        public decimal PrimEntrega { get; set; }
        [DisplayName("Forma de Pago")]
        public string FormaPago { get; set; }
        [DisplayName("Fecha")]
        public string FechaRetiro { get; set; }
        [DisplayName("Segunda Entrega")]
        public decimal SegEntrega { get; set; }
        [DisplayName("Forma de Pago")]
        public string FormaPago2 { get; set; }
        public decimal Total { get; set; }
    }
}
