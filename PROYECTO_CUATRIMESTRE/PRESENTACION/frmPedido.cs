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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PedidoNegocio negocio = new PedidoNegocio();
            try
            {
                if (Validaciones())
                {
                    return;
                }
                Pedido pedido = new Pedido();
                pedido.FechaPedido = txtFecha.Text;
                pedido.IdProducto = Convert.ToInt32(cbxProducto.SelectedItem);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
        }

        //MÉTODOS
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
        private bool Validaciones()
        {
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Completar el campo FECHA!");
                txtFecha.Focus();
                return true;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Completar el campo CANTIDAD!");
                txtCantidad.Focus();
                return true;
            }
            if (SoloNumero(txtCantidad.Text))
            {
                MessageBox.Show("Ingresar solo números en en campo CANTIDAD!");
                txtCantidad.Focus();
                return true;
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (char.IsNumber(caracter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
