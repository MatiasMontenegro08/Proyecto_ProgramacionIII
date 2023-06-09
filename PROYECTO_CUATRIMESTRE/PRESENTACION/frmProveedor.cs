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
    public partial class frmProveedor : Form
    {
        List<Proveedor> listaProve;
        Proveedor proveedor;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            CargarPlanilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            Proveedor seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el proveedor seleccionado?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }

                //Puedo hacer un metodo que tenga como argumento la variable proveedor
                proveedor.NombreProv = txtNombre.Text;
                proveedor.DireccionProv = txtDirec.Text;
                proveedor.TelProv = txtTel.Text;
                proveedor.EmailProv = txtCorreo.Text;
                proveedor.PaginaWebProv = txtPagWeb.Text;

                if (proveedor.Id != 0)
                {
                    negocio.Modificar(proveedor);
                    MessageBox.Show("Proveedor modificado!");
                    Limpiar();
                }
                else
                {
                    negocio.Agregar(proveedor);
                    MessageBox.Show("Proveedor agregado!");
                    Limpiar();
                }
                CargarPlanilla();
                proveedor = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado = new Proveedor();
            seleccionado = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
            CargarDatos(seleccionado);
            proveedor = seleccionado;
        }

        //MÉTODOS
        private void CargarPlanilla()
        {
            ProveedorNegocio lista = new ProveedorNegocio();
            listaProve = lista.Listar();
            dgvProveedor.DataSource = listaProve;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dgvProveedor.Columns["Id"].Visible = false;
        }
        private bool ValidarDatos()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Completar el campo NOMBRE!");
                txtNombre.Focus();
                return true;
            }
            if (txtDirec.Text == "")
            {
                MessageBox.Show("Completar el campo DIRECCIÓN!");
                txtDirec.Focus();
                return true;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show("Completar el campo TELÉFONO!");
                txtTel.Focus();
                return true;
            }
            //Validar si txtCosto solo ingreso números.
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Completar el campo CORREO!");
                txtCorreo.Focus();
                return true;
            }
            if (txtPagWeb.Text == "")
            {
                MessageBox.Show("Completar el campo Página Web!");
                txtPagWeb.Focus();
                return true;
            }
            return false;
        }
        private void CargarDatos(Proveedor seleccionado)
        {
            txtNombre.Text = seleccionado.NombreProv;
            txtDirec.Text = seleccionado.DireccionProv;
            txtTel.Text = seleccionado.TelProv;
            txtCorreo.Text = seleccionado.EmailProv;
            txtPagWeb.Text = seleccionado.PaginaWebProv;
            txtNombre.Focus();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDirec.Clear();
            txtTel.Clear();
            txtCorreo.Clear();
            txtPagWeb.Clear();
            txtNombre.Focus();
        }
    }
}
