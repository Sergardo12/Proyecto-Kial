using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entInsumo
    {
        public int idInsumo { get; set; }
        public string nombreInsumo { get; set; }
        public int cantidadInsumo { get; set; }
        public string medidaInsumo { get; set; }
        public bool estadoInsumo { get; set; } // Para saber si está habilitado o inhabilitado
    }
}
