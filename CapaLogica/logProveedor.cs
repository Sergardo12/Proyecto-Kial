using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region Singleton
        private static readonly logProveedor _instancia = new logProveedor();

        public static logProveedor Instancia
        {
            get { return _instancia; }
        }

        private logProveedor() { }
        #endregion

        #region Métodos

        public List<entProveedor> ListarProveedores()
        {
            return datProveedor.Instancia.ListarProveedores();
        }

        public void InsertarProveedor(entProveedor proveedor)
        {
            if (string.IsNullOrEmpty(proveedor.nombreProveedor))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            if (proveedor.rucProveedor <= 0)
                throw new ArgumentException("El RUC debe ser un número válido.");

            datProveedor.Instancia.InsertarProveedor(proveedor);
        }

        public void EditarProveedor(entProveedor proveedor)
        {
            if (proveedor.idProveedor <= 0)
                throw new ArgumentException("El ID del proveedor no es válido.");
            if (string.IsNullOrEmpty(proveedor.nombreProveedor))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            datProveedor.Instancia.EditarProveedor(proveedor);
        }

        public void DeshabilitarProveedor(int idProveedor)
        {
            if (idProveedor <= 0)
                throw new ArgumentException("El ID del proveedor no es válido.");

            datProveedor.Instancia.DeshabilitarProveedor(idProveedor);
        }

        #endregion
    }
}