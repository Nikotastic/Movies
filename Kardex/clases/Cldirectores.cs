using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kardex.clases
{
    public static class Cldirectores
    {
        // Método para consultar directores
        public static DataTable ConsultarDirectores(string codigo = null, string nombre = null, DateTime? fechaNacimiento = null)
        {
            try
            {
                SqlParameter[] parametros = {
                    new SqlParameter("@codigo", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo),
                    new SqlParameter("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre),
                    new SqlParameter("@fechaNacimiento", fechaNacimiento.HasValue ? (object)fechaNacimiento.Value : DBNull.Value)
                };

                return Clpeliculas.MostrarRegistros("sp_directores_consultar", parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar directores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método para insertar un nuevo director
        public static bool InsertarDirector(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_directores_insertar",
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd")
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar director: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para modificar un director
        public static bool ModificarDirector(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_directores_modificar",
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd")
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar director: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para eliminar un director
        public static bool EliminarDirector(string codigo)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_directores_eliminar",
                    codigo
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar director: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
