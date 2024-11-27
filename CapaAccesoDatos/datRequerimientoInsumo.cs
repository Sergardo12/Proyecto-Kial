using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

                        };
                        requerimiento.estadoRequerimientoInsumo = Convert.ToBoolean(dr["estadoReq"]);

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
        public void InsertarRequerimientoInsumo(string nombreInsumo, int cantidadInsumo, bool estadoRequerimientoInsumo)
        {
            SqlCommand cmd = null;
            try
            {
                // Usamos la conexión Singleton
                using (SqlConnection con = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertarRequerimientoInsumo", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agregar los parámetros necesarios al procedimiento almacenado
                    cmd.Parameters.Add("@nombreInsumoReq", SqlDbType.VarChar, 50).Value = nombreInsumo;
                    cmd.Parameters.Add("@cantidadReq", SqlDbType.Int).Value = cantidadInsumo;
                    cmd.Parameters.Add("@estadoReq", SqlDbType.Bit).Value = estadoRequerimientoInsumo;

                    // Ejecutar el procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el requerimiento de insumo: " + ex.Message);
            }
        }
        public entInsumo ObtenerInsumoPorNombre(string nombreInsumo)
        {
            entInsumo insumo = null;
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                try
                {
                    conn.Open();

                    // Llamar al procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand("spObtenerInsumoPorNombre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreInsumo", nombreInsumo);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                insumo = new entInsumo
                                {
                                    idInsumo = reader.GetInt32(reader.GetOrdinal("idInsumo")),
                                    nombreInsumo = reader.GetString(reader.GetOrdinal("nombreInsumo")),
                                    medidaInsumo = reader.GetString(reader.GetOrdinal("medidaInsumo")),
                                    cantidadInsumo = reader.GetInt32(reader.GetOrdinal("cantidadInsumo")),
                                    //estadoInsumo = reader.GetString(reader.GetOrdinal("estadoInsumo"))
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener insumo por nombre: " + ex.Message);
                }
            }

            return insumo; // Retornar el insumo encontrado
        }

        public void GenerarIdProvisional(string nuevoId)
        {
            SqlCommand cmd = null;
            SqlParameter paramNuevoId = new SqlParameter("@nuevoId", SqlDbType.NVarChar) { Value = nuevoId };

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spGenerarIdProvisional", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(paramNuevoId);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el ID provisional: " + ex.Message);
            }
        }

        //public void ActualizarIdProvisional(string nuevoId, int idRequerimientoInsumo)
        //{
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        using (SqlConnection cn = Conexion.Instancia.Conectar())
        //        {
        //            cmd = new SqlCommand("spActualizarIdProvisional", cn)
        //            {
        //                CommandType = CommandType.StoredProcedure
        //            };

        //            // Parámetros del procedimiento
        //            cmd.Parameters.AddWithValue("@nuevoId", nuevoId);
        //            cmd.Parameters.AddWithValue("@idRequerimientoInsumo", idRequerimientoInsumo);

        //            cn.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al actualizar el ID provisional: " + ex.Message);
        //    }
        //}
    }
}
