using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaLogica;
using System.Data;


namespace CapaPresentacion
{
    public partial class MantenedorCliente : Form
    {
        private bool cambiosRealizados = false; // Indicador de cambios en dtgvClientes

        public MantenedorCliente()
        {
            InitializeComponent();
            dtgvClientes.CellValueChanged += dtgvClientes_CellValueChanged; // Detectar cambios en celdas
            CargarClientes(); // Cargar datos al iniciar el formulario
            txtIdCliente.Enabled = false;
        }
        // Método para cargar la lista de clientes en el DataGridView
        private void CargarClientes()
        {
            try
            {
                List<entCliente> listaClientes = logCliente.Instancia.ListarCliente();
                dtgvClientes.DataSource = listaClientes;

                // Configuración de columnas
                dtgvClientes.Columns["idCliente"].HeaderText = "ID Cliente";
                dtgvClientes.Columns["razonSocial"].HeaderText = "Nombre del Cliente";
                dtgvClientes.Columns["dni"].HeaderText = "DNI";
                dtgvClientes.Columns["numero"].HeaderText = "Número";
                dtgvClientes.Columns["correo"].HeaderText = "Correo Electrónico";
                dtgvClientes.Columns["fecRegCliente"].HeaderText = "Fecha de Registro";
                dtgvClientes.Columns["estCliente"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Evento para detectar cambios en dtvinsumo
        private void dtgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txtBox)
                {
                    txtBox.Clear();
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is DateTimePicker datePicker)
                {
                    datePicker.Value = DateTime.Today;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
                // Si no hay cambios, regresa a la vista Main
                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoCliente_Click(object sender, EventArgs e)
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
                {
                    MessageBox.Show("El nombre del cliente no puede estar vacío.");
                    return;
                }

                if (!int.TryParse(txtDniCliente.Text, out int dni) || dni <= 0)
                {
                    MessageBox.Show("El DNI debe ser un número válido y positivo.");
                    return;
                }

                if (!int.TryParse(txtNumeroCliente.Text, out int numero) || numero <= 0)
                {
                    MessageBox.Show("El número de contacto debe ser un valor numérico y positivo.");
                    return;
                }

                entCliente nuevoCliente = new entCliente
                {
                    razonSocial = txtNombreCliente.Text.Trim(),
                    dni = dni,
                    numero = numero,
                    correo = txtCorreoCliente.Text.Trim(),
                    fecRegCliente = dtpkFechaCliente.Value,
                    estCliente = chkEstadoCliente.Checked
                };

                logCliente.Instancia.InsertaCliente(nuevoCliente);
                MessageBox.Show("Cliente agregado correctamente.");
                CargarClientes();
                LimpiarCampos();
                limpiarCampos2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCliente.Enabled = true;
                if (!int.TryParse(txtIdCliente.Text, out int idCliente))
                {
                    MessageBox.Show("Debe ingresar un ID válido para editar.");
                    return;
                }

                if (!int.TryParse(txtDniCliente.Text, out int dni) || dni <= 0)
                {
                    MessageBox.Show("El DNI debe ser un número válido.");
                    return;
                }

                if (!int.TryParse(txtNumeroCliente.Text, out int numero) || numero <= 0)
                {
                    MessageBox.Show("El Número debe ser un valor numérico.");
                    return;
                }

                entCliente clienteModificado = new entCliente
                {
                    idCliente = idCliente,
                    razonSocial = txtNombreCliente.Text.Trim(),
                    dni = dni,
                    numero = numero,
                    correo = txtCorreoCliente.Text.Trim(),
                    fecRegCliente = dtpkFechaCliente.Value,
                    estCliente = chkEstadoCliente.Checked
                };

                logCliente.Instancia.EditaCliente(clienteModificado);
                MessageBox.Show("Cliente modificado correctamente.");
                CargarClientes();
                //LimpiarCampos();
                limpiarCampos2();
                txtIdCliente.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message);
            }
        }


        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCliente.Text, out int idCliente))
                {
                    txtIdCliente.Enabled = true;
                    MessageBox.Show("Debe ingresar un ID válido para inhabilitar.");
                    return;
                }

                logCliente.Instancia.DeshabilitarCliente(idCliente);
                MessageBox.Show("Cliente inhabilitado correctamente.");
                CargarClientes();
                //LimpiarCampos();
                limpiarCampos2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inhabilitar cliente: " + ex.Message);
            }
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvClientes.ReadOnly = true;
            dtgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvClientes.AllowUserToAddRows = false;
        }

        private void txtDniCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = false;
        }

        private void limpiarCampos2()
        {
            txtNombreCliente.Text = string.Empty;
            txtDniCliente.Text = string.Empty;
            txtCorreoCliente.Text = string.Empty;
            txtNumeroCliente.Text = string.Empty;
            chkEstadoCliente.Checked = false;
            txtIdCliente.Text = string.Empty;
         
        }
    }
}
