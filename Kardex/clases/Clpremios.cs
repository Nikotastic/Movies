using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kardex.clases
{
    class ClPremios
    {
        public static bool InsertarPremio(string codigo, string nombre, string categoria, DateTime año, string codigoPelicula)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_premios_insertar",
                    codigo,
                    nombre,
                    categoria,
                    año, // Pasar DateTime directamente
                    codigoPelicula
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar premio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ModificarPremio(string codigo, string nombre, string categoria, DateTime año, string codigoPelicula)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_premios_modificar",
                    codigo,
                    nombre,
                    categoria,
                    año, // Pasar DateTime directamente
                    codigoPelicula
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar premio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarPremio(string codigo)
        {
            try
            {
                return Clpeliculas.ActualizarInformacion(
                    "sp_premios_eliminar",
                    codigo
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar premio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable ConsultarPremios(string codigoPremio = null, string codigoPelicula = null)
        {
            try
            {
                SqlParameter[] parametros = {
                    new SqlParameter("@p_codpremio", string.IsNullOrEmpty(codigoPremio) ? (object)DBNull.Value : codigoPremio),
                    new SqlParameter("@p_codpeli", string.IsNullOrEmpty(codigoPelicula) ? (object)DBNull.Value : codigoPelicula)
                };

                return Clpeliculas.MostrarRegistros("sp_premios_consultar", parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar premios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable ConsultarPeliculas(string codigo = null)
        {
            try
            {
                SqlParameter[] parametros = {
                    new SqlParameter("@p_codpeli", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo)
                };

                return Clpeliculas.MostrarRegistros("sp_pelicula_consultar", parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
