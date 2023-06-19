using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Inventario
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public string Fecha { get; set; }
        public int Entrada { get; set; }
        public int Salida { get; set; }
        [DisplayName("Disponible")]
        public int CantidadDisp { get; set; }
    }
}
