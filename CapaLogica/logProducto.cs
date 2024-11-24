using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia => _instancia;

        // Listar productos
        public List<entProducto> ListarProductos()
        {
            return datProducto.Instancia.ListarProductos();
        }

        // Método para obtener la lista de productos
        public List<entProducto> ObtenerProductos()
        {
            return datProducto.Instancia.ListarProductos();
        }

        // Insertar producto
        public void InsertarProducto(entProducto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.nombreProducto))
            {
                throw new ArgumentException("El nombre del producto no pueden estar vacíos.");
            }

            if (producto.precioProducto <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0.");
            }

            datProducto.Instancia.InsertarProducto(producto);
        }


        // Modificar producto
        public void ModificarProducto(entProducto producto)
        {
            datProducto.Instancia.ModificarProducto(producto);
        }

        // Inhabilitar producto
        public void InhabilitarProducto(int idProducto)
        {
            datProducto.Instancia.InhabilitarProducto(idProducto);
        }
    }
}
