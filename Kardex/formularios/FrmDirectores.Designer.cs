namespace Kardex.formularios
{
    partial class frmDirectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectores));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvDirectores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tbtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectores)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(16, 121);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 17);
            this.lblcodigo.TabIndex = 27;
            this.lblcodigo.Text = "Código";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(16, 176);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(58, 17);
            this.lbltitulo.TabIndex = 28;
            this.lbltitulo.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha nacimiento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(191, 117);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 172);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // dgvDirectores
            // 
            this.dgvDirectores.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDirectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectores.Location = new System.Drawing.Point(521, 47);
            this.dgvDirectores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDirectores.Name = "dgvDirectores";
            this.dgvDirectores.Size = new System.Drawing.Size(511, 276);
            this.dgvDirectores.TabIndex = 34;
            this.dgvDirectores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirectores_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Consulta de informacion";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 362);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(393, 27);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSalir
            // 
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
            this.tbtnModificar.Click += new System.EventHandler(this.tbtnModificar_Click);
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
            this.tbtnCancelar.Click += new System.EventHandler(this.tbtnCancelar_Click_1);
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
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Image = global::Kardex.Properties.Resources.btnVolver_fw;
            this.btn_regresar.Location = new System.Drawing.Point(1043, 159);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(48, 50);
            this.btn_regresar.TabIndex = 36;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::Kardex.Properties.Resources.btnconsultar1;
            this.btnConsultar.Location = new System.Drawing.Point(344, 112);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(40, 33);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // picTitulo
            // 
            this.picTitulo.Image = ((System.Drawing.Image)(resources.GetObject("picTitulo.Image")));
            this.picTitulo.Location = new System.Drawing.Point(57, 28);
            this.picTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(236, 55);
            this.picTitulo.TabIndex = 22;
            this.picTitulo.TabStop = false;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(191, 228);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(132, 22);
            this.dtpfecha.TabIndex = 40;
            this.dtpfecha.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // frmDirectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(393, 389);
            this.ControlBox = false;
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDirectores);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.picTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDirectores";
            this.Load += new System.EventHandler(this.frmDirectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectores)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvDirectores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSalir;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripButton tbtnModificar;
        private System.Windows.Forms.ToolStripButton tbtnGrabar;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnImprimir;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}