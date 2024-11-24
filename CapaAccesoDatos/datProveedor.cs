using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datProveedor
    {
        #region Singleton
        private static readonly datProveedor _instancia = new datProveedor();

        public static datProveedor Instancia
        {
            get { return _instancia; }
        }

        private datProveedor() { }
        #endregion

        #region Métodos

        // Listar Proveedores
        public List<entProveedor> ListarProveedores()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spListaProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        entProveedor proveedor = new entProveedor
                        {
                            idProveedor = Convert.ToInt32(dr["idProveedor"]),
                            nombreProveedor = dr["nombreProveedor"].ToString(),
                            rucProveedor = Convert.ToInt32(dr["rucProveedor"]),
                            direccionProveedor = dr["direccionProveedor"].ToString(),
                            fecRegProveedor = Convert.ToDateTime(dr["fecRegProveedor"]),
                            estProveedor = Convert.ToBoolean(dr["estProveedor"])
                        };

                        lista.Add(proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedores: " + ex.Message);
            }
            return lista;
        }

        // Insertar Proveedor
        public bool InsertarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertaProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@nombreProveedor", proveedor.nombreProveedor);
                    cmd.Parameters.AddWithValue("@rucProveedor", proveedor.rucProveedor);
                    cmd.Parameters.AddWithValue("@direccionProveedor", proveedor.direccionProveedor);
                    cmd.Parameters.AddWithValue("@fecRegProveedor", proveedor.fecRegProveedor);
                    cmd.Parameters.AddWithValue("@estProveedor", proveedor.estProveedor);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    inserta = i > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
            return inserta;
        }

        // Editar Proveedor
        public bool EditarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            bool edita = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEditaProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                    cmd.Parameters.AddWithValue("@nombreProveedor", proveedor.nombreProveedor);
                    cmd.Parameters.AddWithValue("@rucProveedor", proveedor.rucProveedor);
                    cmd.Parameters.AddWithValue("@direccionProveedor", proveedor.direccionProveedor);
                    cmd.Parameters.AddWithValue("@fecRegProveedor", proveedor.fecRegProveedor);
                    cmd.Parameters.AddWithValue("@estProveedor", proveedor.estProveedor);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    edita = i > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar proveedor: " + ex.Message);
            }
            return edita;
        }

        // Deshabilitar Proveedor
        public bool DeshabilitarProveedor(int idProveedor)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spDeshabilitaProveedor", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    deshabilita = i > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deshabilitar proveedor: " + ex.Message);
            }
            return deshabilita;
        }

        #endregion
    }
}
