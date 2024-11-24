using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaAccesoDatos;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaLogica
{
     public class logCliente
    {
        #region Singleton
        // Implementación del patrón Singleton para asegurar una única instancia de logCliente
        private static readonly logCliente _instancia = new logCliente();

        // Constructor privado para evitar instancias externas
        private logCliente() { }

        public static logCliente Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Métodos

        public List<entCliente> ListarCliente()
        {
            try
            {
                return datCliente.Instancia.ListarCliente();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
        }
        /// <param name="cliente">Objeto de tipo entCliente que contiene los datos del cliente a insertar.</param>
        public void InsertaCliente(entCliente cliente)
        {
            // Validaciones adicionales antes de insertar
            // Verificar que razonSocial no esté vacío y que dni sea un número positivo
            if (string.IsNullOrEmpty(cliente.nombreCliente))
            {
                throw new ArgumentException("La razón social no puede estar vacía.");
            }
            if (cliente.dni <= 0)
            {
                throw new ArgumentException("El DNI debe ser un número positivo.");
            }

            try
            {
                datCliente.Instancia.InsertarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        /// <summary>
        /// Edita un cliente existente en la base de datos.
        /// </summary>
        /// <param name="cliente">Objeto de tipo entCliente que contiene los datos actualizados del cliente.</param>
        public void EditaCliente(entCliente cliente)
        {
            // Validaciones previas a la edición del cliente
            if (cliente.idCliente <= 0)
            {
                throw new ArgumentException("El ID del cliente debe ser válido.");
            }
            if (string.IsNullOrEmpty(cliente.nombreCliente))
            {
                throw new ArgumentException("La razón social no puede estar vacía.");
            }

            try
            {
                datCliente.Instancia.EditarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar cliente: " + ex.Message);
            }
        }

        /// <summary>
        /// Deshabilita un cliente en la base de datos, cambiando su estado a inactivo.
        /// </summary>
        /// <param name="idCliente">ID del cliente que se va a deshabilitar.</param>
        public void DeshabilitarCliente(int idCliente)
        {
            // Verificación adicional de que el ID del cliente es válido
            if (idCliente <= 0)
            {
                throw new ArgumentException("El ID del cliente debe ser válido.");
            }

            try
            {
                datCliente.Instancia.DeshabilitarCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deshabilitar cliente: " + ex.Message);
            }
        }

        #endregion Métodos
    }
}
