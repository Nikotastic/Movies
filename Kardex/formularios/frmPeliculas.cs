using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Kardex.clases;



namespace Kardex.formularios
{
    public partial class frmPeliculas : Form
    {
        int swAncho { get; set; }
        int swAnchoOri { get; set; }
        int swNuevo { get; set; }
        DataTable dtCalificaciones, dtPeliculas;

        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void tbtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Width = 490;
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Width = swAncho;
            Cargar_datos_datagrid();
        }

        #region Mis procedimientos

        private void LimpiarObj()
        {
            this.txtCodigo.Clear();
            this.txtTitulo.Clear();
            this.txtDuracion.Clear();
            this.dtpfecha.Value = DateTime.Now; // Establecer fecha actual
            this.cmbCalificacion.Text = "";
        }

        private void BloquearDatos(int sw)
        {
            switch (sw)
            {
                case 1:  // Estado inicial
                    this.txtCodigo.ReadOnly = true;
                    this.txtTitulo.ReadOnly = true;
                    this.txtDuracion.ReadOnly = true;
                    this.dtpfecha.Enabled = false;
                    this.cmbCalificacion.Enabled = false;
                    break;
                case 2:  // Nuevo
                    this.txtCodigo.ReadOnly = false;
                    this.txtTitulo.ReadOnly = false;
                    this.txtDuracion.ReadOnly = false;
                    this.dtpfecha.Enabled = true;
                    this.cmbCalificacion.Enabled = true;
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

        private bool ValidarCombo(ref ComboBox vObj)
        {
            if (vObj.Text.Length == 0)
            {
                MessageBox.Show("No ha Seleccionado la Información de la lista", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vObj.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Cargar_datos_datagrid()
        {
            string vCodigo = ""; // O cualquier valor que necesites
            SqlParameter paramCodigo = new SqlParameter("@p_codpeli", SqlDbType.NVarChar, 10);

            // Asignar DBNull.Value si vCodigo está vacío o nulo
            if (string.IsNullOrEmpty(vCodigo))
            {
                paramCodigo.Value = DBNull.Value; // Usar DBNull.Value si el código está vacío
            }
            else
            {
                paramCodigo.Value = vCodigo; // Asignar el valor de vCodigo si no está vacío
            }

            // Llamada al procedimiento con el parámetro adecuado
            DataTable dtPeliculas = Clpeliculas.MostrarRegistros("sp_pelicula_consultar", paramCodigo);

            if (dtPeliculas.Rows.Count > 0)
            {
                // Asegúrate de que dgvPeliculas está instanciado y tiene columnas
                if (this.dgvPeliculas != null && dtPeliculas.Columns.Count > 0)
                {
                    this.dgvPeliculas.DataSource = dtPeliculas;
                    this.dgvPeliculas.AutoResizeColumns();

                    // Verifica si la columna "Codigo" existe antes de modificar su estilo
                    if (this.dgvPeliculas.Columns.Contains("Codigo"))
                    {
                        this.dgvPeliculas.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    // Verifica si la columna "Titulo" existe antes de modificar su estilo
                    if (this.dgvPeliculas.Columns.Contains("Titulo"))
                    {
                        this.dgvPeliculas.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    // Verifica si la columna "Duracion" existe antes de modificar su estilo
                    if (this.dgvPeliculas.Columns.Contains("Duracion"))
                    {
                        this.dgvPeliculas.Columns["Duracion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    // Verifica si la columna "año" existe antes de modificar su estilo
                    if (this.dgvPeliculas.Columns.Contains("Año"))
                    {
                        this.dgvPeliculas.Columns["Año"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    // Verifica si la columna "Califiacion" existe antes de modificar su estilo
                    if (this.dgvPeliculas.Columns.Contains("Califiacion"))
                    {
                        this.dgvPeliculas.Columns["Califiacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }

                    // Formato de la columna "Duracion"
                    if (this.dgvPeliculas.Columns.Contains("Duracion"))
                    {
                        this.dgvPeliculas.Columns["Duracion"].DefaultCellStyle.Format = @"hh\:mm\:ss";
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
                // Mostrar mensaje si no hay datos
                MessageBox.Show("No se encontraron registros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Cargar_datos_calificaciones()
        {
            DataTable dtCalificaciones = new DataTable();
            dtCalificaciones.Columns.Add("Valor", typeof(string));

            // Agregar las calificaciones exactamente como se encuentran en la base de datos o en el DataGridView
            dtCalificaciones.Rows.Add("Muy Malo");
            dtCalificaciones.Rows.Add("Malo");
            dtCalificaciones.Rows.Add("Regular");
            dtCalificaciones.Rows.Add("Bueno");
            dtCalificaciones.Rows.Add("Excelente");

            cmbCalificacion.DataSource = dtCalificaciones;
            cmbCalificacion.DisplayMember = "Valor";
            cmbCalificacion.ValueMember = "Valor";
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string calificacionSeleccionada = cmbCalificacion.SelectedValue.ToString();
            MessageBox.Show($"Calificación seleccionada: {calificacionSeleccionada}");
        }


        #endregion
        private void tbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Width = swAncho;
            Cargar_datos_datagrid();
        }


        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearBtns(1);

        }


        private void ValidarDuracion()
        {
            TimeSpan duracion;
            if (!TimeSpan.TryParse(this.txtDuracion.Text, out duracion))
            {
                MessageBox.Show("Formato de duración incorrecto, debe ser HH:mm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbtnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearDatos(2);
            BloquearBtns(2);
            this.swNuevo = 0;
        }

        private void tbtnGrabar_Click_2(object sender, EventArgs e)
        {
            // Validar los campos antes de grabar
            if (!ValidarDatos(ref txtCodigo)) return;
            if (!ValidarDatos(ref txtTitulo)) return;
            if (!ValidarDatos(ref txtDuracion)) return;
            if (!ValidarCombo(ref cmbCalificacion)) return;

            // Validar ComboBox para director
            if (cmbDirectores.SelectedValue == null || cmbDirectores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un director.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método sin continuar
            }

            if (MessageBox.Show("Desea grabar los cambios?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Obtener valores de los controles
                    string vCodigo = txtCodigo.Text.Trim();
                    string vTitulo = txtTitulo.Text.Trim();
                    string vDuracion = txtDuracion.Text.Trim();
                    DateTime vañalanza = dtpfecha.Value;
                    string vCalificacion = cmbCalificacion.SelectedValue.ToString();
                    string vDirector = cmbDirectores.SelectedValue.ToString();

                    // Determinar procedimiento a ejecutar
                    string vProc;
                    string msg;

                    if (swNuevo == 1) // Si estamos modificando
                    {
                        vProc = "sp_pelicula_modificar";
                        msg = "Registro modificado con éxito";
                    }
                    else // Si estamos insertando
                    {
                        vProc = "sp_pelicula_insertar";
                        msg = "Registro insertado con éxito";
                    }

                    // Llamar al procedimiento almacenado
                    if (Clpeliculas.ActualizarInformacion(vProc, vCodigo, vTitulo, vDuracion, vañalanza.ToString("yyyy-MM-dd"), vCalificacion, vDirector))
                    {
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_datos_datagrid(); // Refrescar el DataGridView
                        LimpiarObj(); // Limpiar el formulario
                        BloquearBtns(1); // Bloquear botones al estado inicial
                        BloquearDatos(1);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo grabar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en el proceso de grabación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void tbtnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarObj();
            BloquearBtns(1);
        }

        private void tbtnEliminar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro Actual?", "Inventario 0.01", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    String vCodigo = this.txtCodigo.Text;
                    if (clases.Clpeliculas.ActualizarInformacion("sp_pelicula_eliminar", vCodigo) == true)
                    {
                        MessageBox.Show("Registro Eliminado con éxito", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Información No pudo ser Eliminada", "Inventario 0.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.swNuevo = 0;
                    LimpiarObj();
                    Cargar_datos_datagrid();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show("Error en el proceso de eliminación: " + excepcion.Message.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            this.swAncho = 1000;
            LimpiarObj();
            BloquearDatos(1);
            BloquearBtns(1);
            Cargar_datos_calificaciones(); // Ya tienes este método, sigue cargando las calificaciones
            Cargar_datos_datagrid(); // Este también es el método para cargar datos en el DataGridView

            // Deshabilitar el botón de eliminar inicialmente
            this.tbtnEliminar.Enabled = false;

            try
            {
                // Preparar el parámetro para la consulta
                SqlParameter paramDirector = new SqlParameter("@p_codirector", SqlDbType.NVarChar, 10)
                {
                    Value = DBNull.Value // Usar DBNull.Value si no se quiere un código específico
                };

                // Llamar al procedimiento almacenado con el parámetro
                DataTable dtDirectores = Clpeliculas.MostrarRegistros("sp_director_consultar", paramDirector);

                // Verificar que la consulta ha devuelto resultados
                if (dtDirectores.Rows.Count > 0)
                {
                    cmbDirectores.DataSource = dtDirectores;
                    cmbDirectores.DisplayMember = "Nombre";        // Campo que se muestra en el ComboBox
                    cmbDirectores.ValueMember = "Codigo";         // Valor asociado al ComboBox
                    cmbDirectores.SelectedIndex = -1;             // No seleccionar nada por defecto
                }
                else
                {
                    MessageBox.Show("No se encontraron directores.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar directores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDirector_Click(object sender, EventArgs e)
        {
            frmDirectores frm = new frmDirectores();
            frm.ShowDialog(); // Mostrar el formulario de directores

            // Recargar el ComboBox con los nuevos datos
            frmPeliculas_Load(sender, e);
        }

        private void tbtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReportePeli frm = new FrmReportePeli();
            frm.ShowDialog();
        }

        private void dgvPeliculas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que una fila válida está seleccionada
            {
                try
                {
                    // Asignar valores a los controles
                    txtCodigo.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;
                    txtTitulo.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Titulo"].Value?.ToString() ?? string.Empty;
                    txtDuracion.Text = dgvPeliculas.Rows[e.RowIndex].Cells["Duracion"].Value?.ToString() ?? string.Empty;
                    DateTime año;
                    if (DateTime.TryParse(dgvPeliculas.Rows[e.RowIndex].Cells["Lanzamiento"].Value?.ToString(), out año))
                    {
                        dtpfecha.Value = año;
                    }
                    else
                    {
                        dtpfecha.ResetText();  // Si no se puede parsear la fecha, reiniciar el valor
                    }
                    tbtnEliminar.Enabled = true;

                    // Aquí estamos obteniendo el valor de la calificación de la celda como texto
                    string calificacionText = dgvPeliculas.Rows[e.RowIndex].Cells["Calificacion"].Value?.ToString() ?? string.Empty;

                    // Verificar si el valor de calificación coincide con los valores del ComboBox
                    // Intentar asignar el valor al ComboBox
                    cmbCalificacion.SelectedValue = calificacionText;

                    // Si el valor no se encuentra en el ComboBox, mostrar advertencia
                    if (cmbCalificacion.SelectedValue == null)
                    {
                        MessageBox.Show("Valor de calificación no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Asignar el código del director (que también es texto) al ComboBox de directores
                    cmbDirectores.SelectedValue = dgvPeliculas.Rows[e.RowIndex].Cells["Codigo_director"].Value?.ToString() ?? string.Empty;

                    tbtnEliminar.Enabled = true;
                    swNuevo = 1; // Indicamos que se trata de una modificación
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}


