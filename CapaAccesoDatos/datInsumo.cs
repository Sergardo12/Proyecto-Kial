using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datInsumo
    {
        private static readonly datInsumo _instancia = new datInsumo();
        public static datInsumo Instancia => _instancia;

        // Listar productos
        public List<entInsumo> ListarInsumo()
        {
            List<entInsumo> lista = new List<entInsumo>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entInsumo
                        {
                            idInsumo = Convert.ToInt32(dr["idInsumo"]),
                            nombreInsumo = dr["nombreInsumo"].ToString(),
                            cantidadInsumo = Convert.ToInt32(dr["cantidadInsumo"]),
                            medidaInsumo = dr["medidaInsumo"].ToString(),
                            estadoInsumo = Convert.ToBoolean(dr["estadoInsumo"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar insumos: " + ex.Message);
            }

            return lista;
        }

        // Insertar producto
        public void InsertarInsumo(entInsumo insumo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertarInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@nombre", insumo.nombreInsumo);
                    cmd.Parameters.AddWithValue("@medida", insumo.medidaInsumo);
                    cmd.Parameters.AddWithValue("@estado", insumo.estadoInsumo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar insumo: " + ex.Message);
            }
        }

        // Modificar producto
        public void ModificarInsumo(entInsumo insumo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spModificarInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idInsumo", insumo.idInsumo);
                    cmd.Parameters.AddWithValue("@nombre", insumo.nombreInsumo);
                    cmd.Parameters.AddWithValue("@medida", insumo.medidaInsumo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar insumo: " + ex.Message);
            }
        }

        // Inhabilitar producto
        public void InhabilitarInsumo(int idInsumo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInhabilitarInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar insumo: " + ex.Message);
            }
        }
    }
}
