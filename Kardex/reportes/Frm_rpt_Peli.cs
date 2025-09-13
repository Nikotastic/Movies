using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;

namespace Kardex.formularios
{
    public partial class FrmReportePeli : Form
    {
        public FrmReportePeli()
        {
            InitializeComponent();
            this.Load += FrmReportePeli_Load; // evento Load del formulario
        }

        private void FrmReportePeli_Load(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            string ruta = Application.StartupPath + @"\reportes\ReportePeliculas.rpt";

            if (!System.IO.File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo de reporte en: " + ruta);
                return;
            }

            reporte.Load(ruta);
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
