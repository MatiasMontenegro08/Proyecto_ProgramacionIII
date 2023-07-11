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
using NEGOCIO;

namespace PRESENTACION
{
    public partial class frmIngresoEgreso : Form
    {
        IngEgr registro;
        List<IngEgr> lista;
        public frmIngresoEgreso()
        {
            InitializeComponent();
        }

        private void frmIngresoEgreso_Load(object sender, EventArgs e)
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.CurrentRow != null)
            {
                EliminarRegistro();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (registro == null)
                {
                    registro = new IngEgr();
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
            if (dgvLibro.CurrentRow != null)
            {
                IngEgr registroselec = new IngEgr();
                registroselec = (IngEgr)dgvLibro.CurrentRow.DataBoundItem;
                CargarDatos(registroselec);
                registro = registroselec;
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<IngEgr> listaFiltrada = new List<IngEgr>();
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
            lista = negocio.Listar();
            string filtroRapido = txtFiltroRapido.Text;
            if (filtroRapido != null)
            {
                listaFiltrada = lista.FindAll(x => x.Detalle.ToLower().Contains(filtroRapido.ToLower()) || x.Fecha.ToLower().Contains(filtroRapido.ToLower()));
            }
            else
            {
                listaFiltrada = lista;
            }
            dgvLibro.DataSource = null;
            dgvLibro.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroDesdeHasta();
        }

        //MÉTODOS
        private void CargarPlanilla()
        {
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
            dgvLibro.DataSource = negocio.Listar();
            ocultarColumnas();
            lblValiDetalle.Text = "";
            lblValiFecha.Text = "";
            lblValiValor.Text = "";
            Total();
        }
        private void Total()
        {
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
            decimal total = negocio.ObtenerTotal();
            lblResultado.Text = "$ " + total.ToString();
        }
        private void Limpiar()
        {
            txtDetalle.Clear();
            txtFecha.Clear();
            rbEgreso.Checked = false;
            rbIngreso.Checked = false;
            txtValor.Clear();
            txtDesde.Clear();
            txtHasta.Clear();
            txtFiltroRapido.Clear();
            lblValiDetalle.Text = "";
            lblValiFecha.Text = "";
            lblValiValor.Text = "";
            txtDetalle.Focus();
            registro = null;
            CargarPlanilla();
        }
        private void EliminarRegistro()
        {
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
            IngEgr seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro seleccionado ? ", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (IngEgr)dgvLibro.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            if (txtFecha.Text == "")
            {
                lblValiFecha.Text = "Campo obligatorio*";
                txtFecha.Focus();
                return true;
            }
            if (!(rbIngreso.Checked || rbEgreso.Checked))
            {
                MessageBox.Show("Especifique si es una Ingreso o Egreso de dinero!");
                return true;
            }
            if (txtValor.Text == "")
            {
                lblValiValor.Text = "Campo obligatorio*";
                txtValor.Focus();
                return true;
            }
            if (SoloNumero(txtValor.Text))
            {
                return true;
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            decimal valor;
            if (!decimal.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingresar solo números!");
                txtValor.Focus();
                txtValor.SelectAll();
                return true;
            }
            return false;
        }
        private void AsignarRegistro(IngEgr registro)
        {
            registro.Detalle = txtDetalle.Text;
            registro.Fecha = txtFecha.Text;
            if (rbIngreso.Checked)
            {
                registro.Ingreso = Convert.ToDecimal(txtValor.Text);
                registro.Egreso = 0;
            }
            else
            {
                registro.Egreso = Convert.ToDecimal(txtValor.Text);
                registro.Ingreso = 0;
            }
        }
        private void AgregarOmodificar(IngEgr registro)
        {
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
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
        private void CargarDatos(IngEgr registroselec)
        {
            txtDetalle.Text = registroselec.Detalle;
            txtFecha.Text = registroselec.Fecha;
            if (registroselec.Ingreso != 0)
            {
                rbIngreso.Checked = true;
                txtValor.Text = registroselec.Ingreso.ToString();
            }
            else
            {
                rbEgreso.Checked = true;
                txtValor.Text = registroselec.Egreso.ToString();
            }
        }
        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                lblValiDetalle.Text = "";
            }
        }
        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (txtFecha.Text != "")
            {
                lblValiFecha.Text = "";
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                lblValiValor.Text = "";
            }
        }
        private void ocultarColumnas()
        {
            dgvLibro.Columns["Id"].Visible = false;
            dgvLibro.Columns["Total"].Visible = false;
        }
        private void FiltroDesdeHasta()
        {
            IngresoEgresoNegocio negocio = new IngresoEgresoNegocio();
            try
            {
                if (txtDesde.Text != "" && txtHasta.Text != "")
                {
                    dgvLibro.DataSource = null;
                    dgvLibro.DataSource = negocio.FiltroDesdeHasta(txtDesde.Text, txtHasta.Text);
                    ocultarColumnas();
                }
                else
                {
                    MessageBox.Show("Completar los campos Desde / Hasta");
                    txtDesde.Focus();
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
