namespace PRESENTACION
{
    partial class frmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblValiPrimera = new System.Windows.Forms.Label();
            this.lblValiDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbIngEgr = new System.Windows.Forms.GroupBox();
            this.rbEfectivo2 = new System.Windows.Forms.RadioButton();
            this.rbTrans2 = new System.Windows.Forms.RadioButton();
            this.rbEfectivo1 = new System.Windows.Forms.RadioButton();
            this.rbTrans1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha1 = new System.Windows.Forms.TextBox();
            this.txtFecha2 = new System.Windows.Forms.TextBox();
            this.txtMonto2 = new System.Windows.Forms.TextBox();
            this.lblValiSegunda = new System.Windows.Forms.Label();
            this.txtMonto1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotall = new System.Windows.Forms.Label();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbIngEgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanilla.Location = new System.Drawing.Point(39, 243);
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(735, 248);
            this.dgvPlanilla.TabIndex = 33;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(28, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 27);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(28, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 27);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(28, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 27);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(28, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 27);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblValiPrimera
            // 
            this.lblValiPrimera.AutoSize = true;
            this.lblValiPrimera.ForeColor = System.Drawing.Color.Red;
            this.lblValiPrimera.Location = new System.Drawing.Point(9, 129);
            this.lblValiPrimera.Name = "lblValiPrimera";
            this.lblValiPrimera.Size = new System.Drawing.Size(29, 13);
            this.lblValiPrimera.TabIndex = 43;
            this.lblValiPrimera.Text = "label";
            // 
            // lblValiDetalle
            // 
            this.lblValiDetalle.AutoSize = true;
            this.lblValiDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblValiDetalle.Location = new System.Drawing.Point(72, 23);
            this.lblValiDetalle.Name = "lblValiDetalle";
            this.lblValiDetalle.Size = new System.Drawing.Size(29, 13);
            this.lblValiDetalle.TabIndex = 41;
            this.lblValiDetalle.Text = "label";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(11, 43);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(295, 20);
            this.txtDetalle.TabIndex = 40;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(125, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "FECHA";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(8, 23);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(58, 13);
            this.lblDetalle.TabIndex = 38;
            this.lblDetalle.Text = "DETALLE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(624, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 210);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // gbIngEgr
            // 
            this.gbIngEgr.Controls.Add(this.label5);
            this.gbIngEgr.Controls.Add(this.label4);
            this.gbIngEgr.Controls.Add(this.rbEfectivo2);
            this.gbIngEgr.Controls.Add(this.rbTrans2);
            this.gbIngEgr.Controls.Add(this.rbEfectivo1);
            this.gbIngEgr.Controls.Add(this.rbTrans1);
            this.gbIngEgr.Controls.Add(this.label3);
            this.gbIngEgr.Controls.Add(this.label2);
            this.gbIngEgr.Controls.Add(this.label1);
            this.gbIngEgr.Controls.Add(this.lblValiDetalle);
            this.gbIngEgr.Controls.Add(this.lblValiPrimera);
            this.gbIngEgr.Controls.Add(this.txtDetalle);
            this.gbIngEgr.Controls.Add(this.txtFecha1);
            this.gbIngEgr.Controls.Add(this.lblDetalle);
            this.gbIngEgr.Controls.Add(this.txtFecha2);
            this.gbIngEgr.Controls.Add(this.lblFecha);
            this.gbIngEgr.Controls.Add(this.txtMonto2);
            this.gbIngEgr.Controls.Add(this.lblValiSegunda);
            this.gbIngEgr.Controls.Add(this.txtMonto1);
            this.gbIngEgr.Location = new System.Drawing.Point(39, 27);
            this.gbIngEgr.Name = "gbIngEgr";
            this.gbIngEgr.Size = new System.Drawing.Size(498, 210);
            this.gbIngEgr.TabIndex = 45;
            this.gbIngEgr.TabStop = false;
            // 
            // rbEfectivo2
            // 
            this.rbEfectivo2.AutoSize = true;
            this.rbEfectivo2.Location = new System.Drawing.Point(428, 159);
            this.rbEfectivo2.Name = "rbEfectivo2";
            this.rbEfectivo2.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo2.TabIndex = 55;
            this.rbEfectivo2.TabStop = true;
            this.rbEfectivo2.Text = "Efectivo";
            this.rbEfectivo2.UseVisualStyleBackColor = true;
            // 
            // rbTrans2
            // 
            this.rbTrans2.AutoSize = true;
            this.rbTrans2.Location = new System.Drawing.Point(322, 160);
            this.rbTrans2.Name = "rbTrans2";
            this.rbTrans2.Size = new System.Drawing.Size(90, 17);
            this.rbTrans2.TabIndex = 54;
            this.rbTrans2.TabStop = true;
            this.rbTrans2.Text = "Transferencia";
            this.rbTrans2.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo1
            // 
            this.rbEfectivo1.AutoSize = true;
            this.rbEfectivo1.Location = new System.Drawing.Point(428, 98);
            this.rbEfectivo1.Name = "rbEfectivo1";
            this.rbEfectivo1.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo1.TabIndex = 53;
            this.rbEfectivo1.TabStop = true;
            this.rbEfectivo1.Text = "Efectivo";
            this.rbEfectivo1.UseVisualStyleBackColor = true;
            // 
            // rbTrans1
            // 
            this.rbTrans1.AutoSize = true;
            this.rbTrans1.Location = new System.Drawing.Point(322, 98);
            this.rbTrans1.Name = "rbTrans1";
            this.rbTrans1.Size = new System.Drawing.Size(90, 17);
            this.rbTrans1.TabIndex = 52;
            this.rbTrans1.TabStop = true;
            this.rbTrans1.Text = "Transferencia";
            this.rbTrans1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "MONTO";
            // 
            // txtFecha1
            // 
            this.txtFecha1.Location = new System.Drawing.Point(97, 99);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(98, 20);
            this.txtFecha1.TabIndex = 47;
            // 
            // txtFecha2
            // 
            this.txtFecha2.Location = new System.Drawing.Point(97, 157);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(98, 20);
            this.txtFecha2.TabIndex = 46;
            // 
            // txtMonto2
            // 
            this.txtMonto2.Location = new System.Drawing.Point(229, 157);
            this.txtMonto2.Name = "txtMonto2";
            this.txtMonto2.Size = new System.Drawing.Size(77, 20);
            this.txtMonto2.TabIndex = 9;
            // 
            // lblValiSegunda
            // 
            this.lblValiSegunda.AutoSize = true;
            this.lblValiSegunda.ForeColor = System.Drawing.Color.Red;
            this.lblValiSegunda.Location = new System.Drawing.Point(9, 187);
            this.lblValiSegunda.Name = "lblValiSegunda";
            this.lblValiSegunda.Size = new System.Drawing.Size(29, 13);
            this.lblValiSegunda.TabIndex = 8;
            this.lblValiSegunda.Text = "label";
            // 
            // txtMonto1
            // 
            this.txtMonto1.Location = new System.Drawing.Point(229, 98);
            this.txtMonto1.Name = "txtMonto1";
            this.txtMonto1.Size = new System.Drawing.Size(77, 20);
            this.txtMonto1.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(642, 507);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 47;
            // 
            // lblTotall
            // 
            this.lblTotall.AutoSize = true;
            this.lblTotall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotall.Location = new System.Drawing.Point(526, 507);
            this.lblTotall.Name = "lblTotall";
            this.lblTotall.Size = new System.Drawing.Size(92, 25);
            this.lblTotall.TabIndex = 46;
            this.lblTotall.Text = "TOTAL:";
            // 
            // pbFondo
            // 
            this.pbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo.Image")));
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(804, 554);
            this.pbFondo.TabIndex = 48;
            this.pbFondo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "1° Entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "2° Entrega:";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(242)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(804, 554);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotall);
            this.Controls.Add(this.gbIngEgr);
            this.Controls.Add(this.dgvPlanilla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbIngEgr.ResumeLayout(false);
            this.gbIngEgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblValiPrimera;
        private System.Windows.Forms.Label lblValiDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbIngEgr;
        private System.Windows.Forms.Label lblValiSegunda;
        private System.Windows.Forms.TextBox txtMonto1;
        private System.Windows.Forms.TextBox txtMonto2;
        private System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotall;
        private System.Windows.Forms.RadioButton rbEfectivo2;
        private System.Windows.Forms.RadioButton rbTrans2;
        private System.Windows.Forms.RadioButton rbEfectivo1;
        private System.Windows.Forms.RadioButton rbTrans1;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}