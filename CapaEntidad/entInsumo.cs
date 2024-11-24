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
        public string nombre { get; set; }
        public string medida { get; set; }
        public bool estado { get; set; } // Para saber si está habilitado o inhabilitado
    }
}
