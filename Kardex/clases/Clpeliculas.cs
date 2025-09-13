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
    class Clpeliculas
    {
        // Creamos el objeto connection
        public static SqlConnection Conexion = new SqlConnection();
        // Se crean dos propiedades 1. La cadena de conexion 2. es el estado de la conexion
        public static string CadCon { get; set; }
        public static bool Conectado { get; set; }

        // Se crea el metodo conectar....
        public static void Conectar()
        {
            CadCon = "Data Source=NIKOTASTIC\\SQLEXPRESS" +
                ";Initial Catalog=db_peliculas" +
                ";User ID=sa" +
                ";Password=niko";
            try
            {
                Conexion.ConnectionString = CadCon;
                Conexion.Open();
                Conectado = true;

            }
            catch (Exception ex)
            {
                Conectado = false;
            }
        }
        public static bool ActualizarInformacion(string Procedimiento, params object[] parametros)
        {
            try
            {
                // Para determinar si la base de datos está conectada
                if (Conectado == false)
                {
                    Conectar();
                }

                // Declaración del objeto SqlCommand
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = Procedimiento
                };

                // Extraer parámetros del procedimiento almacenado
                SqlCommandBuilder.DeriveParameters(cmd);

                // Pasar los valores de los parámetros
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters[i + 1].Value = parametros[i];
                }

                // Ejecutar el procedimiento almacenado
                cmd.ExecuteNonQuery();

                // Retornar verdadero indicando éxito
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable MostrarRegistros(string procedimiento, params SqlParameter[] parametros)
        {
            try
            {
                // Asegurar que la conexión está abierta.
                if (!Conectado) // Si no está conectado, conecta.
                {
                    Conectar();
                }

                // Crear el comando.
                using (SqlCommand cmd = new SqlCommand(procedimiento, Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando.
                    if (parametros != null && parametros.Length > 0)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    // Ejecutar el comando y llenar el DataTable.
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }

                    return dt; // Retornar el DataTable con los resultados.
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
        }
        
    }

}
