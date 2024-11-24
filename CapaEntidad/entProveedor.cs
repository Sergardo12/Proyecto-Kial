using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public int rucProveedor { get; set; }
        public string direccionProveedor { get; set; }
        public DateTime fecRegProveedor { get; set; }
        public bool estProveedor { get; set; }
    }
}
