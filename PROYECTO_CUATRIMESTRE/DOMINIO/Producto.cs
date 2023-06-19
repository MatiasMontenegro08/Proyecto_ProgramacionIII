using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Producto
    {
        public int Id { get; set; }
        [DisplayName("Producto")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set;}
        [DisplayName("Costo")]
        public decimal PrecioUnitario { get; set; }
        [DisplayName("Imágen")]
        public string ImgUrl { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
