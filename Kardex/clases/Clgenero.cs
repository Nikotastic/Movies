using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kardex.clases
{
    class Clgenero
    {
        // Método para insertar un director
        public static bool InsertarGenero(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_genero_insertar", // Nombre del procedimiento almacenado
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd") // Convertir la fecha a formato SQL
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar director: " + ex.Message);
            }
        }

        // Método para modificar un director
        public static bool ModificarGenero(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_director_modificar",
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd")
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar director: " + ex.Message);
            }
        }

        // Método para eliminar un director
        public static bool EliminarGenero(string codigo)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_genero_eliminar",
                    codigo
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar director: " + ex.Message);
            }
        }
        public static DataTable ConsultarGeneros(string codigo = null)
        {
            try
            {
                // Crear los parámetros necesarios para el procedimiento almacenado
                SqlParameter[] parametros = {
            new SqlParameter("@p_codgenero", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo)
        };

                // Llamar al método MostrarRegistros de Clpeliculas
                return Clpeliculas.MostrarRegistros("sp_genero_consultar", parametros);
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Error al consultar directores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
