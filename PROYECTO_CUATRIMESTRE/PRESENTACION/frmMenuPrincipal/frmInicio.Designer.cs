namespace PRESENTACION
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.btnIngEgr = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraEstado
            // 
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(35, 17);
            this.barraEstado.Text = "Listo.";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.panelMenu.Controls.Add(this.btnProveedor);
            this.panelMenu.Controls.Add(this.btnProducto);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnEntregas);
            this.panelMenu.Controls.Add(this.btnIngEgr);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.pbLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 554);
            this.panelMenu.TabIndex = 4;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(0, 470);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(200, 62);
            this.btnProveedor.TabIndex = 10;
            this.btnProveedor.Text = "PROVEEDORES";
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            this.btnProveedor.MouseEnter += new System.EventHandler(this.btnProveedor_MouseEnter);
            this.btnProveedor.MouseLeave += new System.EventHandler(this.btnProveedor_MouseLeave);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 402);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(200, 62);
            this.btnProducto.TabIndex = 9;
            this.btnProducto.Text = "PRODUCTOS";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            this.btnProducto.MouseEnter += new System.EventHandler(this.btnProducto_MouseEnter);
            this.btnProducto.MouseLeave += new System.EventHandler(this.btnProducto_MouseLeave);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 334);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 62);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnEntregas
            // 
            this.btnEntregas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEntregas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregas.FlatAppearance.BorderSize = 0;
            this.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregas.Image")));
            this.btnEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregas.Location = new System.Drawing.Point(0, 266);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(200, 62);
            this.btnEntregas.TabIndex = 4;
            this.btnEntregas.Text = "ENTREGAS";
            this.btnEntregas.UseVisualStyleBackColor = false;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            this.btnEntregas.MouseEnter += new System.EventHandler(this.btnEntregas_MouseEnter);
            this.btnEntregas.MouseLeave += new System.EventHandler(this.btnEntregas_MouseLeave);
            // 
            // btnIngEgr
            // 
            this.btnIngEgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnIngEgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngEgr.FlatAppearance.BorderSize = 0;
            this.btnIngEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngEgr.Image = ((System.Drawing.Image)(resources.GetObject("btnIngEgr.Image")));
            this.btnIngEgr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngEgr.Location = new System.Drawing.Point(0, 198);
            this.btnIngEgr.Name = "btnIngEgr";
            this.btnIngEgr.Size = new System.Drawing.Size(200, 62);
            this.btnIngEgr.TabIndex = 3;
            this.btnIngEgr.Text = "INGRESO/EGRESO";
            this.btnIngEgr.UseVisualStyleBackColor = false;
            this.btnIngEgr.Click += new System.EventHandler(this.btnIngEgr_Click);
            this.btnIngEgr.MouseEnter += new System.EventHandler(this.btnPedidos_MouseEnter);
            this.btnIngEgr.MouseLeave += new System.EventHandler(this.btnPedidos_MouseLeave);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Image = global::PRESENTACION.Properties.Resources._10;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 130);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(200, 62);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "INVENTARIO";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseEnter += new System.EventHandler(this.btnStock_MouseEnter);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.Info;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 124);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            this.pbLogo.MouseEnter += new System.EventHandler(this.pbLogo_MouseEnter);
            this.pbLogo.MouseLeave += new System.EventHandler(this.pbLogo_MouseLeave);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(804, 554);
            this.pnlPrincipal.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 554);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 576);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 615);
            this.MinimumSize = new System.Drawing.Size(1020, 615);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBLIMARTE RECONQUISTA";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barraEstado;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnIngEgr;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntregas;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnVentas;
    }
}