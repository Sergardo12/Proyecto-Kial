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
    public class datCompraInsumos
    {
        private static readonly datCompraInsumos _instancia = new datCompraInsumos();
        public static datCompraInsumos Instancia => _instancia;

        // Método para listar insumos activos
        public List<entCompraInsumos> ListarCompraInsumos()
        {
            List<entCompraInsumos> lista = new List<entCompraInsumos>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListarComprasInsumos", cn) // Procedimiento correcto
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entCompraInsumos
                        {
                            // Agregar los parámetros al comando
                            IdCompraInsumos = Convert.ToInt32(dr["idCompraInsumos"]),
                            IdReqInsumos = Convert.ToInt32(dr["idReqInsumos"]),
                            ID_ReqCCompra = dr["ID_ReqCCompra"] == DBNull.Value ? null : dr["ID_ReqCCompra"].ToString(),
                            IdProveedorCompra = Convert.ToInt32(dr["idProveedorCompra"]),
                            NombreProveedor = dr["nombreProveedor"].ToString(),
                            Administrador = dr["administrador"].ToString(),
                            FechaCompraInsumo = Convert.ToDateTime(dr["fechaCompra"]),
                            Monto = Convert.ToSingle(dr["monto"])

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
        public bool InsertarCompraInsumo(entCompraInsumos compra)
        {
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertarCompraInsumo", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agregar parámetros necesarios
                    cmd.Parameters.AddWithValue("@idReqInsumos", compra.IdReqInsumos);
                    cmd.Parameters.AddWithValue("@ID_ReqCCompra", (object)compra.ID_ReqCCompra ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idProveedorCompra", compra.IdProveedorCompra);
                    cmd.Parameters.AddWithValue("@nombreProveedor", compra.NombreProveedor);
                    cmd.Parameters.AddWithValue("@administrador", compra.Administrador);
                    cmd.Parameters.AddWithValue("@fechaCompra", compra.FechaCompraInsumo);
                    cmd.Parameters.AddWithValue("@monto", compra.Monto);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
            
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar compra: " + e.Message);
            }
          
        }
        public string ObtenerNombreProveedor(int idProveedor)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerNombreProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return dr["nombreProveedor"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre del proveedor: " + ex.Message);
            }
            finally
            {
                if (dr != null) dr.Close();
            }

            return null;
        }
    }
}
