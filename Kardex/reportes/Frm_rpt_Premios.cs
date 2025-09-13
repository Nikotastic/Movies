using System;
using System.Windows.Forms;
using System.IO;

namespace Kardex.formularios
{
    public partial class FrmReportePremios : Form
    {
        public FrmReportePremios()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_rpt_Premios_Load(object sender, EventArgs e)
        {
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "reportes", "ReportePremios.rpt");

                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se encontró el archivo del reporte:\n" + ruta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                crystalReportViewer1.ReportSource = ruta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
