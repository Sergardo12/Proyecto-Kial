using CapaEntidad; // Asegúrate de que esta referencia esté bien configurada
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class datInsumo
    {
        private static readonly datInsumo _instancia = new datInsumo();
        public static datInsumo Instancia => _instancia;

        // Método para listar insumos activos
        public List<entInsumo> ListarInsumos()
        {
            List<entInsumo> lista = new List<entInsumo>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarInsumos", cn) // Procedimiento correcto
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

        // Método para insertar un nuevo insumo
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

                    cmd.Parameters.AddWithValue("@nombreInsumo", insumo.nombreInsumo); // Nombre correcto
                    cmd.Parameters.AddWithValue("@medidaInsumo", insumo.medidaInsumo); // Medida correcta
                    cmd.Parameters.AddWithValue("@estadoInsumo", insumo.estadoInsumo); // Estado correcto

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar insumo: " + ex.Message);
            }
        }

        // Método para modificar un insumo existente
        public void ModificarInsumo(entInsumo insumo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spActualizarInsumo", cn) // Procedimiento correcto
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idInsumo", insumo.idInsumo);
                    cmd.Parameters.AddWithValue("@nombreInsumo", insumo.nombreInsumo); // Nombre correcto
                    cmd.Parameters.AddWithValue("@medidaInsumo", insumo.medidaInsumo); // Medida correcta
                    cmd.Parameters.AddWithValue("@estadoInsumo", insumo.estadoInsumo); // Estado correcto

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar insumo: " + ex.Message);
            }
        }

        // Método para inhabilitar un insumo
        public void InhabilitarInsumo(int idInsumo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInhabilitarInsumo", cn) // Procedimiento correcto
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idInsumo", idInsumo); // Parámetro correcto

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar insumo: " + ex.Message);
            }
        }

        //Obtener un insumo por su nombre

            // Método para obtener un insumo por nombre
            public entInsumo ObtenerInsumoPorNombre(string nombreInsumo)
            {
                SqlCommand cmd = null;
                SqlDataReader dr = null;
                entInsumo insumo = null;

                try
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        cmd = new SqlCommand("spObtenerInsumoPorNombre", cn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@nombreInsumo", nombreInsumo);

                        cn.Open();
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            insumo = new entInsumo
                            {
                                idInsumo = Convert.ToInt32(dr["idInsumo"]),
                                nombreInsumo = dr["nombreInsumo"].ToString(),
                                medidaInsumo = dr["medidaInsumo"].ToString(),
                                cantidadInsumo = Convert.ToInt32(dr["cantidadInsumo"]),
                                estadoInsumo = Convert.ToBoolean(dr["estadoInsumo"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el insumo: " + ex.Message);
                }
                finally
                {
                    if (dr != null) dr.Close();
                }

                return insumo;
            }
       

    }
}