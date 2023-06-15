namespace PRESENTACION
{
    partial class frmProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbImg);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(392, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 421);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(6, 14);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(380, 396);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 2;
            this.pbImg.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(261, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(146, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 38);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(16, 86);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(369, 350);
            this.dgvProductos.TabIndex = 7;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(31, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevo;
    }
}