using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kardex.clases
{
    class Clactores
    {
        // Método para insertar un actor
        public static bool InsertarActor(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_actor_insertar", // Nombre del procedimiento almacenado para insertar actores
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd") // Convertir la fecha a formato SQL
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar actor: " + ex.Message);
            }
        }

        // Método para modificar un actor
        public static bool ModificarActor(string codigo, string nombre, DateTime fechaNacimiento)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_actor_modificar", // Nombre del procedimiento almacenado para modificar actores
                    codigo,
                    nombre,
                    fechaNacimiento.ToString("yyyy-MM-dd")
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar actor: " + ex.Message);
            }
        }

        // Método para eliminar un actor
        public static bool EliminarActor(string codigo)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_actor_eliminar", // Nombre del procedimiento almacenado para eliminar actores
                    codigo
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar actor: " + ex.Message);
            }
        }

        // Método para consultar actores
        public static DataTable ConsultarActores(string codigo = null)
        {
            try
            {
                // Crear los parámetros necesarios para el procedimiento almacenado
                SqlParameter[] parametros = {
                    new SqlParameter("@p_codactor", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo)
                };

                // Llamar al método MostrarRegistros de Clpeliculas
                return Clpeliculas.MostrarRegistros("sp_actor_consultar", parametros);
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Error al consultar actores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}