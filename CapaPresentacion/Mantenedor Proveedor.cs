using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class MantenedorProveedor : Form
    {
        private bool cambiosRealizados = false; // Indicador de cambios en dtgv
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MantenedorProveedor()
        {
            InitializeComponent();
            // Suscribimos el evento de cambio de celda en dtgv
            dtgvProveedores.CellValueChanged += dtgvProveedores_CellValueChanged;
            ListarProveedores();
        }
        // Evento para detectar cambios en dtvinsumo
        private void dtgvProveedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambiosRealizados = true;
        }
        private void ListarProveedores()
        {
            dtgvProveedores.DataSource = logProveedor.Instancia.ListarProveedores();
        }


        // Método auxiliar para abrir una única instancia de un formulario
        private void AbrirFormularioUnico(Type tipoFormulario)
        {
            // Recorre los formularios abiertos y verifica si ya existe el tipo de formulario deseado
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoFormulario)
                {
                    form.BringToFront(); // Lleva el formulario existente al frente
                    return;
                }
            }

            // Si no se encuentra el formulario, crea una nueva instancia
            Form nuevoFormulario = (Form)Activator.CreateInstance(tipoFormulario);
            nuevoFormulario.Show();
        }
        private void LimpiarCampos()
        {
            txtNombreProveedor.Text = "";
            txtRUCProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            dtpProveedor.Value = DateTime.Today;
            cbxEstadoProveedor.Checked = false;
        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcbxFondoMadera_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarProveedor_Click(object sender, EventArgs e)
        {
            if (!cambiosRealizados)
            {
                // Si no hay cambios, regresa a la vista Main
                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
            }
            else
            {
                MessageBox.Show("No puedes regresar sin guardar o cancelar los cambios.");
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoProveedor_Click(object sender, EventArgs e)
        {
            if (cambiosRealizados)
            {
                // Si hay cambios, marca como listo y vuelve a Main
                MessageBox.Show("Cambios registrados exitosamente.");
                cambiosRealizados = false; // Restablecemos cambiosRealizados

                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
            }
            else
            {
                MessageBox.Show("No hay cambios para registrar.");
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor
                {
                    nombreProveedor = txtNombreProveedor.Text,
                    rucProveedor = int.Parse(txtRUCProveedor.Text),
                    direccionProveedor = txtDireccionProveedor.Text,
                    fecRegProveedor = dtpProveedor.Value,
                    estProveedor = cbxEstadoProveedor.Checked
                };

                logProveedor.Instancia.InsertarProveedor(proveedor);
                MessageBox.Show("Proveedor agregado correctamente.");
                ListarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor
                {
                    idProveedor = int.Parse(txtIDProveedor.Text),
                    nombreProveedor = txtNombreProveedor.Text,
                    rucProveedor = int.Parse(txtRUCProveedor.Text),
                    direccionProveedor = txtDireccionProveedor.Text,
                    fecRegProveedor = dtpProveedor.Value,
                    estProveedor = cbxEstadoProveedor.Checked
                };

                logProveedor.Instancia.EditarProveedor(proveedor);
                MessageBox.Show("Proveedor editado correctamente.");
                ListarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeshabilitarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo ID no esté vacío y que sea un número válido
                if (int.TryParse(txtIDProveedor.Text, out int idProveedor))
                {
                    // Actualizar el estado a "false" (desmarcar el checkbox)
                    cbxEstadoProveedor.Checked = false;

                    // Llamar a la capa lógica para deshabilitar el proveedor
                    logProveedor.Instancia.DeshabilitarProveedor(idProveedor);

                    MessageBox.Show("Proveedor deshabilitado correctamente.");
                    ListarProveedores(); // Actualizar la lista en el DataGridView
                    LimpiarCampos(); // Limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de proveedor válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar el proveedor: " + ex.Message);
            }
        }
    }
}
