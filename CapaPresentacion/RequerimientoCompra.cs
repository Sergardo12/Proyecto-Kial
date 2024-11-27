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
    public partial class RequerimientoCompra : Form
    {
        private bool cambiosRealizados = false; // Indicador de cambios en dtvinsumo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public RequerimientoCompra()
        {
            InitializeComponent();
            // Suscribimos el evento de cambio de celda en dtvinsumo
            dtgvRequerimientoInsumo.CellValueChanged += dtgvRequerimientoInsumo_CellValueChanged;
            List<entInsumo> insumos = logInsumo.Instancia.ListarInsumos();

            // Limpiar el ComboBox antes de agregar los nuevos items
            cbxnombreRequerimientoInsumo.Items.Clear();
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

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresarRequrimientoCompra_Click(object sender, EventArgs e)
        {
                // Si no hay cambios, regresa a la vista Main
                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
            
        }

        private void btnCancelarRequerimientoCompra_Click(object sender, EventArgs e)
        {
            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoRequerimientoCompra_Click(object sender, EventArgs e)
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


        // Evento para detectar cambios en dtvinsumo
        private void dtgvRequerimientoInsumo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambiosRealizados = true;
        }

        private void btnAgregarRequerimientoInsumo_Click(object sender, EventArgs e)
        {
            // Verificar que el ComboBox y el TextBox no estén vacíos
            if (cbxnombreRequerimientoInsumo.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtcantidadRequerimientoInsumo.Text))
            {
                // Verificar que el ComboBox tenga un valor seleccionado
                string nombreInsumo = cbxnombreRequerimientoInsumo.SelectedItem?.ToString();
                if (nombreInsumo == null)
                {
                    MessageBox.Show("Por favor, selecciona un insumo válido.");
                    return;
                }

                int cantidadIngresada;

                // Validar que la cantidad ingresada sea un número válido
                if (int.TryParse(txtcantidadRequerimientoInsumo.Text, out cantidadIngresada))

                {
                    // Obtener el estado del requerimiento desde un CheckBox (o RadioButton)
                    bool estadoRequerimientoInsumo = chbxestadoRequerimientoInsumo.Checked;

                    // Crear el objeto de requerimiento con la cantidad y el nombre
                    entRequerimientoInsumo requerimiento = new entRequerimientoInsumo
                    {
                        Insumo = new entInsumo
                        {
                            nombreInsumo = nombreInsumo,
                            cantidadInsumo = cantidadIngresada,
                            // Otros datos si los necesitas
                        },
                        estadoRequerimientoInsumo = true
                    };

                    try
                    {
                        // Llamar a la capa lógica para insertar el requerimiento
                        logRequerimientoInsumo.Instancia.InsertarRequerimiento(requerimiento);

                        // Agregar al DataGridView
                        dtgvRequerimientoInsumo.Rows.Add(nombreInsumo, cantidadIngresada, estadoRequerimientoInsumo);

                        // Limpiar los campos después de agregar
                        LimpiarCampos();

                        // Confirmar al usuario que el requerimiento fue agregado
                        MessageBox.Show("El requerimiento de insumo se ha agregado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción que ocurra al insertar
                        MessageBox.Show($"Error al agregar el requerimiento: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un insumo y una cantidad.");
            }
        }

        private void LimpiarCampos()
        {
            cbxnombreRequerimientoInsumo.SelectedItem = -1;
            txtcantidadRequerimientoInsumo.Text = string.Empty;
            chbxestadoRequerimientoInsumo.Checked = false;
        }

        private void RequerimientoCompra_Load(object sender, EventArgs e)
        {
            // Verifica si las columnas ya están definidas
            if (dtgvRequerimientoInsumo.Columns.Count == 0)
            {
             
                dtgvRequerimientoInsumo.Columns.Add("NombreInsumo", "Nombre del Insumo");
                dtgvRequerimientoInsumo.Columns.Add("Cantidad", "Cantidad");
                dtgvRequerimientoInsumo.Columns.Add("Estado", "Estado");
                dtgvRequerimientoInsumo.Columns.Add("IdRequermiento", "IdRequermiento");
            }

            // Obtener la lista de insumos desde la capa lógica
            List<entInsumo> insumos = logInsumo.Instancia.ListarInsumos();

            // Limpiar el ComboBox antes de agregar los nuevos items
            cbxnombreRequerimientoInsumo.Items.Clear();

            // Llenar el ComboBox con los nombres de los insumos
            foreach (var insumo in insumos)
            {
                cbxnombreRequerimientoInsumo.Items.Add(insumo.nombreInsumo);
            }

            // Establecer el primer elemento como seleccionado (opcional)
            if (cbxnombreRequerimientoInsumo.Items.Count > 0)
            {
                cbxnombreRequerimientoInsumo.SelectedIndex = 0;
            }
            CargarCompras();


        }
       

        private void btngenerarIdRequermientoInsumo_Click(object sender, EventArgs e)
        {
            // Lista de requerimientos seleccionados
            List<int> requerimientosSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dtgvRequerimientoInsumo.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IdRequermiento"].Value))  // Verificar si la fila está seleccionada
                {
                    // Agregar los ids de los requerimientos seleccionados
                    int idRequerimientoInsumo = Convert.ToInt32(row.Cells["idRequerimientoInsumo"].Value);
                    requerimientosSeleccionados.Add(idRequerimientoInsumo);
                }
            }

            // Llamar a la capa lógica para generar y actualizar los IDs provisionales
            string nuevoId = logRequerimientoInsumo.Instancia.GenerarYActualizarIds(requerimientosSeleccionados);

            // Mostrar el ID generado en el TextBox
            txtidRequerimientoInsumo.Text = nuevoId; ;
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                entCompraInsumos compra = new entCompraInsumos
                {
                    IdCompraInsumos = int.Parse(txtidCompraInsumos.Text),
                    ID_ReqCCompra = txtidReqCompraInsumos.Text, // Capturando el nuevo campo
                    IdProveedorCompra = int.Parse(txtidProveedorCompraInsumos.Text),
                    NombreProveedor = txtNombreProveedor.Text,
                    Administrador = txtAdministrador.Text,
                    FechaCompraInsumo = dtpFechaCompra.Value,
                    Monto = float.Parse(txtMonto.Text)
                };

                logCompraInsumos.Instancia.InsertaCommpraInsums(compra);

                MessageBox.Show("Compra registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();

                // Recargar los datos en el DataGridView
                CargarCompras();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCompras()
        {
            try
            {
                // Obtener la lista de compras desde la capa lógica
                List<entCompraInsumos> listaCompras = logCompraInsumos.Instancia.ListarCompraInsumos();

                // Asignar la lista al DataGridView
                dgvCompraInsumos.DataSource = listaCompras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el texto del ID es un número
                int idProveedor = int.Parse(txtidProveedorCompraInsumos.Text);

                // Llamar al método de la capa lógica
                string nombreProveedor = logCompraInsumos.Instancia.ObtenerNombreProveedor(idProveedor);

                // Mostrar el nombre en el TextBox correspondiente o dar aviso si no se encuentra
                if (!string.IsNullOrEmpty(nombreProveedor))
                {
                    txtNombreProveedor.Text = nombreProveedor;
                }
                else
                {
                    MessageBox.Show("No se encontró un proveedor con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreProveedor.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
    
}
