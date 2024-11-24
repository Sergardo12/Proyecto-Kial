using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioProducto { get; set; }
        public bool estadoProducto { get; set; } // Para saber si está habilitado o inhabilitado
    }
}
