using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimientoInsumo
    {
        public int idRequerimientoInsumo {  get; set; }
        public int idInsumoReq {  get; set; }

        // Campo de estado como booleano (bit en la base de datos)
        public bool estadoRequerimientoInsumo { get; set; }

        // ID provisional (si es necesario en tu lógica)
        public int? idProvisional { get; set; }

        // Relación con entInsumo para acceder a los datos referenciados
        public entInsumo Insumo { get; set; }
    }
}
