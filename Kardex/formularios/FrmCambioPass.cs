using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Kardex.clases;

namespace Kardex.formularios
{
    public partial class FrmCambioPass : Form
    {

        private bool mostrandoContraseña = false;
        public FrmCambioPass()
        {
            InitializeComponent();
        }

        private void FrmCambioPass_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtClaveNueva.Text.Trim() != this.txtClaveConfirmada.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no son iguales, verifique", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (MessageBox.Show("Desea grabar?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string vProc = "sp_usuarios_cambiar_clave";
                    string msg = "Registro Modificado con éxito";

                    // Encripta las contraseñas
                    string vClaveActual = clSeguridad.Encriptar(this.txtClaveActual.Text);
                    string vClaveNueva = clSeguridad.Encriptar(this.txtClaveNueva.Text);
                    string vClaveConfirmada = clSeguridad.Encriptar(this.txtClaveConfirmada.Text);

                    // Verifica el valor de Permisos.P_codusuario
                    if (string.IsNullOrEmpty(Permisos.P_Codusuario))
                    {
                        MessageBox.Show("Código de usuario no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Agrega mensajes de depuración
                    MessageBox.Show($"Usuario: {Permisos.P_Codusuario}\nClave Actual: {vClaveActual}\nClave Nueva: {vClaveNueva}", "Debug Info");

                    // Llama al método para actualizar la información en la base de datos
                    if (clases.Clpeliculas.ActualizarInformacion(vProc, Permisos.P_Codusuario, vClaveActual, vClaveNueva))
                    {
                        MessageBox.Show(msg, "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Información no pudo ser almacenada", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en la aplicación: {ex.Message}", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }


        private void btnMostrarContraseñaConfirmada_Click(object sender, EventArgs e)
        {
            // Alternar el estado de la contraseña
            mostrandoContraseña = !mostrandoContraseña;

            // Mostrar u ocultar la contraseña del campo correspondiente
            txtClaveConfirmada.UseSystemPasswordChar = !mostrandoContraseña;

            // Cambiar la imagen del botón
            if (mostrandoContraseña)
            {
                btnMostrarContraseñaConfirmada.Image = Properties.Resources.ver; // Imagen para ver
            }
            else
            {
                btnMostrarContraseñaConfirmada.Image = Properties.Resources.esconder; // Imagen para ocultar
            }
        }

        private void btnMostrarContraseña_Click_1(object sender, EventArgs e)
        {
            // Alternar el estado de la contraseña
            mostrandoContraseña = !mostrandoContraseña;

            // Mostrar u ocultar la contraseña del campo correspondiente
            txtClaveActual.UseSystemPasswordChar = !mostrandoContraseña;

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

        private void btnMostrarContraseñaNueva_Click(object sender, EventArgs e)
        {
            // Alternar el estado de la contraseña
            mostrandoContraseña = !mostrandoContraseña;

            // Mostrar u ocultar la contraseña del campo correspondiente
            txtClaveNueva.UseSystemPasswordChar = !mostrandoContraseña;

            // Cambiar la imagen del botón
            if (mostrandoContraseña)
            {
                btnMostrarContraseñaNueva.Image = Properties.Resources.ver; // Imagen para ver
            }
            else
            {
                btnMostrarContraseñaNueva.Image = Properties.Resources.esconder; // Imagen para ocultar
            }
        }
    }
}
