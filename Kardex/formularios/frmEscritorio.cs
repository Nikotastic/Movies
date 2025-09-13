using System;
using System.Windows.Forms;
using Kardex.formularios;
using Kardex.clases;
namespace Kardex
{
    public partial class frmEscritorio : Form
    {
        public frmEscritorio()
        {
            InitializeComponent();
        }

        
        private void tlbsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeliculas frm = new frmPeliculas(); // Instancia o crea un objeto a partir del formulario
            frm.Show(this);  // Muestra el formulario no MODAL
            //frm.ShowDialog(this)  // Muestra el formulario tipo MODAL
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero frm = new frmGenero(); // Instancia o crea un objeto a partir del formulario
            frm.Show(this);  // Muestra el formulario no MODAL
            //frm.ShowDialog(this)  // Muestra el formulario tipo MODAL
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirectores frm = new frmDirectores(); // Instancia o crea un objeto a partir del formulario
            frm.Show(this);  // Muestra el formulario no MODAL
            //frm.ShowDialog(this)  // Muestra el formulario tipo MODAL
        }

        private void formasDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clpeliculas.Conectar();
                if (Clpeliculas.Conectado == true)
                {
                    MessageBox.Show("Base de datos conectada con éxito", "Inventarios 0.01"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Base de datos NO CONECTADA", "Inventarios 0.01"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message.ToString(), "Inventario 0.01",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Actores_Click(object sender, EventArgs e)
        {
            FrmActores frm = new FrmActores();
            frm.Show(this); 
        }

        private void premiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPremios frm = new frmPremios();
            frm.Show(this);
        }

        private void accesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcesso frm = new FrmAcesso();
            frm.Show(this);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permisos.P_Autorizado = false;
            FrmAcesso frmUsr = new FrmAcesso();
            frmUsr.ShowDialog(this);
        }

        private void frmEscritorio_Activated(object sender, EventArgs e)
        {
            if (Permisos.P_Autorizado == false)
            {
                FrmAcesso frmUsr = new FrmAcesso();
                frmUsr.ShowDialog();
            }
        }

        private void itmConsultas_Click(object sender, EventArgs e)
        {

        }

        private void incriptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioPass frm = new FrmCambioPass();
            frm.Show(this);
        }
    }
}
