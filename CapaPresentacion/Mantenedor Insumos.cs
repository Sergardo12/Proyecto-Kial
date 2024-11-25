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
            CargarProductos(); // Cargar datos al iniciar el formulario
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
            txtUnidadMedidaInsumo.Clear();
            chkEstadoInsumo.Checked = true;
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumo insumo = new entInsumo
                {
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = txtUnidadMedidaInsumo.Text.Trim(),
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
                if (string.IsNullOrWhiteSpace(txtIdInsumo.Text))
                {
                    MessageBox.Show("Debe ingresar un ID válido.");
                    return;
                }

                entInsumo insumoModificado = new entInsumo
                {
                    idInsumo = int.Parse(txtIdInsumo.Text),
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = txtUnidadMedidaInsumo.Text.Trim(),
                    estadoInsumo = chkEstadoInsumo.Checked // Toma el valor del CheckBox
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

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
