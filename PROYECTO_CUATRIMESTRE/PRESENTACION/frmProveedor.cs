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
                proveedor.NombreProv = txtNombre.Text;
                proveedor.DireccionProv = txtDesc.Text;
                proveedor.TelProv = txt
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
    }
}
