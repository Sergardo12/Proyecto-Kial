using CapaEntidad;
using CapaLogica;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Mantenedor_Insumos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Mantenedor_Insumos()
        {
            InitializeComponent();
            chkEstadoInsumo.Checked = true; // Estado activo por defecto
            InicializarComboBox(); // Configurar ComboBox
            CargarProductos(); // Cargar datos al iniciar el formulario
            txtIdInsumo.ReadOnly = true; // Deshabilitar ID por defecto
        }

        private void InicializarComboBox()
        {
            // Evitar duplicados asegurándonos de limpiar primero
            cmbMedida.Items.Clear();

            // Agregar opciones al ComboBox una sola vez
            cmbMedida.Items.Add("Unitario");
            cmbMedida.Items.Add("Kg");
            cmbMedida.Items.Add("Lt");

            cmbMedida.DropDownStyle = ComboBoxStyle.DropDownList; // Solo selección
            cmbMedida.SelectedIndex = 0; // Selección por defecto
        }

        private void CargarProductos()
        {
            try
            {
                dtgvInsumo.DataSource = logInsumo.Instancia.ListarInsumos();
                dtgvInsumo.Columns["estadoInsumo"].Visible = true; // Mostrar u ocultar columna
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar insumos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdInsumo.Clear();
            txtNombreInsumo.Clear();
            cmbMedida.SelectedIndex = 0; // Restablece la selección por defecto
            chkEstadoInsumo.Checked = true;
            txtIdInsumo.ReadOnly = true; // Deshabilitar nuevamente después de la operación
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumo insumo = new entInsumo
                {
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = cmbMedida.SelectedItem.ToString(), // Obtiene el valor seleccionado del ComboBox
                    estadoInsumo = chkEstadoInsumo.Checked // Toma el valor del CheckBox
                };

                logInsumo.Instancia.InsertarInsumo(insumo);
                MessageBox.Show("Insumo agregado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar insumo: " + ex.Message);
            }
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                // Habilitar el ID temporalmente para capturarlo
                txtIdInsumo.ReadOnly = false;

                if (string.IsNullOrWhiteSpace(txtIdInsumo.Text))
                {
                    MessageBox.Show("Debe ingresar un ID válido.");
                    return;
                }

                entInsumo insumoModificado = new entInsumo
                {
                    idInsumo = int.Parse(txtIdInsumo.Text), // ID del insumo
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = cmbMedida.SelectedItem.ToString(), // Valor del ComboBox
                    estadoInsumo = chkEstadoInsumo.Checked // Valor del CheckBox
                };

                logInsumo.Instancia.ModificarInsumo(insumoModificado);
                MessageBox.Show("Insumo modificado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar insumo: " + ex.Message);
            }
        }

        private void btnInhabilitarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                // Habilitar el ID temporalmente para capturarlo
                txtIdInsumo.ReadOnly = false;

                if (string.IsNullOrWhiteSpace(txtIdInsumo.Text))
                {
                    MessageBox.Show("Debe ingresar un ID válido.");
                    return;
                }

                int idInsumo = int.Parse(txtIdInsumo.Text);
                logInsumo.Instancia.InhabilitarInsumo(idInsumo);
                MessageBox.Show("Insumo inhabilitado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inhabilitar insumo: " + ex.Message);
            }
        }

        private void dtgvInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = dtgvInsumo.Rows[e.RowIndex];

                    txtIdInsumo.Text = filaSeleccionada.Cells["idInsumo"].Value.ToString();
                    txtNombreInsumo.Text = filaSeleccionada.Cells["nombreInsumo"].Value.ToString();
                    cmbMedida.SelectedItem = filaSeleccionada.Cells["medidaInsumo"].Value.ToString();
                    chkEstadoInsumo.Checked = Convert.ToBoolean(filaSeleccionada.Cells["estadoInsumo"].Value);

                    txtIdInsumo.ReadOnly = true; // ID deshabilitado después de seleccionar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar insumo: " + ex.Message);
            }
        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
