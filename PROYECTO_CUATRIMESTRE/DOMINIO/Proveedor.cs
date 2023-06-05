using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Proveedor
    {
        public int Id { get; set; }
        [DisplayName("Proveedor")]
        public string NombreProv { get; set; }
        [DisplayName("Dirección")]
        public string DireccionProv { get; set; }
        [DisplayName("Teléfono")]
        public string TelProv { get; set; }
        [DisplayName("Email")]
        public string EmailProv { get; set; }
        [DisplayName("Página Web")]
        public string PaginaWebProv { get; set; }
    }
}
