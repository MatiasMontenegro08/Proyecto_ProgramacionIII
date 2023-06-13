using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Inventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string NombreProd { get; set; }
        public int CantidadDisp { get; set; }
        public string Fecha { get; set; }
        

    }
}
