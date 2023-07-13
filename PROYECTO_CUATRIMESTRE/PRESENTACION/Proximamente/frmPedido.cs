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
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (registro == null)
                {
                    registro = new Pedido();
                }
                AsignarRegistro(registro);
                AgregarOmodificar(registro);
                CargarPlanilla();
                registro = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            if (registroselec.FormaPago == "Transferencia")
            {
                rbTrans1.Checked = true;
            }
            else
            {
                rbEfectivo1.Checked = true;
            }
            if (registroselec.FormaPago2 == "Transferencia")
            {
                rbTrans2.Checked = true;
            }
            else if (registroselec.FormaPago2 == "Efectivo")
            {
                rbEfectivo2.Checked = true;
            }
        }
        private bool ValidarDatos()
        {
            if (txtDetalle.Text == "")
            {
                lblValiDetalle.Text = "Campo obligatorio*";
                txtDetalle.Focus();
                return true;
            }
            if (txtFecha1.Text == "")
            {
                lblValiPrimera.Text = "Campo obligatorio*";
                txtFecha1.Focus();
                return true;
            }
            if (txtMonto1.Text == "")
            {
                lblValiPrimera.Text = "Campo obligatorio*";
                txtMonto1.Focus();
                return true;
            }
            if (SoloNumero(txtMonto1.Text))
            {
                return true;
            }
            if (!(rbTrans1.Checked || rbEfectivo1.Checked || rbTrans2.Checked || rbEfectivo2.Checked))
            {
                MessageBox.Show("Especifique si la entrega es por Transferencia o Efectivo!");
                return true;
            }
            if (rbTrans2.Checked || rbEfectivo2.Checked)
            {

                if (txtFecha2.Text == "")
                {
                    lblValiSegunda.Text = "Campo obligatorio*";
                    txtFecha2.Focus();
                    return true;
                }
                if (txtMonto2.Text == "")
                {
                    lblValiSegunda.Text = "Campo obligatorio*";
                    txtMonto2.Focus();
                    return true;
                }
                if (SoloNumero(txtMonto2.Text))
                {
                    return true;
                }
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            decimal valor;
            if (!decimal.TryParse(cadena, out valor))
            {
                MessageBox.Show("Ingresar solo números!");
                return true;
            }
            return false;
        }
        private void AsignarRegistro(Pedido registro)
        {
            registro.Detalle = txtDetalle.Text;
            registro.FechaEntrega = txtFecha1.Text;
            registro.PrimEntrega = Convert.ToDecimal(txtMonto1.Text);
            registro.FechaRetiro = txtFecha2.Text;
            if (txtMonto2.Text != "")
            {
                registro.SegEntrega = Convert.ToDecimal(txtMonto2.Text);
            }
            else
            {
                registro.SegEntrega = 0;
            }
            if (rbTrans1.Checked)
            {
                registro.FormaPago = "Transferencia";
            }
            if (rbEfectivo1.Checked)
            {
                registro.FormaPago = "Efectivo";
            }
            if (rbTrans2.Checked)
            {
                registro.FormaPago2 = "Transferencia";
            }
            else
            {
                registro.FormaPago2 = "";
            }
            if (rbEfectivo2.Checked)
            {
                registro.FormaPago2 = "Efectivo";
            }
        }
        private void AgregarOmodificar(Pedido registro)
        {
            PedidoNegocio negocio = new PedidoNegocio();
            if (registro.Id != 0)
            {
                negocio.Modificar(registro);
                MessageBox.Show("Registro modificado!");
                Limpiar();
            }
            else
            {
                negocio.Agregar(registro);
                MessageBox.Show("Registro agregado!");
                Limpiar();
            }
        }
        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                lblValiDetalle.Text = "";
            }
        }
        private void txtFecha1_TextChanged(object sender, EventArgs e)
        {
            if (txtFecha1.Text != "")
            {
                lblValiPrimera.Text = "";
            }
        }
        private void txtMonto1_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto1.Text != "")
            {
                lblValiPrimera.Text = "";
            }
        }
        private void txtMonto2_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto2.Text != "")
            {
                lblValiSegunda.Text = "";
            }
        }
        private void txtFecha2_TextChanged(object sender, EventArgs e)
        {
            if (txtFecha1.Text != "")
            {
                lblValiSegunda.Text = "";
            }
        }
    }
}
