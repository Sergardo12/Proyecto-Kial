using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datRequerimientoInsumo
    {
        private static readonly datRequerimientoInsumo _instancia = new datRequerimientoInsumo();
        public static datRequerimientoInsumo Instancia => _instancia;


        //ListarRequermientos

        public List<entRequerimientoInsumo> ListarRequerimientoInsumo()
        {
            List<entRequerimientoInsumo> lista = new List<entRequerimientoInsumo>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarRequerimientoInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        // Crear una nueva instancia de entRequerimientoInsumo
                        entRequerimientoInsumo requerimiento = new entRequerimientoInsumo();

                        // Llenar la propiedad Insumo con una nueva instancia de entInsumo
                        requerimiento.Insumo = new entInsumo
                        {
                            nombreInsumo = dr["nombreInsumoReq"].ToString(),
                            cantidadInsumo = Convert.ToInt32(dr["cantidadReq"]),
                            medidaInsumo = dr["unidadReq"].ToString()
                        };

                        // Añadir la instancia de entRequerimientoInsumo a la lista
                        lista.Add(requerimiento);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar insumos: " + ex.Message);
            }

            return lista;
        }

        //Insertar Requermientos
        public void InsertarRequerimiento(entRequerimientoInsumo requerimiento)
        {
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertarRequerimientoInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agregar los parámetros correctamente desde la entidad entRequerimientoInsumo
                    cmd.Parameters.AddWithValue("@idInsumoReq", requerimiento.Insumo.idInsumo); // Obtener el ID del insumo desde la propiedad Insumo
                    cmd.Parameters.AddWithValue("@nombreInsumoReq", requerimiento.Insumo.nombreInsumo); // Obtener el nombre del insumo desde la propiedad Insumo
                    cmd.Parameters.AddWithValue("@cantidadReq", requerimiento.Insumo.cantidadInsumo); // Obtener la cantidad del insumo
                    cmd.Parameters.AddWithValue("@unidadReq", requerimiento.Insumo.medidaInsumo); // Obtener la unidad del insumo

                    cn.Open();
                    cmd.ExecuteNonQuery(); // Ejecutar el procedimiento almacenado
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                throw new Exception("Error al insertar el requerimiento de insumo: " + ex.Message);
            }
        }


    }
}
