using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Kardex.clases;

namespace Kardex.formularios
{
    public partial class FrmActores : Form
    {

        int swAncho { get; set; }
        int swAnchoOri { get; set; }
        int swNuevo { get; set; }
        private DataTable dtActores;

        public FrmActores()
        {
            InitializeComponent();
        }

        private void tbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Width = 350;
        }
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Width = 830;
            Cargar_datos_actores();
        }
        private void FormActores_Load(object sender, EventArgs e)
        {
            this.swAncho = 350;
            LimpiarObj();
            BloquearDatos(1);
            BloquearBtns(1);
            CargarActores();
        }

        private void LimpiarObj()
        {
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.dtpfecha.ResetText(); 
        }

        private void tbtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(2);
            BloquearBtns(2);
            this.swNuevo = 0; 
        }
        private void BloquearDatos(int sw)
        {
            switch (sw)
            {
                case 1:  // Estado inicial
                    this.txtCodigo.ReadOnly = true;
                    this.txtNombre.ReadOnly = true;
                    this.dtpfecha.Enabled = false;
                    break;
                case 2:  // Nuevo
                    this.txtCodigo.ReadOnly = false;
                    this.txtNombre.ReadOnly = false;
                    this.dtpfecha.Enabled = true;
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
        private bool ValidarDatos(ref DateTimePicker dtpfecha)
        {
            // Verifica si la fecha está vacía
            if (dtpfecha.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Validacion de fecha no se pase de la fecha actual
            if (dtpfecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser en el futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void CargarActores()
        {
            try
            {
                DataTable dtActores = Clactores.ConsultarActores();
                dgvActores.DataSource = dtActores;
                dgvActores.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los actores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbtnGrabar_Click(object sender, EventArgs e)
        {
            // Validar que no esten vacios
            if (ValidarDatos(ref txtCodigo) == false) return;
            if (ValidarDatos(ref txtNombre) == false) return;
            if (ValidarDatos(ref dtpfecha) == false) return;



            // Validar que el campo Fecha de Nacimiento esté completo
            if (dtpfecha.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            if (MessageBox.Show("¿Desea grabar?", "Directores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    
                    string vCodigo = this.txtCodigo.Text.Trim();
                    string vNombre = this.txtNombre.Text.Trim();
                    DateTime vfnacimiento = this.dtpfecha.Value;

                    
                    string vProcedimiento = "sp_actor_insertar";
                    string msg = "Registro grabado con éxito";

                    if (this.swNuevo == 1) 
                    {
                        vProcedimiento = "sp_actor_modificar";
                        msg = "Registro modificado con éxito";
                    }

                    
                    if (Clpeliculas.ActualizarInformacion(vProcedimiento, vCodigo, vNombre, vfnacimiento.ToString("dd-MM-yyyy")))
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

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, ingrese el código del actor a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool exito = Clactores.EliminarActor(codigo);
                if (exito)
                {
                    MessageBox.Show("Actor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarActores();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el actor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el actor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(1); 
            BloquearBtns(1); 
        }

        private void Cargar_datos_actores()
        {
            
            string vCodigo = ""; 
            SqlParameter paramCodigo = new SqlParameter("@p_codactor", SqlDbType.NVarChar, 10);

            if (string.IsNullOrEmpty(vCodigo))
            {
                paramCodigo.Value = DBNull.Value; // Usar DBNull.Value si el código está vacío
            }
            else
            {
                paramCodigo.Value = vCodigo; 
            }

           
            DataTable dtActores = Clpeliculas.MostrarRegistros("sp_actor_consultar", paramCodigo);

            if (dtActores.Rows.Count > 0)
            {
                
                if (this.dgvActores != null && dtActores.Columns.Count > 0)
                {
                    this.dgvActores.DataSource = dtActores;
                    this.dgvActores.AutoResizeColumns();

                    
                    if (this.dgvActores.Columns.Contains("Codigo"))
                    {
                        this.dgvActores.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    
                    if (this.dgvActores.Columns.Contains("Nombre"))
                    {
                        this.dgvActores.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    
                    if (this.dgvActores.Columns.Contains("fnacimiento"))
                    {
                        this.dgvActores.Columns["fnacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        this.dgvActores.Columns["fnacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de la fecha
                    }

                    this.swNuevo = 1; 
                }
                else
                {
                    MessageBox.Show("Error al cargar las columnas en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron registros de directores.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvActores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha hecho clic en una fila válida (no en la cabecera)
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Asignar valores de las celdas de la fila seleccionada a los controles del formulario
                    txtCodigo.Text = dgvActores.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;
                    txtNombre.Text = dgvActores.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? string.Empty;

                    DateTime fnacimiento;
                    if (DateTime.TryParse(dgvActores.Rows[e.RowIndex].Cells["Fecha_nacimiento"].Value?.ToString(), out fnacimiento))
                    {
                        dtpfecha.Value = fnacimiento;
                    }
                    else
                    {
                        dtpfecha.ResetText();  
                    }
                    tbtnEliminar.Enabled = true;
                    swNuevo = 1; // Indicamos que se trata de una modificación
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteActoress frm = new FrmReporteActoress();
            frm.ShowDialog();
        }
    }
}
