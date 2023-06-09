﻿using DOMINIO;
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
    public partial class frmProducto : Form
    {
        
        List<Producto> listaProducto;
        private Producto seleccionado;
        public frmProducto()
        {
            InitializeComponent();
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarPlanilla();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductoNuevo nuevo = new frmProductoNuevo();
            nuevo.ShowDialog();
            cargarPlanilla();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                frmProductoNuevo editar = new frmProductoNuevo(seleccionado);
                editar.ShowDialog();
                cargarPlanilla();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                EliminarRegistro();
            }
        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImgUrl);
            }
        }

        //MÉTODOS
        private void cargarPlanilla()
        {
            try
            {
                ProductoNegocio lista = new ProductoNegocio();
                listaProducto = lista.Listar();
                dgvProductos.DataSource = listaProducto;
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["ImgUrl"].Visible = false;
        }
        private void EliminarRegistro()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            Producto seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el producto seleccionado?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    cargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbImg.Load(imagen);
            }
            catch (Exception)
            {
                pbImg.Load("https://programacion.net/files/article/20161110041116_image-not-found.png");
            }
        }
    }
}
