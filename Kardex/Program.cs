using System;
using System.Windows.Forms;
using Kardex.formularios;

namespace Kardex
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmAcesso loginForm = new FrmAcesso())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmAcesso());
                }
                else
                {
                    Application.Exit();
                }
            }
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new frmEscritorio());
        }
    }
    static class Permisos
    {
        public static bool P_Autorizado { get; set; }
        public static String P_Codusuario { get; set; }
    }
}
