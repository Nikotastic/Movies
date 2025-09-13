namespace Kardex.formularios
{
    partial class FrmCambioPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioPass));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNuevaClave = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.txtClaveConfirmada = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.btnMostrarContraseñaNueva = new System.Windows.Forms.Button();
            this.btnMostrarContraseñaConfirmada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(567, 27);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "CAMBIO DE CONTRASEÑA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Clave actual ";
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.AutoSize = true;
            this.lblNuevaClave.Location = new System.Drawing.Point(238, 269);
            this.lblNuevaClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Size = new System.Drawing.Size(88, 17);
            this.lblNuevaClave.TabIndex = 51;
            this.lblNuevaClave.Text = "Nueva Clave";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(237, 339);
            this.lblConfirmarClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(106, 17);
            this.lblConfirmarClave.TabIndex = 52;
            this.lblConfirmarClave.Text = "Confirmar clave";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(158, 223);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveActual.MaxLength = 100;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Size = new System.Drawing.Size(251, 22);
            this.txtClaveActual.TabIndex = 53;
            this.txtClaveActual.UseSystemPasswordChar = true;
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Location = new System.Drawing.Point(158, 302);
            this.txtClaveNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveNueva.MaxLength = 100;
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.Size = new System.Drawing.Size(251, 22);
            this.txtClaveNueva.TabIndex = 54;
            this.txtClaveNueva.UseSystemPasswordChar = true;
            // 
            // txtClaveConfirmada
            // 
            this.txtClaveConfirmada.Location = new System.Drawing.Point(158, 371);
            this.txtClaveConfirmada.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveConfirmada.MaxLength = 100;
            this.txtClaveConfirmada.Name = "txtClaveConfirmada";
            this.txtClaveConfirmada.Size = new System.Drawing.Size(251, 22);
            this.txtClaveConfirmada.TabIndex = 55;
            this.txtClaveConfirmada.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(101, 428);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 33);
            this.btnAceptar.TabIndex = 56;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(310, 428);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 33);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarContraseña.Image")));
            this.btnMostrarContraseña.Location = new System.Drawing.Point(384, 223);
            this.btnMostrarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(25, 21);
            this.btnMostrarContraseña.TabIndex = 60;
            this.btnMostrarContraseña.UseVisualStyleBackColor = false;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click_1);
            // 
            // btnMostrarContraseñaNueva
            // 
            this.btnMostrarContraseñaNueva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrarContraseñaNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContraseñaNueva.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseñaNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMostrarContraseñaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseñaNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarContraseñaNueva.Image")));
            this.btnMostrarContraseñaNueva.Location = new System.Drawing.Point(384, 302);
            this.btnMostrarContraseñaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarContraseñaNueva.Name = "btnMostrarContraseñaNueva";
            this.btnMostrarContraseñaNueva.Size = new System.Drawing.Size(25, 21);
            this.btnMostrarContraseñaNueva.TabIndex = 61;
            this.btnMostrarContraseñaNueva.UseVisualStyleBackColor = false;
            this.btnMostrarContraseñaNueva.Click += new System.EventHandler(this.btnMostrarContraseñaNueva_Click);
            // 
            // btnMostrarContraseñaConfirmada
            // 
            this.btnMostrarContraseñaConfirmada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrarContraseñaConfirmada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContraseñaConfirmada.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseñaConfirmada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMostrarContraseñaConfirmada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseñaConfirmada.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarContraseñaConfirmada.Image")));
            this.btnMostrarContraseñaConfirmada.Location = new System.Drawing.Point(384, 371);
            this.btnMostrarContraseñaConfirmada.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarContraseñaConfirmada.Name = "btnMostrarContraseñaConfirmada";
            this.btnMostrarContraseñaConfirmada.Size = new System.Drawing.Size(25, 21);
            this.btnMostrarContraseñaConfirmada.TabIndex = 62;
            this.btnMostrarContraseñaConfirmada.UseVisualStyleBackColor = false;
            this.btnMostrarContraseñaConfirmada.Click += new System.EventHandler(this.btnMostrarContraseñaConfirmada_Click);
            // 
            // FrmCambioPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(558, 499);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostrarContraseñaConfirmada);
            this.Controls.Add(this.btnMostrarContraseñaNueva);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtClaveConfirmada);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.lblNuevaClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCambioPass";
            this.Load += new System.EventHandler(this.FrmCambioPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.TextBox txtClaveConfirmada;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrarContraseña;
        private System.Windows.Forms.Button btnMostrarContraseñaNueva;
        private System.Windows.Forms.Button btnMostrarContraseñaConfirmada;
    }
}