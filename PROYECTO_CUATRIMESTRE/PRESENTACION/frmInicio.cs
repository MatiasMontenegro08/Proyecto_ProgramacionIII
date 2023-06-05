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
    }
}