using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Kardex.clases;

namespace Kardex.formularios
{
    public partial class frmDirectores : Form
    {

        int swAncho { get; set; }
        int swAnchoOri { get; set; }
        int swNuevo { get; set; }
        private DataTable dtDirectores;

        public frmDirectores()
        {
            InitializeComponent();
        }

        private void tbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(2); 
            BloquearBtns(2); 
            this.swNuevo = 0;
        }

        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(1);
            BloquearBtns(1);
        }
        private void consultar_Click(object sender, EventArgs e)
        {
            this.Width = swAncho;
            Cargar_datos_directores();
        }

        private void LimpiarObj()
        {
            this.txtCodigo.Clear();
            this.txtNombre.Clear();
            this.dtpfecha.ResetText(); 
        }
        private void frmDirectores_Load(object sender, EventArgs e)
        {
            this.swAncho = 990;
            LimpiarObj();
            BloquearDatos(1);
            BloquearBtns(1);
            Cargar_datos_directores();

            this.tbtnEliminar.Enabled = false;
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

        private void Cargar_datos_directores()
        {       
            string vCodigo = ""; 
            SqlParameter paramCodigo = new SqlParameter("@p_codirector", SqlDbType.NVarChar, 10);

            if (string.IsNullOrEmpty(vCodigo))
            {
                paramCodigo.Value = DBNull.Value; 
            }
            else
            {
                paramCodigo.Value = vCodigo; 
            }
            DataTable dtDirectores = Clpeliculas.MostrarRegistros("sp_director_consultar", paramCodigo);

            if (dtDirectores.Rows.Count > 0)
            { 
                if (this.dgvDirectores != null && dtDirectores.Columns.Count > 0)
                {
                    this.dgvDirectores.DataSource = dtDirectores;
                    this.dgvDirectores.AutoResizeColumns();
                    
                    if (this.dgvDirectores.Columns.Contains("Codigo"))
                    {
                        this.dgvDirectores.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                    
                    if (this.dgvDirectores.Columns.Contains("Nombre"))
                    {
                        this.dgvDirectores.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                    
                    if (this.dgvDirectores.Columns.Contains("fnacimiento"))
                    {
                        this.dgvDirectores.Columns["fnacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        this.dgvDirectores.Columns["fnacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de la fecha
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



        private void tbtnGrabar_Click(object sender, EventArgs e)
        {
         
            if (ValidarDatos(ref txtCodigo) == false) return;
            if (ValidarDatos(ref txtNombre) == false) return;
            if (ValidarDatos(ref dtpfecha) == false) return;


           
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

                    
                    string vProcedimiento = "sp_director_insertar";
                    string msg = "Registro grabado con éxito";

                    if (this.swNuevo == 1) 
                    {
                        vProcedimiento = "sp_director_modificar";
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

        private bool ValidarDatos(ref DateTimePicker dtpfecha)
        {
            // Verifica si la fecha está vacía
            if (dtpfecha.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
 
            if (dtpfecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser en el futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void tbtnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearBtns(1);
        }

        internal static bool ActualizarInformacion(string vProcedimiento, string vCodigo, string vNombre, DateTime vfnacimiento)
        {
            try
            {
                // Crear el comando para ejecutar el procedimiento almacenado.
                SqlCommand cmd = new SqlCommand(vProcedimiento)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Agregar los parámetros al comando.
                cmd.Parameters.AddWithValue("@Codigo", vCodigo);  // Asigna el código del director
                cmd.Parameters.AddWithValue("@Nombre", vNombre);  // Asigna el nombre del director
                cmd.Parameters.AddWithValue("@fnacimiento", vfnacimiento.ToString("dd-MM-yyyy"));


                // Ejecutar el comando, que devolverá el número de filas afectadas.
                int rowsAffected = cmd.ExecuteNonQuery();

                // Si se ha afectado alguna fila, se devuelve true, indicando que la operación fue exitosa.
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: si ocurre un error, muestra el mensaje.
                MessageBox.Show("Error al ejecutar el procedimiento: " + ex.Message);
                return false;
            }
        }

        private void dgvDirectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha hecho clic en una fila válida (no en la cabecera)
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Asignar valores de las celdas de la fila seleccionada a los controles del formulario
                    txtCodigo.Text = dgvDirectores.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;
                    txtNombre.Text = dgvDirectores.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? string.Empty;

                    DateTime fnacimiento;
                    if (DateTime.TryParse(dgvDirectores.Rows[e.RowIndex].Cells["Fecha_nacimiento"].Value?.ToString(), out fnacimiento))
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
                    // Manejar excepciones, por ejemplo si alguna celda tiene un valor inesperado
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Width = 330;
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro Actual?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    String vCodigo = this.txtCodigo.Text;
                    if (clases.Clpeliculas.ActualizarInformacion("sp_director_eliminar", vCodigo) == true)
                    {
                        MessageBox.Show("Registro Eliminado con éxito", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Información No pudo ser Eliminada", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.swNuevo = 0;
                    LimpiarObj();
                    Cargar_datos_directores();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show("Error en el proceso de grabación" + excepcion.Message.ToString(), "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void tbtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteDirec frm = new FrmReporteDirec();
            frm.ShowDialog();
        }
    }
}
