using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entInsumo
    {
        /// <summary>
        /// Identificador único del insumo (clave primaria).
        /// </summary>
        public int idInsumo { get; set; }

        /// <summary>
        /// Nombre del insumo.
        /// </summary>
        public string nombreInsumo { get; set; }

        /// <summary>
        /// Cantidad del insumo (aunque no se utiliza en los procedimientos actuales).
        /// </summary>
        public int cantidadInsumo { get; set; }

        /// <summary>
        /// Unidad de medida del insumo (por ejemplo, "kg" o "unidad").
        /// </summary>
        public string medidaInsumo { get; set; }

        /// <summary>
        /// Estado del insumo: activo (true) o inactivo (false).
        /// </summary>
        public bool estadoInsumo { get; set; }
    }
}
