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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProducto());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmInventario());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPedido());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProveedor());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPortada());
        }

        //MÉTODOS
        private void abrirFormulario(object frm)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }
            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(fh);
            this.pnlPrincipal.Tag = fh;
            fh.Show();
        }
        private void BarraEstado()
        {
            barraEstado.Text = "Listo.";
        }

        //EVENTOS MOUSE ENTER Y LEAVE
        private void btnProducto_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Ventana con el detalle de los productos registrados.";
        }

        private void btnProducto_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void btnStock_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Ventana con el detalle del stock disponible de cada producto.";
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void btnProveedor_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Ventana con el detalle de los proveedores registrados.";
        }

        private void btnProveedor_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Proximamente.";
        }

        private void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Proximamente.";
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void pbLogo_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Inicio.";
        }

        private void pbLogo_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }
    }
}