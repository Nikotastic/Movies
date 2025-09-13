using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Kardex.clases;
using Kardex.formularios;


namespace Kardex
{
    public partial class frmGenero : Form
    {
        int swAncho { get; set; }
        int swAnchoOri { get; set; }
        int swNuevo { get; set; }
        DataTable dtGenero;

        public frmGenero()
        {
            InitializeComponent();
        }
        #region Mis procedimientos
        private void Limpiar_datos()
        {

        }
        private Boolean validar()
        {
            return true;
        }
        #endregion

        private void tbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(2);
            BloquearBtns(2);
            this.swNuevo = 0;
        }

        private void tbtnGrabar_Click(object sender, EventArgs e)
        {
            // Validar los campos antes de grabar
            if (ValidarDatos(ref txtCodigo) == false) return;
            if (ValidarDatos(ref txtNombre) == false) return;  // Aquí asumo que "txtNombre" es el campo para el nombre del género
            if (ValidarComboBox(ref cmbClasificacion) == false) return; // Validar ComboBox

            if (MessageBox.Show("¿Desea grabar?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Obtener valores de los controles
                    string vCodigo = this.txtCodigo.Text.Trim();  // Código del género
                    string vNombre = this.txtNombre.Text;                 // Nombre del género
                    string vClasificacion = this.cmbClasificacion.SelectedItem.ToString();  // Clasificación seleccionada

                    // Determinar procedimiento a ejecutar
                    string vProcedimiento = "sp_genero_insertar";  // Procedimiento para insertar
                    string msg = "Registro Grabado con éxito";

                    if (this.swNuevo == 1) // Modificar registro existente
                    {
                        vProcedimiento = "sp_genero_modificar"; // Procedimiento para modificar
                        msg = "Registro Modificado con éxito";
                    }

                    // Llamar al método para actualizar la información
                    if (Clpeliculas.ActualizarInformacion(vProcedimiento, vCodigo, vNombre, vClasificacion))
                    {
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Width = swAncho;
            CargarGeneros();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Width = 350;
        }

        #region Mis procedimientos

        private void LimpiarObj()
        {
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.cmbClasificacion.SelectedIndex = -1;  // Resetear ComboBox
        }

        private void BloquearDatos(int sw)
        {
            switch (sw)
            {
                case 1:  // Estado inicial
                    this.txtCodigo.ReadOnly = true;
                    this.txtNombre.ReadOnly = true;
                    this.cmbClasificacion.Enabled = false;
                    break;
                case 2:  // Nuevo
                    this.txtCodigo.ReadOnly = false;
                    this.txtNombre.ReadOnly = false;
                    this.cmbClasificacion.Enabled = true;
                    break;
                case 3:  // Consultar / Modificar
                    break;
            }
        }

        private void BloquearBtns(int sw)
        {
            switch (sw)
            {
                case 1:  // Estado inicial
                    this.tbtnSalir.Enabled = true;
                    this.tbtnNuevo.Enabled = true;
                    this.tbtnModificar.Enabled = false;
                    this.tbtnGrabar.Enabled = false;
                    this.tbtnEliminar.Enabled = false;
                    this.tbtnCancelar.Enabled = false;
                    this.btnConsultar.Enabled = true;
                    break;
                case 2:  // Nuevo
                    this.tbtnSalir.Enabled = false;
                    this.tbtnNuevo.Enabled = false;
                    this.tbtnModificar.Enabled = false;
                    this.tbtnGrabar.Enabled = true;
                    this.tbtnEliminar.Enabled = false;
                    this.tbtnCancelar.Enabled = true;
                    this.btnConsultar.Enabled = true;
                    break;
                case 3:  // Consultar
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

        private bool ValidarDatos(ref TextBox vObj)
        {
            if (vObj.TextLength == 0)
            {
                MessageBox.Show("No ha digitado información", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vObj.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarComboBox(ref ComboBox vObj)
        {
            if (vObj.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una clasificación", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vObj.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CargarGeneros()
        {
            try
            {
                // Consultar los géneros
                DataTable dtGeneros = Clgenero.ConsultarGeneros();  // Asegúrate de llamar correctamente

                if (dtGeneros != null && dtGeneros.Rows.Count > 0)
                {
                    // Asignar el DataTable como fuente de datos del DataGridView
                    dgvGenero.DataSource = dtGeneros;
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar los géneros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar géneros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Eventos del DataGridView
        private void dgvGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGenero.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                cmbClasificacion.SelectedItem = row.Cells["Clasificacion"].Value.ToString();
                swNuevo = 1; // Indicamos que se trata de una modificación
                BloquearDatos(3);
                BloquearBtns(3);
            }
        }
        #endregion

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            this.swAncho = 1000;
            LimpiarObj();
            BloquearDatos(1);
            BloquearBtns(1);
            CargarGeneros();

            // Llenar el ComboBox de Clasificación
            cmbClasificacion.Items.Add("+18");
            cmbClasificacion.Items.Add("+3");
            cmbClasificacion.Items.Add("+7");
            cmbClasificacion.Items.Add("+12");
            cmbClasificacion.Items.Add("+16");

            // Vincular eventos
            dgvGenero.CellClick += dgvGenero_CellClick;
        }

        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearBtns(1);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string vCodigo = txtCodigo.Text.Trim();

                    if (Clpeliculas.ActualizarInformacion("sp_genero_eliminar", vCodigo))
                    {
                        MessageBox.Show("Registro eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarObj();
                        CargarGeneros();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en el proceso de eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteGenero frm = new FrmReporteGenero();
            frm.ShowDialog();
        }
    }
}
