
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
    class ClKardex
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
        public static bool ActualizarInformacion(String Procedimiento, params string[] parametros)
        {
            try
            {
                // Para determinar si la base de datos esta conectada
                // sino lo esta, entonces la abre(Conecta)
                if (Conectado == false)
                {
                    // Conexion.CadCon = CadenaConexion;
                    Conectar();
                }
                // Se declara el objeto cmd tipo sqlcommand, encargado de las instrucciones 
                // del lenguaje sql o de los procedimientos almacenados..
                SqlCommand cmd = new SqlCommand();
                // Al objeto cmd, se le pasa la conexion
                cmd.Connection = Conexion;
                // al objeto cmd se le indica que va a manejar un proc almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                // al objeto cmd, se le dice cual es el nombre del procedimiento almacenado
                // que va a ejecutar....
                cmd.CommandText = Procedimiento;

                // Se extrae el nombre de los parametros del procedimiento almacenado
                // a través de la instruccion sqlcommandbuilder
                SqlCommandBuilder.DeriveParameters(cmd);
                // Se extraen los datos enviados al metodo en forma de arreglo y se pasan al
                // a los parametos del procedimiento.

                for (int I = 0; (I < (parametros.Length)); I++)
                {

                    //    MessageBox.Show(parametros.Length.ToString());
                    //    MessageBox.Show(I.ToString()+" => "+parametros[I]);
                    ((SqlParameter)(cmd.Parameters[I + 1])).Value = parametros[I];


                }

                // Ejecuta el procedimiento almacenado
                cmd.ExecuteNonQuery();
                // Responde verdadero indicando que se hizo la grabación
                return true;
            }
            catch (Exception Excepcion)
            {
                //     MessageBox.Show("Error en la grabación de dato: " + Excepcion.Message.ToString(), "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static DataTable MostrarRegistros(String Procedimiento, params string[] parametros)
        {

            try
            {
                if (Conectado == false)
                {
                    // Conexion.CadCon = CadenaConexion;
                    Conectar();
                }
                // Se declara el objeto cmd tipo sqlcommand, encargado de las instrucciones 
                // del lenguaje sql o de los procedimientos almacenados..
                SqlCommand cmd = new SqlCommand();
                // Al objeto cmd, se le pasa la conexion
                cmd.Connection = Conexion;
                // al objeto cmd se le indica que va a manejar un proc almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                // al objeto cmd, se le dice cual es el nombre del procedimiento almacenado
                // que va a ejecutar....
                cmd.CommandText = Procedimiento;
                // Se extrae el nombre de los parametros del procedimiento almacenado
                // a través de la instruccion sqlcommandbuilder
                SqlCommandBuilder.DeriveParameters(cmd);
                // Se extraen los datos enviados al metodo en forma de arreglo y se pasan al
                // a los parametos del procedimiento.

                for (int I = 0; (I < (parametros.Length)); I++)
                {

                    //    MessageBox.Show(parametros.Length.ToString());
                    //    MessageBox.Show(I.ToString()+" => "+parametros[I]);
                    ((SqlParameter)(cmd.Parameters[I + 1])).Value = parametros[I];


                }

                // Se crea un contenedor de datos de Ado llamado datatable, el cual es una copia en memoria de los datos
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                // Responde verdadero indicando que se hizo la grabación
                return dt;
            }
            catch (Exception excepcion)
            {
                return null;
            }



        }

    }
}
