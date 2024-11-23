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
    public class datOrden
    {
        #region Singleton
        private static readonly datOrden instancia = new datOrden();
        public static datOrden Instancia => instancia;
        #endregion

        public string GenerarIdOrden()
        {
            string idOrden = string.Empty;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spRegistrarOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParam = new SqlParameter("@idOrden", SqlDbType.NVarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        cmd.Parameters.AddWithValue("@total", 0); // Inicialmente sin total

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        idOrden = outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar ID de orden: " + ex.Message);
            }

            return idOrden;
        }

        public List<entDetalleOrden> ListarDetalles(string idOrden)
        {
            List<entDetalleOrden> lista = new List<entDetalleOrden>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spListarDetalleOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idOrden", idOrden);

                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lista.Add(new entDetalleOrden
                            {
                                idDetalleOrden = Convert.ToInt32(dr["idDetalleOrden"]),
                                idOrden = dr["idOrden"].ToString(),
                                idProducto = Convert.ToInt32(dr["idProducto"]),
                                producto = dr["producto"].ToString(),
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                precioUnitario = Convert.ToDecimal(dr["precioUnitario"]),
                                subtotal = Convert.ToDecimal(dr["subtotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar detalles: " + ex.Message);
            }

            return lista;
        }

        public void AgregarDetalle(entDetalleOrden detalle)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertarDetalleOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idOrden", detalle.idOrden);
                        cmd.Parameters.AddWithValue("@idProducto", detalle.idProducto);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                        cmd.Parameters.AddWithValue("@precioUnitario", detalle.precioUnitario);
                        cmd.Parameters.AddWithValue("@subtotal", detalle.subtotal);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar detalle: " + ex.Message);
            }
        }
        public void InsertarDetalle(entDetalleOrden detalle)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertarDetalleOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idOrden", detalle.idOrden);
                        cmd.Parameters.AddWithValue("@idProducto", detalle.idProducto);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                        cmd.Parameters.AddWithValue("@precioUnitario", detalle.precioUnitario);
                        cmd.Parameters.AddWithValue("@subtotal", detalle.subtotal);
                        cmd.Parameters.AddWithValue("@estado", detalle.estado);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el detalle: " + ex.Message);
            }
        }
        public void ActualizarEstado(int idDetalleOrden)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spActualizarEstadoDetalle", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idDetalleOrden", idDetalleOrden);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado: " + ex.Message);
            }
        }
        

        public void ModificarDetalle(entDetalleOrden detalle)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spModificarDetalleOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idDetalleOrden", detalle.idDetalleOrden);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                        cmd.Parameters.AddWithValue("@subtotal", detalle.subtotal);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar detalle: " + ex.Message);
            }
        }
        public void InhabilitarDetalle(int idDetalleOrden)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInhabilitarDetalleOrden", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idDetalleOrden", idDetalleOrden);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar detalle: " + ex.Message);
            }
        }


    }
}
