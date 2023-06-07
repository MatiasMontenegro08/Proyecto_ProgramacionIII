using DOMINIO;
using NEGOCIO;
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
    public partial class frmProducto : Form
    {
        List<Producto> listaProducto;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarPlanilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductoNuevo nuevo = new frmProductoNuevo();
            nuevo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        //MÉTODOS
        private void cargarPlanilla()
        {
            ProductoNegocio lista = new ProductoNegocio();
            listaProducto = lista.Listar();
            dgvProductos.DataSource = listaProducto;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["ImgUrl"].Visible = false;
        }
    }
}
