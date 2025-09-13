namespace Kardex
{
    partial class frmEscritorio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscritorio));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.itmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlbparametrizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Actores = new System.Windows.Forms.ToolStripMenuItem();
            this.premiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlbsalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.incriptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmArchivo,
            this.itmConsultas,
            this.itmReportes,
            this.itmSistemas});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(1407, 28);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // itmArchivo
            // 
            this.itmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbparametrizacion,
            this.tlbsalir,
            this.cerrarSesionToolStripMenuItem});
            this.itmArchivo.Name = "itmArchivo";
            this.itmArchivo.Size = new System.Drawing.Size(71, 24);
            this.itmArchivo.Text = "Archivo";
            // 
            // tlbparametrizacion
            // 
            this.tlbparametrizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.Actores,
            this.premiosToolStripMenuItem});
            this.tlbparametrizacion.Name = "tlbparametrizacion";
            this.tlbparametrizacion.Size = new System.Drawing.Size(190, 26);
            this.tlbparametrizacion.Text = "Parametrización";
            this.tlbparametrizacion.ToolTipText = "Permite agregar o modificar datos maestros";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.productosToolStripMenuItem.Text = "Peliculas";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.marcasToolStripMenuItem.Text = "Genero";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.clientesToolStripMenuItem.Text = "Director";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Actores
            // 
            this.Actores.Name = "Actores";
            this.Actores.Size = new System.Drawing.Size(140, 26);
            this.Actores.Text = "Actores";
            this.Actores.Click += new System.EventHandler(this.Actores_Click);
            // 
            // premiosToolStripMenuItem
            // 
            this.premiosToolStripMenuItem.Name = "premiosToolStripMenuItem";
            this.premiosToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.premiosToolStripMenuItem.Text = "Premios";
            this.premiosToolStripMenuItem.Click += new System.EventHandler(this.premiosToolStripMenuItem_Click);
            // 
            // tlbsalir
            // 
            this.tlbsalir.Name = "tlbsalir";
            this.tlbsalir.Size = new System.Drawing.Size(190, 26);
            this.tlbsalir.Text = "Salir";
            this.tlbsalir.ToolTipText = "Salir del programa";
            this.tlbsalir.Click += new System.EventHandler(this.tlbsalir_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion ";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // itmConsultas
            // 
            this.itmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accesoToolStripMenuItem});
            this.itmConsultas.Name = "itmConsultas";
            this.itmConsultas.Size = new System.Drawing.Size(84, 24);
            this.itmConsultas.Text = "Consultas";
            this.itmConsultas.Click += new System.EventHandler(this.itmConsultas_Click);
            // 
            // accesoToolStripMenuItem
            // 
            this.accesoToolStripMenuItem.Name = "accesoToolStripMenuItem";
            this.accesoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.accesoToolStripMenuItem.Text = "Acceso";
            this.accesoToolStripMenuItem.Click += new System.EventHandler(this.accesoToolStripMenuItem_Click);
            // 
            // itmReportes
            // 
            this.itmReportes.Name = "itmReportes";
            this.itmReportes.Size = new System.Drawing.Size(80, 24);
            this.itmReportes.Text = "Reportes";
            // 
            // itmSistemas
            // 
            this.itmSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incriptarToolStripMenuItem});
            this.itmSistemas.Name = "itmSistemas";
            this.itmSistemas.Size = new System.Drawing.Size(79, 24);
            this.itmSistemas.Text = "Sistemas";
            // 
            // incriptarToolStripMenuItem
            // 
            this.incriptarToolStripMenuItem.Name = "incriptarToolStripMenuItem";
            this.incriptarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.incriptarToolStripMenuItem.Text = "Cambiar contraseña";
            this.incriptarToolStripMenuItem.Click += new System.EventHandler(this.incriptarToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.Location = new System.Drawing.Point(1231, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conexion ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1407, 554);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // frmEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 554);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEscritorio";
            this.Text = "Kardex Version 0.01";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tlbparametrizacion;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Actores;
        private System.Windows.Forms.ToolStripMenuItem tlbsalir;
        private System.Windows.Forms.ToolStripMenuItem itmConsultas;
        private System.Windows.Forms.ToolStripMenuItem itmReportes;
        private System.Windows.Forms.ToolStripMenuItem itmSistemas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem premiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incriptarToolStripMenuItem;
    }
}

