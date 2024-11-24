using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInsumo
    {
        private static readonly logInsumo _instancia = new logInsumo();
        public static logInsumo Instancia => _instancia;

        // Listar productos
        public List<entInsumo> ListarInsumo()
        {
            return datInsumo.Instancia.ListarInsumo();
        }
        // Insertar producto
        public void InsertarInsumo(entInsumo insumo)
        {
            if (string.IsNullOrWhiteSpace(insumo.nombreInsumo))
            {
                throw new ArgumentException("El nombre del producto no pueden estar vacíos.");
            }
            if (string.IsNullOrWhiteSpace(insumo.medidaInsumo))
            {
                throw new ArgumentException("La medida del producto no pueden estar vacíos.");
            }

            datInsumo.Instancia.InsertarInsumo(insumo);
        }


        // Modificar producto
        public void ModificarInsumo(entInsumo insumo)
        {
            datInsumo.Instancia.ModificarInsumo(insumo);
        }

        // Inhabilitar producto
        public void InhabilitarInsumo(int idInsumo)
        {
            datInsumo.Instancia.InhabilitarInsumo(idInsumo);
        }
    }
}
