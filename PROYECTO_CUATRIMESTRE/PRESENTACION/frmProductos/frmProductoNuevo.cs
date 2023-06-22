using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class frmProductoNuevo : Form
    {
        private Producto producto = null;
        private OpenFileDialog archivo = null; //Para cargar imagenes.

        public frmProductoNuevo()
        {
            InitializeComponent();
        }
        public frmProductoNuevo(Producto seleccionado)
        {
            InitializeComponent();
            producto = seleccionado;
            Text = "EDITAR PRODUCTO";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (producto == null)
                {
                    producto = new Producto();
                }
                AgregarOModificar(producto);
                GuardarImagen(archivo); //Método para poder guardar la imágen.
                                        //Cerramos la ventana una vez cargado o modificado el producto.
                                        //Opcion dos: antes de cerrar la ventana, preguntar si desea agregar otro producto.
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png|jpeg|*.jpeg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImgUrl.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }
        private void txtImgUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImgUrl.Text);
        }
        private void frmProductoNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre;
                    txtDesc.Text = producto.Descripcion;
                    txtCosto.Text = producto.PrecioUnitario.ToString();
                    txtImgUrl.Text = producto.ImgUrl;
                    CargarImagen(producto.ImgUrl);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //MÉTODOS
        private void AgregarOModificar(Producto producto)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDesc.Text;
            producto.PrecioUnitario = Convert.ToDecimal(txtCosto.Text);
            producto.ImgUrl = txtImgUrl.Text;

            if (producto.Id != 0)
            {
                negocio.Modificar(producto);
                MessageBox.Show("Producto modificado!");
            }
            else
            {
                negocio.Agregar(producto);
                MessageBox.Show("Producto agregado!");
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtCosto.Clear();
            txtImgUrl.Clear();
            pbImg.Image = null;
            txtNombre.Focus();
        }
        private bool ValidarDatos()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Completar el campo NOMBRE!");
                txtNombre.Focus();
                return true;
            }
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Completar el campo DESCRIPCIÓN!");
                txtDesc.Focus();
                return true;
            }
            if (txtCosto.Text == "")
            {
                MessageBox.Show("Completar el campo COSTO!");
                txtCosto.Focus();
                return true;
            }
            //Validar si txtCosto solo ingreso números.
            if (SoloNumero(txtCosto.Text))
            {
                return true;
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            decimal valor;
            if (!decimal.TryParse(txtCosto.Text, out valor))
            {
                MessageBox.Show("Ingresar solo números en el campo COSTO!");
                txtCosto.Focus();
                txtCosto.SelectAll();
                return true;
            }
            return false;
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbImg.Load(imagen);
            }
            catch (Exception)
            {
                pbImg.Load("https://bicentenario.gob.pe/biblioteca/themes/biblioteca/assets/images/not-available-es.png");
            }
        }
        private void GuardarImagen(OpenFileDialog archivo)
        {
            if (archivo != null && !(txtImgUrl.Text.ToUpper().Contains("HTTP")))
            {
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName);
            }
        }
    }
}
