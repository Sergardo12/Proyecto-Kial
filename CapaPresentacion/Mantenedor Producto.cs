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
    public partial class Mantenedor_Producto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Mantenedor_Producto()
        {
            InitializeComponent();
            chkEstadoProducto.Checked = true; // Estado activo por defecto
            CargarProductos();       // Cargar datos al iniciar el formulario
        }

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
        private void CargarProductos()
        {
            try
            {
                dtgvProducto.DataSource = logProducto.Instancia.ListarProductos();
                dtgvProducto.Columns["estadoProducto"].Visible = true; // Ocultar columna si no es necesaria
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            chkEstadoProducto.Checked = true;
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            // Si no hay cambios, regresa a la vista Main
            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);
                logProducto.Instancia.InhabilitarProducto(idProducto);
                MessageBox.Show("Producto inhabilitado correctamente.");
                CargarProductos();
                LimpiarCampos(); // Limpia los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inhabilitar producto: " + ex.Message);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto productoModificado = new entProducto
                {
                    idProducto = int.Parse(txtIdProducto.Text),
                    nombreProducto = txtNombreProducto.Text.Trim(),
                    precioProducto = decimal.Parse(txtPrecioProducto.Text)
                };

                logProducto.Instancia.ModificarProducto(productoModificado);
                MessageBox.Show("Producto modificado correctamente.");
                CargarProductos();
                LimpiarCampos(); // Limpia los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto producto = new entProducto
                {
                    nombreProducto = txtNombreProducto.Text.Trim(),
                    precioProducto = decimal.Parse(txtPrecioProducto.Text.Trim()),
                    estadoProducto = true // Estado activo por defecto
                };

                logProducto.Instancia.InsertarProducto(producto);
                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos(); // Refresca la lista
                LimpiarCampos(); // Limpia los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnListoCliente_Click(object sender, EventArgs e)
        {
                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
        }
        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvProducto.ReadOnly = true; // Solo lectura para evitar modificaciones directas
        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
