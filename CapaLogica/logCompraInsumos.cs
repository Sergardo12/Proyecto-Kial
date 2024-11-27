using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCompraInsumos
    {
        private static readonly logCompraInsumos _instancia = new logCompraInsumos();
        public static logCompraInsumos Instancia => _instancia;

        // Listar insumos
        public List<entCompraInsumos> ListarCompraInsumos()
        {
            try
            {
                return datCompraInsumos.Instancia.ListarCompraInsumos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar insumos: " + ex.Message);
            }
        }

        public void InsertaCommpraInsums(entCompraInsumos compra)
        {
  
            try
            {
                datCompraInsumos.Instancia.InsertarCompraInsumo(compra);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar compra: " + ex.Message);
            }
        }

        public string ObtenerNombreProveedor(int idProveedor)
        {
            try
            {
                return datCompraInsumos.Instancia.ObtenerNombreProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre del proveedor: " + ex.Message);
            }
        }

    }
}
