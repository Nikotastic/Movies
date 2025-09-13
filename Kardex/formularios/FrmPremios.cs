using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex.clases;
using System.Data.SqlClient;

namespace Kardex.formularios
{
    public partial class frmPremios : Form
    {
        int swAncho { get; set; }
        int swAnchoOri { get; set; }
        int swNuevo { get; set; }
        DataTable dtPremios;
        private readonly string año;

        public frmPremios()
        {
            InitializeComponent();
        }

        private void tbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Width = swAncho;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Width = 320;
        }

        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar_datos();
            BloquearBtns(1);
        }

        #region Mis procedimientos

        private void Limpiar_datos()
        {
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.cmbPremios.SelectedIndex = -1; // Resetear ComboBox
            this.dtpfecha.Value = DateTime.Now; // Establecer fecha actual
            this.cmbPelicula.SelectedIndex = -1; // Resetear ComboBox de películas
        }

        private bool ValidarDatos(ref TextBox vObj)
        {
            if (string.IsNullOrWhiteSpace(vObj.Text))
            {
                MessageBox.Show("Este campo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarComboBox(ref ComboBox vObj)
        {
            if (vObj.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un valor de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BloquearDatos(int sw)
        {
            switch (sw)
            {
                case 1:
                    this.txtCodigo.ReadOnly = true;
                    this.txtNombre.ReadOnly = true;
                    this.cmbPremios.Enabled = false;
                    this.dtpfecha.Enabled = false;
                    this.cmbPelicula.Enabled = false;
                    break;
                case 2:
                    this.txtCodigo.ReadOnly = false;
                    this.txtNombre.ReadOnly = false;
                    this.cmbPremios.Enabled = true;
                    this.dtpfecha.Enabled = true;
                    this.cmbPelicula.Enabled = true;
                    break;
                case 3:
                    this.txtCodigo.ReadOnly = true;
                    this.txtNombre.ReadOnly = false;
                    this.cmbPremios.Enabled = true;
                    this.dtpfecha.Enabled = true;
                    this.cmbPelicula.Enabled = true;
                    break;
            }
        }

        private void BloquearBtns(int sw)
        {
            switch (sw)
            {
                case 1:
                    this.tbtnSalir.Enabled = true;
                    this.tbtnNuevo.Enabled = true;
                    this.tbtnModificar.Enabled = false;
                    this.tbtnGrabar.Enabled = false;
                    this.tbtnEliminar.Enabled = false;
                    this.tbtnCancelar.Enabled = false;
                    this.btnConsultar.Enabled = true;
                    break;
                case 2:
                    this.tbtnSalir.Enabled = false;
                    this.tbtnNuevo.Enabled = false;
                    this.tbtnModificar.Enabled = false;
                    this.tbtnGrabar.Enabled = true;
                    this.tbtnEliminar.Enabled = false;
                    this.tbtnCancelar.Enabled = true;
                    this.btnConsultar.Enabled = false;
                    break;
                case 3:
                    this.tbtnSalir.Enabled = false;
                    this.tbtnNuevo.Enabled = false;
                    this.tbtnModificar.Enabled = false;
                    this.tbtnGrabar.Enabled = true;
                    this.tbtnEliminar.Enabled = true;
                    this.tbtnCancelar.Enabled = true;
                    this.btnConsultar.Enabled = true;
                    break;
            }
        }

        private void frmPremios_Load(object sender, EventArgs e)
        {
            this.swAncho = 1000;
            Limpiar_datos();
            BloquearDatos(1);
            BloquearBtns(1);
            CargarPremios();
            CargarPeliculas();

            // Cargar categorías para los premios
            cmbPremios.Items.Clear(); // Limpiar primero
            cmbPremios.Items.Add("Mejor Película");
            cmbPremios.Items.Add("Mejor Director");
            cmbPremios.Items.Add("Mejor Actor");
            cmbPremios.Items.Add("Mejor Guion Original");
        }

        private void CargarPeliculas()
        {
            try
            {
                DataTable dtPeliculas = ClPremios.ConsultarPeliculas(); // Llamada sin parámetro

                if (dtPeliculas != null && dtPeliculas.Rows.Count > 0)
                {
                    cmbPelicula.DataSource = dtPeliculas;
                    cmbPelicula.DisplayMember = "Titulo";  // Asegúrate de que 'Titulo' es una columna en el DataTable
                    cmbPelicula.ValueMember = "Codigo";    // Asegúrate de que 'Codigo' es una columna en el DataTable
                    cmbPelicula.SelectedIndex = -1; // Resetear ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron películas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarPremios()
        {
            try
            {
                DataTable dtPremios = ClPremios.ConsultarPremios(); // Asume que este método funciona correctamente

                if (dtPremios != null && dtPremios.Rows.Count > 0)
                {
                    dgvPremios.DataSource = dtPremios;
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar los premios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar premios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvPremios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPremios.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                cmbPremios.SelectedItem = row.Cells["Categoria"].Value.ToString();
                dtpfecha.Value = DateTime.Parse(row.Cells["Año"].Value.ToString());


                if (row.Cells["Codigo_Pelicula"].Value != null)
                {
                    cmbPelicula.SelectedValue = row.Cells["Codigo_Pelicula"].Value.ToString();
                }
                else
                {
                    cmbPelicula.SelectedIndex = -1;
                }

                BloquearDatos(3);
                BloquearBtns(3);
            }
        }

        private void tbtnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar_datos();
            BloquearDatos(2);
            BloquearBtns(3);
            this.swNuevo = 0; // Nuevo registro
        }

        private void tbtnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(ref txtCodigo) || !ValidarDatos(ref txtNombre) || !ValidarComboBox(ref cmbPremios) || !ValidarComboBox(ref cmbPelicula))
            {
                return;
            }

            if (MessageBox.Show("¿Desea grabar?", "Gestión de Premios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string vCodigo = txtCodigo.Text.Trim();
                    string vNombre = txtNombre.Text.Trim();
                    string vCategoria = cmbPremios.SelectedItem.ToString();
                    DateTime vfnacimiento = this.dtpfecha.Value; // Asegúrate de que esta variable es de tipo DateTime
                    string vCodigoPelicula = cmbPelicula.SelectedValue?.ToString();

                    string vProcedimiento = this.swNuevo == 1 ? "sp_premios_modificar" : "sp_premios_insertar";
                    string msg = this.swNuevo == 1 ? "Registro Modificado con éxito" : "Registro Grabado con éxito";

                    if (Clpeliculas.ActualizarInformacion(vProcedimiento, vCodigo, vNombre, vCategoria, vfnacimiento, vCodigoPelicula))
                    {
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPremios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo grabar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show($"Error en el proceso de grabación: {excepcion.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        #endregion

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Width = swAncho;
        }

        private void dgvPremios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha hecho clic en una fila válida (no en la cabecera)
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Asignar valores de las celdas de la fila seleccionada a los controles del formulario
                    txtCodigo.Text = dgvPremios.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;
                    txtNombre.Text = dgvPremios.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    cmbPremios.Text = dgvPremios.Rows[e.RowIndex].Cells["Categoria"].Value?.ToString() ?? string.Empty;
                    cmbPelicula.SelectedValue = dgvPremios.Rows[e.RowIndex].Cells["Codigo_Pelicula"].Value?.ToString() ?? string.Empty;

                    // Asignar el año del premio (debe ser de tipo DateTime)
                    DateTime año;
                    if (DateTime.TryParse(dgvPremios.Rows[e.RowIndex].Cells["Año"].Value?.ToString(), out año))
                    {
                        dtpfecha.Value = año;
                    }
                    else
                    {
                        dtpfecha.ResetText();  // Si no se puede parsear la fecha, reiniciar el valor
                    }
                    tbtnEliminar.Enabled = true;
                    swNuevo = 1; // Indicamos que se trata de una modificación
                }
                catch (Exception ex)
                {
                    // Manejar excepciones, por ejemplo si alguna celda tiene un valor inesperado
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro Actual?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    String vCodigo = this.txtCodigo.Text;
                    if (clases.Clpeliculas.ActualizarInformacion("sp_premios_eliminar", vCodigo) == true)
                    {
                        MessageBox.Show("Registro Eliminado con éxito", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Información No pudo ser Eliminada", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.swNuevo = 0;
                    Limpiar_datos();
                    CargarPremios();
                    CargarPeliculas();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show("Error en el proceso de grabación" + excepcion.Message.ToString(), "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReportePremios frm = new FrmReportePremios();
            frm.ShowDialog();
        }
    }
}