using CapaLogica;
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
    public partial class Mantenedor_Insumos : Form
    {
        public Mantenedor_Insumos()
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
                dtgvInsumo.DataSource = logProducto.Instancia.ListarProductos();
                dtgvInsumo.Columns["estado"].Visible = true; // Ocultar columna si no es necesaria
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar insumo: " + ex.Message);
            }
        }

        private void pcbxFondoMadera_Click(object sender, EventArgs e)
        {

        }

        private void btnListoInsumo_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnCancelarInsumo_Click(object sender, EventArgs e)
        {

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnRegresarInsumo_Click(object sender, EventArgs e)
        {
            // Si no hay cambios, regresa a la vista Main
            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }
    }
}
