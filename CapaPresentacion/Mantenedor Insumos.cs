﻿using CapaEntidad;
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
                dtgvInsumo.DataSource = logInsumo.Instancia.ListarInsumo();
                dtgvInsumo.Columns["estado"].Visible = true; // Ocultar columna si no es necesaria
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar insumo: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtIdInsumo.Clear();
            txtNombreInsumo.Clear();
            txtUnidadMedidaInsumo.Clear();
            chkEstadoInsumo.Checked = true;
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

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumo insumo = new entInsumo
                {
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = txtUnidadMedidaInsumo.Text.Trim(),
                    estadoInsumo = true // Estado activo por defecto
                };

                logInsumo.Instancia.InsertarInsumo(insumo);
                MessageBox.Show("Insumo agregado correctamente.");
                CargarProductos(); // Refresca la lista
                LimpiarCampos(); // Limpia los campos
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
                entInsumo insumoModificado = new entInsumo
                {
                    idInsumo = int.Parse(txtIdInsumo.Text),
                    nombreInsumo = txtNombreInsumo.Text.Trim(),
                    medidaInsumo = txtUnidadMedidaInsumo.Text.Trim(),
                };

                logInsumo.Instancia.ModificarInsumo(insumoModificado);
                MessageBox.Show("Insumo modificado correctamente.");
                CargarProductos();
                LimpiarCampos(); // Limpia los campos
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
                int idInsumo = int.Parse(txtIdInsumo.Text);
                logInsumo.Instancia.InhabilitarInsumo(idInsumo);
                MessageBox.Show("Insumo inhabilitado correctamente.");
                CargarProductos();
                LimpiarCampos(); // Limpia los campos
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
