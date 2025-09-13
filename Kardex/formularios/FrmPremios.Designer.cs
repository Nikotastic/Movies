namespace Kardex.formularios
{
    partial class frmPremios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPremios));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPremios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tbtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.dgvPremios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(16, 118);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 17);
            this.lblcodigo.TabIndex = 20;
            this.lblcodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(167, 118);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(16, 180);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(58, 17);
            this.lblnombre.TabIndex = 23;
            this.lblnombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 171);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Premios";
            // 
            // cmbPremios
            // 
            this.cmbPremios.FormattingEnabled = true;
            this.cmbPremios.Location = new System.Drawing.Point(167, 225);
            this.cmbPremios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPremios.Name = "cmbPremios";
            this.cmbPremios.Size = new System.Drawing.Size(193, 24);
            this.cmbPremios.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Codigo Pelicula";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(167, 327);
            this.cmbPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(193, 24);
            this.cmbPelicula.TabIndex = 30;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSalir,
            this.tbtnNuevo,
            this.tbtnModificar,
            this.tbtnGrabar,
            this.tbtnCancelar,
            this.tbtnEliminar,
            this.tbtnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 441);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 27);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSalir
            // 
            this.tbtnSalir.BackColor = System.Drawing.Color.Black;
            this.tbtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSalir.Image = global::Kardex.Properties.Resources.btnsalir;
            this.tbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSalir.Name = "tbtnSalir";
            this.tbtnSalir.Size = new System.Drawing.Size(24, 24);
            this.tbtnSalir.Text = "tbtnSalir";
            this.tbtnSalir.ToolTipText = "Cerrar Formulario";
            this.tbtnSalir.Click += new System.EventHandler(this.tbtnSalir_Click);
            // 
            // tbtnNuevo
            // 
            this.tbtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnNuevo.Image = global::Kardex.Properties.Resources.btnnuevo;
            this.tbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNuevo.Name = "tbtnNuevo";
            this.tbtnNuevo.Size = new System.Drawing.Size(24, 24);
            this.tbtnNuevo.ToolTipText = "Nuevo Registro";
            this.tbtnNuevo.Click += new System.EventHandler(this.tbtnNuevo_Click_1);
            // 
            // tbtnModificar
            // 
            this.tbtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnModificar.Image = global::Kardex.Properties.Resources.icono_modificar_fw;
            this.tbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnModificar.Name = "tbtnModificar";
            this.tbtnModificar.Size = new System.Drawing.Size(24, 24);
            this.tbtnModificar.Text = "toolStripButton2";
            this.tbtnModificar.ToolTipText = "Modificar Registro Actual";
            // 
            // tbtnGrabar
            // 
            this.tbtnGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnGrabar.Image = global::Kardex.Properties.Resources.icono_guardar_fw;
            this.tbtnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGrabar.Name = "tbtnGrabar";
            this.tbtnGrabar.Size = new System.Drawing.Size(24, 24);
            this.tbtnGrabar.Text = "toolStripButton3";
            this.tbtnGrabar.ToolTipText = "Grabar Información";
            this.tbtnGrabar.Click += new System.EventHandler(this.tbtnGrabar_Click);
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnCancelar.Image = global::Kardex.Properties.Resources.icono_cancelar_fw;
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(24, 24);
            this.tbtnCancelar.Text = "toolStripButton4";
            this.tbtnCancelar.ToolTipText = "Cancelar";
            this.tbtnCancelar.Click += new System.EventHandler(this.tbtnCancelar_Click);
            // 
            // tbtnEliminar
            // 
            this.tbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEliminar.Image = global::Kardex.Properties.Resources.icono_eliminar_fw;
            this.tbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEliminar.Name = "tbtnEliminar";
            this.tbtnEliminar.Size = new System.Drawing.Size(24, 24);
            this.tbtnEliminar.Text = "toolStripButton5";
            this.tbtnEliminar.ToolTipText = "Eliminar registro actual";
            this.tbtnEliminar.Click += new System.EventHandler(this.tbtnEliminar_Click);
            // 
            // tbtnImprimir
            // 
            this.tbtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnImprimir.Image = global::Kardex.Properties.Resources.icono_imprimir_fw;
            this.tbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnImprimir.Name = "tbtnImprimir";
            this.tbtnImprimir.Size = new System.Drawing.Size(24, 24);
            this.tbtnImprimir.Text = "toolStripButton6";
            this.tbtnImprimir.ToolTipText = "Imprimir";
            this.tbtnImprimir.Click += new System.EventHandler(this.tbtnImprimir_Click);
            // 
            // dgvPremios
            // 
            this.dgvPremios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPremios.Location = new System.Drawing.Point(444, 63);
            this.dgvPremios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPremios.Name = "dgvPremios";
            this.dgvPremios.Size = new System.Drawing.Size(671, 356);
            this.dgvPremios.TabIndex = 32;
            this.dgvPremios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPremios_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Consulta de informacion";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::Kardex.Properties.Resources.btnVolver_fw;
            this.btnVolver.Location = new System.Drawing.Point(1123, 225);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(48, 50);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::Kardex.Properties.Resources.btnconsultar1;
            this.btnConsultar.Location = new System.Drawing.Point(361, 110);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(40, 33);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // picTitulo
            // 
            this.picTitulo.Image = ((System.Drawing.Image)(resources.GetObject("picTitulo.Image")));
            this.picTitulo.Location = new System.Drawing.Point(16, 15);
            this.picTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(237, 58);
            this.picTitulo.TabIndex = 19;
            this.picTitulo.TabStop = false;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(167, 282);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(132, 22);
            this.dtpfecha.TabIndex = 41;
            this.dtpfecha.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // frmPremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(404, 468);
            this.ControlBox = false;
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvPremios);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPremios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.picTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPremios";
            this.Load += new System.EventHandler(this.frmPremios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPremios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSalir;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripButton tbtnModificar;
        private System.Windows.Forms.ToolStripButton tbtnGrabar;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnImprimir;
        private System.Windows.Forms.DataGridView dgvPremios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}