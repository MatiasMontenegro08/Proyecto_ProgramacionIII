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
        Pedido registro;
        public frmPedido()
        {
            InitializeComponent();
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPlanilla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanilla.CurrentRow != null)
            {
                Pedido registroselec = new Pedido();
                registroselec = (Pedido)dgvPlanilla.CurrentRow.DataBoundItem;
                CargarDatos(registroselec);
                registro = registroselec;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanilla.CurrentRow != null)
            {
                EliminarRegistro();
            }
        }

        //MÉTODOS
        private void CargarPlanilla()
        {
            PedidoNegocio negocio = new PedidoNegocio();
            dgvPlanilla.DataSource = negocio.Listar();
            ocultarColumnas();
            lblValiDetalle.Text = "";
            lblValiPrimera.Text = "";
            lblValiSegunda.Text = "";
            Total();
        }
        private void ocultarColumnas()
        {
            dgvPlanilla.Columns["Id"].Visible = false;
            dgvPlanilla.Columns["Total"].Visible = false;
        }
        private void Total()
        {
            PedidoNegocio negocio = new PedidoNegocio();
            decimal total = negocio.ObtenerTotal();
            lblResultado.Text = "$ " + total.ToString();
        }
        private void Limpiar()
        {
            txtDetalle.Clear();
            cbPriEntrega.Checked = false;
            cbSegEntrega.Checked = false;
            txtFecha1.Clear();
            txtFecha2.Clear();
            txtMonto1.Clear();
            txtMonto2.Clear();
            rbTrans1.Checked = false;
            rbTrans2.Checked = false;
            rbEfectivo1.Checked = false;
            rbEfectivo2.Checked = false;
            lblValiDetalle.Text = "";
            lblValiPrimera.Text = "";
            registro = null;
            txtDetalle.Focus();
        }
        private void EliminarRegistro()
        {
            PedidoNegocio negocio = new PedidoNegocio();
            Pedido seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro seleccionado ? ", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pedido)dgvPlanilla.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarDatos(Pedido registroselec)
        {
            txtDetalle.Text = registroselec.Detalle;
            txtFecha1.Text = registroselec.FechaEntrega;
            txtMonto1.Text = registroselec.PrimEntrega.ToString();
            txtFecha2.Text = registroselec.FechaRetiro.ToString();
            txtMonto2.Text = registroselec.SegEntrega.ToString();
            if (registro.FormaPago == "TRANSFERENCIA")
            {
                rbTrans1.Checked = true;
            }
            else
            {
                rbEfectivo1.Checked = true;
            }
            if (registro.FormaPago2 == "TRANSFERENCIA")
            {
                rbTrans2.Checked = true;
            }
            else
            {
                rbEfectivo2.Checked = true;
            }
        }
    }
}
