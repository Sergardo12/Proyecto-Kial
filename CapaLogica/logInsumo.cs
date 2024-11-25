using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logInsumo
    {
        private static readonly logInsumo _instancia = new logInsumo();
        public static logInsumo Instancia => _instancia;

        // Listar insumos
        public List<entInsumo> ListarInsumos()
        {
            try
            {
                return datInsumo.Instancia.ListarInsumos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar insumos: " + ex.Message);
            }
        }

        // Insertar insumo
        public void InsertarInsumo(entInsumo insumo)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(insumo.nombreInsumo))
            {
                throw new ArgumentException("El nombre del insumo no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(insumo.medidaInsumo))
            {
                throw new ArgumentException("La unidad de medida del insumo no puede estar vacía.");
            }

            if (insumo.nombreInsumo.Length > 100)
            {
                throw new ArgumentException("El nombre del insumo no puede exceder los 100 caracteres.");
            }

            if (insumo.medidaInsumo.Length > 50)
            {
                throw new ArgumentException("La unidad de medida del insumo no puede exceder los 50 caracteres.");
            }

            try
            {
                datInsumo.Instancia.InsertarInsumo(insumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar insumo: " + ex.Message);
            }
        }

        // Modificar insumo
        public void ModificarInsumo(entInsumo insumo)
        {
            // Validaciones de negocio
            if (insumo.idInsumo <= 0)
            {
                throw new ArgumentException("El ID del insumo no es válido.");
            }

            if (string.IsNullOrWhiteSpace(insumo.nombreInsumo))
            {
                throw new ArgumentException("El nombre del insumo no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(insumo.medidaInsumo))
            {
                throw new ArgumentException("La unidad de medida del insumo no puede estar vacía.");
            }

            try
            {
                datInsumo.Instancia.ModificarInsumo(insumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar insumo: " + ex.Message);
            }
        }

        // Inhabilitar insumo
        public void InhabilitarInsumo(int idInsumo)
        {
            if (idInsumo <= 0)
            {
                throw new ArgumentException("El ID del insumo no es válido.");
            }

            try
            {
                datInsumo.Instancia.InhabilitarInsumo(idInsumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar insumo: " + ex.Message);
            }
        }
    }
}