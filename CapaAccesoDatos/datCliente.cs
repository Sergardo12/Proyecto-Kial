using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad; 

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region Singleton
        private static readonly datCliente _instancia = new datCliente();

        private datCliente() { } // Constructor privado

        public static datCliente Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Métodos

        // Método para listar clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar()) // Usar la conexión en un bloque using
                {
                    cmd = new SqlCommand("spListaCliente", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            entCliente cliente = new entCliente
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                numero = Convert.ToInt32(dr["numero"]),
                                correo = dr["correo"].ToString(),
                                fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]),
                                estCliente = Convert.ToBoolean(dr["estCliente"])
                            };

                            lista.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar clientes: " + e.Message);
            }
            return lista;
        }

        // Método para insertar un cliente
        public bool InsertarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spInsertaCliente", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agregar parámetros necesarios
                    cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
                    cmd.Parameters.AddWithValue("@dni", cliente.dni);
                    cmd.Parameters.AddWithValue("@numero", cliente.numero);
                    cmd.Parameters.AddWithValue("@correo", cliente.correo);
                    cmd.Parameters.AddWithValue("@fecRegCliente", cliente.fecRegCliente);
                    cmd.Parameters.AddWithValue("@estCliente", cliente.estCliente);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    inserta = i > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar cliente: " + e.Message);
            }
            return inserta;
        }

        // Método para editar un cliente
        public bool EditarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEditaCliente", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agregar parámetros necesarios
                    cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                    cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
                    cmd.Parameters.AddWithValue("@dni", cliente.dni);
                    cmd.Parameters.AddWithValue("@numero", cliente.numero);
                    cmd.Parameters.AddWithValue("@correo", cliente.correo);
                    cmd.Parameters.AddWithValue("@fecRegCliente", cliente.fecRegCliente);
                    cmd.Parameters.AddWithValue("@estCliente", cliente.estCliente);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    edita = i > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar cliente: " + e.Message);
            }
            return edita;
        }

        // Método para deshabilitar un cliente
        public bool DeshabilitarCliente(int idCliente)
        {
            SqlCommand cmd = null;
            bool delete = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spDeshabilitaCliente", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    delete = i > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al deshabilitar cliente: " + e.Message);
            }
            return delete;
        }

        #endregion Métodos
    }
}
