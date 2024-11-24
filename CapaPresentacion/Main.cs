using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Main : Form
    {
        // Variables de nivel de clase para cada formulario
        private MantenedorCliente registroClienteForm;
        private MantenedorComprobanteDeVenta pedidoForm;
        private MantenedorProveedor proveedorForm;
        private RequerimientoCompra requerimientoCompraForm;
        private MantenedorRegistroAlmacen registroAlmacenForm;
        public Main()
        {
            InitializeComponent();
        }

        private void btnregistrocliente_Click(object sender, EventArgs e)
        {
            if (registroClienteForm == null || registroClienteForm.IsDisposed)
            {
                registroClienteForm = new MantenedorCliente();
                registroClienteForm.FormClosed += (s, args) => registroClienteForm = null;
                registroClienteForm.Show();
            }

        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            if (pedidoForm == null || pedidoForm.IsDisposed)
            {
                pedidoForm = new MantenedorComprobanteDeVenta();
                pedidoForm.FormClosed += (s, args) => pedidoForm = null;
                pedidoForm.Show();
            }
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            if (proveedorForm == null || proveedorForm.IsDisposed)
            {
                proveedorForm = new MantenedorProveedor();
                proveedorForm.FormClosed += (s, args) => proveedorForm = null;
                proveedorForm.Show();
            }
        }


        private void btnrequerimientocompra_Click(object sender, EventArgs e)
        {
            if (requerimientoCompraForm == null || requerimientoCompraForm.IsDisposed)
            {
                requerimientoCompraForm = new RequerimientoCompra();
                requerimientoCompraForm.FormClosed += (s, args) => requerimientoCompraForm = null;
                requerimientoCompraForm.Show();
            }
        }

        private void btnregistroalmacen_Click(object sender, EventArgs e)
        {
            if (registroAlmacenForm == null || registroAlmacenForm.IsDisposed)
            {
                registroAlmacenForm = new MantenedorRegistroAlmacen();
                registroAlmacenForm.FormClosed += (s, args) => registroAlmacenForm = null;
                registroAlmacenForm.Show();
            }
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
