using CapaEntidad;
using CapaLogica;
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

namespace CapaPresentacion
{
    public partial class MantenedorComprobanteDeVenta : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool cambiosRealizados = false; // Indicador de cambios en dtgv
        public MantenedorComprobanteDeVenta()
        {
            InitializeComponent();
            // Suscribimos el evento de cambio de celda en dtvinsumo
            dtgvComprobante.CellValueChanged += dtgvComprobantesVentas_CellValueChanged;
            CargarComprobantes();
        }
        // Evento para detectar cambios en dtvinsumo
        private void dtgvComprobantesVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambiosRealizados = true;
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
            txtIDVenta.Clear();
            txtNombreClienteComprobante.Clear();
            txtDireccionComprobante.Clear();
            txtDniCliente.Clear();
            txtRucCliente.Clear();
            cbxTipoComprobante.SelectedIndex = -1; // Desmarcar selección
            dtpkComprobante.Value = DateTime.Today;
        }


        private void CargarComprobantes()
        {
            try
            {
                // Cargar comprobantes activos
                List<entComprobante> listaComprobantes = logComprobante.Instancia.ListarComprobantes(true);
                dtgvComprobante.DataSource = listaComprobantes;

                // Configuración de columnas
                dtgvComprobante.Columns["idComprobante"].HeaderText = "ID Comprobante";
                dtgvComprobante.Columns["idVenta"].HeaderText = "ID Venta";
                dtgvComprobante.Columns["nombreCliente"].HeaderText = "Cliente";
                dtgvComprobante.Columns["tipoComprobante"].HeaderText = "Tipo";
                dtgvComprobante.Columns["dni"].HeaderText = "DNI";
                dtgvComprobante.Columns["ruc"].HeaderText = "RUC";
                dtgvComprobante.Columns["fechaEmision"].HeaderText = "Fecha de Emisión";
                dtgvComprobante.Columns["estado"].HeaderText = "Estado";

                // Opcional: Mostrar "Activo" o "Anulado" en lugar de 1 o 0
                foreach (DataGridViewRow row in dtgvComprobante.Rows)
                {
                    row.Cells["estado"].Value = Convert.ToBoolean(row.Cells["estado"].Value) ? "Activo" : "Anulado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comprobantes: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarComprobante_Click(object sender, EventArgs e)
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

        private void btnCancelarComprobante_Click(object sender, EventArgs e)
        {
            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoComprobante_Click(object sender, EventArgs e)
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

        private void btnNuevoComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios estén llenos
                if (!int.TryParse(txtIDVenta.Text, out int idVenta) || idVenta <= 0)
                {
                    MessageBox.Show("Debe ingresar un ID de venta válido.");
                    return;
                }

                string tipoComprobante = cbxTipoComprobante.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(tipoComprobante))
                {
                    MessageBox.Show("Debe seleccionar un tipo de comprobante (Boleta o Factura).");
                    return;
                }

                // Validar DNI o RUC según el tipo de comprobante
                int? dni = null, ruc = null;
                if (tipoComprobante == "Boleta")
                {
                    if (!int.TryParse(txtDniCliente.Text, out int dniTemp) || dniTemp <= 0)
                    {
                        MessageBox.Show("Debe ingresar un DNI válido para la boleta.");
                        return;
                    }
                    dni = dniTemp;
                }
                else if (tipoComprobante == "Factura")
                {
                    if (!int.TryParse(txtRucCliente.Text, out int rucTemp) || rucTemp <= 0)
                    {
                        MessageBox.Show("Debe ingresar un RUC válido para la factura.");
                        return;
                    }
                    ruc = rucTemp;
                }

                // Crear la entidad comprobante con los datos del formulario
                entComprobante comprobante = new entComprobante
                {
                    idVenta = idVenta,
                    nombreCliente = txtNombreClienteComprobante.Text.Trim(),
                    direccion = txtDireccionComprobante.Text.Trim(),
                    tipoComprobante = tipoComprobante,
                    dni = dni,
                    ruc = ruc,
                    fechaEmision = dtpkComprobante.Value
                };

                // Llamar al método de la capa lógica para registrar el comprobante
                logComprobante.Instancia.RegistrarComprobante(comprobante);

                // Confirmar al usuario y limpiar los campos
                MessageBox.Show("Comprobante registrado correctamente.");
                LimpiarCampos();
                CargarComprobantes(); // Actualizar la lista de comprobantes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar comprobante: " + ex.Message);
            }
        }

        private void btnAnularComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID del comprobante sea válido
                if (!int.TryParse(txtIdComprobante.Text, out int idComprobante) || idComprobante <= 0)
                {
                    MessageBox.Show("Debe ingresar un ID de comprobante válido para anular.");
                    return;
                }

                // Llamar a la capa lógica para anular el comprobante
                logComprobante.Instancia.AnularComprobante(idComprobante);

                // Confirmar la operación al usuario
                MessageBox.Show($"El comprobante con ID {idComprobante} fue anulado correctamente.");

                // Recargar datos y limpiar campos
                CargarComprobantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular comprobante: " + ex.Message);
            }
        }

        private void btnComprobanteCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si ya existe una instancia de MantenedorCliente abierta
                Form clienteForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is MantenedorCliente);

                if (clienteForm != null)
                {
                    // Si ya existe, trae la ventana al frente
                    clienteForm.BringToFront();
                }
                else
                {
                    // Si no existe, crea una nueva instancia y ábrela
                    MantenedorCliente nuevoClienteForm = new MantenedorCliente();
                    nuevoClienteForm.Show();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al redireccionar al Mantenedor de Cliente: " + ex.Message);
            }
        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
