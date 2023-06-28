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
        private void pbLogo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPortada());
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmInventario());
        }
        private void btnIngEgr_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmIngresoEgreso());
        }
        private void btnEntregas_Click(object sender, EventArgs e)
        {

        }
        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProducto());
        }
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProveedor());
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

        private void btnStock_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Ventana con el detalle del stock disponible de cada producto.";
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }
        private void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Registro del dinero que entra y sale durante el día.";
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
        private void btnProducto_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Ventana con el detalle de los productos registrados.";
        }
        private void btnProducto_MouseLeave(object sender, EventArgs e)
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

        private void btnEntregas_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Registro de las entregas realizadas y pedidos pendientes por retirar.";
        }

        private void btnEntregas_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            barraEstado.Text = "Registros de las ventas finalizadas.";
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            BarraEstado();
        }
    }
}