using DOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class frmProductoNuevo : Form
    {
        private Producto producto = null;
        private OpenFileDialog archivo = null;

        public frmProductoNuevo()
        {
            InitializeComponent();
        }
        public frmProductoNuevo(Producto seleccionado)
        {
            InitializeComponent();
            producto = seleccionado;
            lblTitulo.Text = "Editar producto";
        }
    }
}
