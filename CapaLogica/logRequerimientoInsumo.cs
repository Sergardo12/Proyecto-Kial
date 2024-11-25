using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logRequerimientoInsumo
    {
        private static readonly logRequerimientoInsumo _instancia = new logRequerimientoInsumo();
        public static logRequerimientoInsumo Instancia => _instancia;

        //Listar Requermientos
        public List<entRequerimientoInsumo> ListarRequerimientoInsumo()
        {
            return datRequerimientoInsumo.Instancia.ListarRequerimientoInsumo();
        }

        //Insertar Requermiento 
        public void InsertarRequermiento(entRequerimientoInsumo requerimiento)
        {
            datRequerimientoInsumo.Instancia.InsertarRequerimiento(requerimiento);
        }

    }
}
