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
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                InventarioNegocio negocio1 = new InventarioNegocio();
                dgvInventario.DataSource = negocio1.Listar();
                ListarCombo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //MÉTODOS
        public void ListarCombo()
        {
            AccesoDato conectar = new AccesoDato();
            try
            {
                conectar.setearConsulta("SELECT Id_producto, Nombre FROM Producto;");
                conectar.ejecutarLectura();
                while (conectar.Lector.Read())
                {
                    string nombre = conectar.Lector["Nombre"].ToString();
                    cbProductos.Items.Add(nombre);
                }
            }
            catch (Exception ex)
            {

                throw ex;
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
                }
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
            Inventario seleccionado = new Inventario();
            seleccionado = (Inventario)dgvInventario.CurrentRow.DataBoundItem;

        }
    }
}
