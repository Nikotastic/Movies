using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Kardex.clases;

namespace Kardex.formularios
{
    public partial class FrmAcesso : Form
    {
        private bool mostrandoContraseña = false;
        DataTable dtUsuarios;
        string Password { get; set; }


        public FrmAcesso()
        {
            InitializeComponent();
        }

        private void FrmAcesso_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Trim() == this.Password)
            {
                Permisos.P_Autorizado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Clave Inválida, verifique", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (this.txtCodigo.TextLength > 0)
            {
                dtUsuarios = clases.ClKardex.MostrarRegistros("sp_usuarios_consultar", this.txtCodigo.Text);
                if (dtUsuarios.Rows.Count > 0)
                {
                    DataRow usr = dtUsuarios.Rows[0];
                    this.txtCodigo.Text = usr["fld_codusuario"].ToString();
                    this.txtNombre.Text = usr["fld_Nombre"].ToString();
                    this.Password = clSeguridad.DesEncriptar(usr["fld_password"].ToString());
                    Permisos.P_Codusuario = this.txtCodigo.Text;
                }
                else
                {
                    MessageBox.Show("Usuario no existe en la aplicación", "Inventaio 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            // Alternar el estado de la contraseña
            mostrandoContraseña = !mostrandoContraseña;

            // Mostrar u ocultar la contraseña
            txtPassword.UseSystemPasswordChar = !mostrandoContraseña;

            // Cambiar la imagen del botón
            if (mostrandoContraseña)
            {
                btnMostrarContraseña.Image = Properties.Resources.ver; // Imagen para ver
            }
            else
            {
                btnMostrarContraseña.Image = Properties.Resources.esconder; // Imagen para ocultar
            }
        }

        private void btncifrado_Click(object sender, EventArgs e)
        {
            txtPassword.Text = clSeguridad.Encriptar(txtNombre.Text);
            //            txtcadenafinal.Text = Seguridad.DesEncriptar(txtcadenaencriptada.Text);
            //            //Vereis que despues de estas instrucciones txtcadenainial y txtcadenafinal contienen lo mismo.
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
