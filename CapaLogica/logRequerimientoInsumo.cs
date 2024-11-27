using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logRequerimientoInsumo
    {
        private static readonly logRequerimientoInsumo _instancia = new logRequerimientoInsumo();
        public static logRequerimientoInsumo Instancia => _instancia;

        // Listar Requerimientos
        public List<entRequerimientoInsumo> ListarRequerimientoInsumo()
        {
            return datRequerimientoInsumo.Instancia.ListarRequerimientoInsumo();
        }

        // Insertar Requerimiento
        public void InsertarRequerimiento(entRequerimientoInsumo requerimiento)
        {
            if (requerimiento == null || requerimiento.Insumo == null)
                throw new ArgumentNullException("El requerimiento o el insumo no pueden ser nulos.");

            if (string.IsNullOrWhiteSpace(requerimiento.Insumo.nombreInsumo))
                throw new ArgumentException("El nombre del insumo no puede estar vacío.");

            if (requerimiento.Insumo.cantidadInsumo <= 0)
                throw new ArgumentException("La cantidad del insumo debe ser mayor a cero.");

            datRequerimientoInsumo.Instancia.InsertarRequerimientoInsumo(
                requerimiento.Insumo.nombreInsumo,
                requerimiento.Insumo.cantidadInsumo,
                requerimiento.estadoRequerimientoInsumo
            );
        }

        // Obtener insumo por nombre (retorna un objeto entInsumo)
        public entInsumo ObtenerInsumoPorNombre(string nombreInsumo)
        {
            return datRequerimientoInsumo.Instancia.ObtenerInsumoPorNombre(nombreInsumo);
        }

        public string GenerarYActualizarIds(List<int> listaRequerimientos)
           
        {
            // Generar un único ID provisional para todos los requerimientos seleccionados
            string nuevoId = "REQ" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Llamamos al acceso a datos para actualizar los registros con el nuevo ID
            datRequerimientoInsumo.Instancia.GenerarIdProvisional(nuevoId);

            // Devolvemos el ID generado para poder usarlo en la capa presentación
            return nuevoId;

        }
    }
}
