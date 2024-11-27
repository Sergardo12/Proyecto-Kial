using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCompraInsumos
    {
        public int IdCompraInsumos { get; set; }  // ID de la compra, autoincrementable
        public int IdReqInsumos { get; set; }     // ID del requerimiento de insumo
        public string ID_ReqCCompra { get; set; } // Nueva propiedad
        public int IdProveedorCompra { get; set; }  // ID del proveedor
        public string NombreProveedor { get; set; }  // Nombre del proveedor
        public string Administrador { get; set; }  // Nombre del administrador que realiza la compra
        public DateTime FechaCompraInsumo { get; set; }  // Fecha de la compra
        public float Monto { get; set; }  // Monto de la compra
    }
}
