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
using DOMINIO;

namespace PRESENTACION
{
    public partial class frmPedido : Form
    {
        List<Pedido> listaPedido;
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            cargarPlanilla();

            
        }
        private void cargarPlanilla()
        {
            PedidoNegocio negocio = new PedidoNegocio();
            listaPedido = negocio.Listar();
            dgvPedido.DataSource = listaPedido;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dgvPedido.Columns["Id"].Visible = false;
            dgvPedido.Columns["IdProducto"].Visible = false;
            dgvPedido.Columns["IdProveedor"].Visible = false;
        }
    }
}
