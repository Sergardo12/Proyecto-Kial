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
    public partial class Orden_Venta : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private List<entOrden> detallesOrden = new List<entOrden>();
        public Orden_Venta()
        {
            InitializeComponent();
            CargarOrdenes(); // Llama al método para cargar datos al abrir el formulario
            CargarProductosEnComboBox();
        }
        private void CargarOrdenes()
        {
          
        }


        private void pcbxFondoMadera_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is entProducto producto)
            {
                txtPrecioUnitario.Text = producto.precio.ToString("F2");
            }
        }

        private void btnCalcularOrden_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) &&
                    decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                decimal subtotal = cantidad * precioUnitario;
                txtSubtotal.Text = subtotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la cantidad y el precio unitario.", "Error de Formato");
            }
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrden detalle = new entDetalleOrden
                {
                    idOrden = txtCodigoOrden.Text,
                    idProducto = ((entProducto)cmbProducto.SelectedItem).idProducto,
                    producto = cmbProducto.Text,
                    cantidad = int.Parse(txtCantidad.Text),
                    precioUnitario = decimal.Parse(txtPrecioUnitario.Text),
                    subtotal = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioUnitario.Text),
                    estado = "No Elegido"
                };

                logOrden.Instancia.InsertarDetalle(detalle);
                dtgvOrden.DataSource = logOrden.Instancia.ListarDetalles(txtCodigoOrden.Text);

                MessageBox.Show("Detalle agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar detalle: " + ex.Message);
            }
        }
        private decimal CalcularTotalOrden()
        {
            decimal total = 0;

            // Itera sobre las filas del DataGridView
            foreach (DataGridViewRow row in dtgvOrden.Rows)
            {
                // Asegúrate de que la celda de "subtotal" tenga un valor válido
                if (row.Cells["subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["subtotal"].Value.ToString(), out decimal subtotal))
                {
                    total += subtotal;
                }
            }

            return total;
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            if (dtgvOrden.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtenemos el detalle seleccionado
                    entDetalleOrden detalleSeleccionado = (entDetalleOrden)dtgvOrden.SelectedRows[0].DataBoundItem;

                    // Actualizamos los valores con los campos del formulario
                    detalleSeleccionado.cantidad = int.Parse(txtCantidad.Text);
                    detalleSeleccionado.subtotal = detalleSeleccionado.cantidad * decimal.Parse(txtPrecioUnitario.Text);

                    // Modificamos el detalle en la BD
                    logOrden.Instancia.ModificarDetalle(detalleSeleccionado);

                    // Recargamos el DataGridView
                    dtgvOrden.DataSource = logOrden.Instancia.ListarDetalles(txtCodigoOrden.Text);
                    MessageBox.Show("Detalle modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar detalle: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un detalle para modificar.");
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarProductosEnComboBox()
        {
            try
            {
                List<entProducto> productos = logProducto.Instancia.ObtenerProductos();
                cmbProducto.DataSource = productos;
                cmbProducto.DisplayMember = "nombre"; // Muestra el nombre en el ComboBox
                cmbProducto.ValueMember = "idProducto"; // Usa el ID como valor del producto
                cmbProducto.SelectedIndex = -1; // Deja el ComboBox sin seleccionar al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void dtgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvOrden.AutoGenerateColumns = true; // Habilita la generación automática de columnas

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerarId_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoId = logOrden.Instancia.GenerarIdOrden();
                txtCodigoOrden.Text = nuevoId;

                // Actualizar estado de todos los detalles asociados
                foreach (DataGridViewRow row in dtgvOrden.Rows)
                {
                    int idDetalle = Convert.ToInt32(row.Cells["idDetalleOrden"].Value);
                    logOrden.Instancia.ActualizarEstado(idDetalle);
                }

                MessageBox.Show("ID de Orden generado y detalles actualizados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ID de Orden: " + ex.Message);
            }
        }

        private void BtnDeshabilitarOrden_Click(object sender, EventArgs e)
        {
            if (dtgvOrden.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtenemos el idDetalleOrden seleccionado
                    int idDetalleOrden = ((entDetalleOrden)dtgvOrden.SelectedRows[0].DataBoundItem).idDetalleOrden;

                    // Inhabilitamos el detalle en la BD
                    logOrden.Instancia.InhabilitarDetalle(idDetalleOrden);

                    // Recargamos el DataGridView
                    dtgvOrden.DataSource = logOrden.Instancia.ListarDetalles(txtCodigoOrden.Text);
                    MessageBox.Show("Detalle inhabilitado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deshabilitar detalle: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un detalle para deshabilitar.");
            }
        }

        private void Orden_Venta_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
