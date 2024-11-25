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

        // Relación con entInsumo para acceder a los datos referenciados
        public entInsumo Insumo { get; set; }
    }
}
