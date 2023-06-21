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
    public partial class frmInventario : Form
    {
        List<Inventario> listInv = new List<Inventario>();
        Inventario inventario;
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            try
            {
                ListarCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            InventarioNegocio negocio = new InventarioNegocio();
            Inventario seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro seleccionado ? ", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Inventario)dgvInventario.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    ListarRegistro();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
                if (inventario == null)
                {
                    inventario = new Inventario();
                }
                AsignarRegistro(inventario);
                AgregarOModificar(inventario);
                ListarRegistro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Inventario seleccionado = new Inventario();
            seleccionado = (Inventario)dgvInventario.CurrentRow.DataBoundItem;
            CargarDatos(seleccionado);
            inventario = seleccionado;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarRegistro();
        }

        //MÉTODOS
        public void ListarCombo()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            cbProductos.DataSource = negocio.Listar();
            cbProductos.ValueMember = "Id";
            cbProductos.DisplayMember = "Nombre";
        }
        private void Limpiar()
        {
            rbEntrada.Checked = false;
            rbSalida.Checked = false;
            txtCantidad.Clear();
            txtFecha.Clear();
            inventario = null;
            cbProductos.Focus();
        }
        //private void CargarPlanilla()
        //{
        //    InventarioNegocio negocio = new InventarioNegocio();
        //    listInv = negocio.Listar();
        //    dgvInventario.DataSource = listInv;
        //    OcultarColumnas();
        //}
        private void OcultarColumnas()
        {
            dgvInventario.Columns["Id"].Visible = false;
            dgvInventario.Columns["CantidadDisp"].Visible = false; 
        }
        private bool ValidarDatos()
        {
            if (!(rbEntrada.Checked || rbSalida.Checked))
            {
                MessageBox.Show("Especifique si es una entrada o saldida del producto!");
                return true;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Completar el campo CANTIDAD");
                txtCantidad.Focus();
                return true;
            }
            if (SoloNumero(txtCantidad.Text))
            {
                return true;
            }
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Completar el campo FECHA!");
                txtFecha.Focus();
                return true;
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            int entero;
            if (!int.TryParse(txtCantidad.Text, out entero))
            {
                MessageBox.Show("Ingresar solo números enteros en el campo CANTIDAD!");
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return true;
            }
            return false;
        }
        private void AsignarRegistro(Inventario nuevo)
        {
            if (rbEntrada.Checked)
            {
                nuevo.Producto = (Producto)cbProductos.SelectedItem;
                nuevo.Entrada = Convert.ToInt32(txtCantidad.Text);
                nuevo.Fecha = txtFecha.Text;
            }
            else
            {
                nuevo.Producto = (Producto)cbProductos.SelectedItem;
                nuevo.Salida = Convert.ToInt32(txtCantidad.Text);
                nuevo.Fecha = txtFecha.Text;
            }  
        }
        private void AgregarOModificar(Inventario inventario)
        {
            InventarioNegocio negocio = new InventarioNegocio();
            if (inventario.Id != 0)
            {
                negocio.Modificar(inventario);
                MessageBox.Show("Registro modificado!");
                Limpiar();
            }
            else
            {
                negocio.Agregar(inventario);
                MessageBox.Show("Registro agregado!");
                Limpiar();
            }
        }
        private void ListarRegistro()
        {
            Producto seleccionado = (Producto)cbProductos.SelectedItem;
            InventarioNegocio negocio = new InventarioNegocio();
            listInv = negocio.ListarPorProducto(seleccionado.Id);
            dgvInventario.DataSource = listInv;
            txtCantDisponible.Text = negocio.ListarDisponible(seleccionado.Id).ToString();
            OcultarColumnas();
        }
        private void CargarDatos(Inventario seleccionado)
        {
            if (seleccionado.Entrada != 0)
            {
                rbEntrada.Checked = true;
                txtCantidad.Text = seleccionado.Entrada.ToString();
            }
            else
            {
                rbSalida.Checked = true;
                txtCantidad.Text = seleccionado.Salida.ToString();
            }
            txtFecha.Text = seleccionado.Fecha;
        }
    }
}
