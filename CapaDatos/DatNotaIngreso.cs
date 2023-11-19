using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatNotaIngreso
    {
        #region sigleton
        private static readonly DatNotaIngreso _instancia = new DatNotaIngreso();
        public static DatNotaIngreso Instancia
        {
            get
            {
                return DatNotaIngreso._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO DE NOTAINGRESO
        public List<EntNotaIngreso> ListarNotaIngreso()
        {
            SqlCommand cmd = null;
            List<EntNotaIngreso> lista = new List<EntNotaIngreso>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntNotaIngreso ni = new EntNotaIngreso();
                    ni.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    ni.Producto = dr["Producto"].ToString();
                    ni.Proveedor = dr["Proveedor"].ToString();
                    ni.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    ni.Precio = Convert.ToInt32(dr["Precio"]);
                    ni.FecRegInsumo = Convert.ToDateTime(dr["FecRegInsumo"]);
                    ni.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(ni);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //INSERTAR
        public Boolean InsertarNotaIngreso(EntNotaIngreso ni)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", ni.Producto);
                cmd.Parameters.AddWithValue("@Proveedor", ni.Proveedor);
                cmd.Parameters.AddWithValue("@Cantidad", ni.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", ni.Precio);
                cmd.Parameters.AddWithValue("@FecRegInsumo", ni.FecRegInsumo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        // EDITAR
        /*
        public Boolean EditarNotaIngreso(EntNotaIngreso ni)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", ni.Producto);
                cmd.Parameters.AddWithValue("@Proveedor", ni.Proveedor);
                cmd.Parameters.AddWithValue("@Cantidad", ni.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", ni.Precio);
                cmd.Parameters.AddWithValue("@FecRegInsumo", ni.FecRegInsumo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }*/

        //DESHABILITAR
        public Boolean AnularNotaIngreso(EntNotaIngreso ni)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", ni.IdProducto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        //LEER        
        public List<EntNotaIngreso> LeerNotaIngreso()
        {
            SqlCommand cmd = null;
            List<EntNotaIngreso> leer = new List<EntNotaIngreso>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spLeerNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntNotaIngreso ni = new EntNotaIngreso();
                    ni.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    ni.Producto = dr["Producto"].ToString();
                    ni.Proveedor = dr["Proveedor"].ToString();
                    ni.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    ni.Precio = Convert.ToInt32(dr["Precio"]);
                    ni.FecRegInsumo = Convert.ToDateTime(dr["FecRegInsumo"]);
                    ni.Estado = Convert.ToBoolean(dr["Estado"]);
                    leer.Add(ni);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return leer;
        }
        #endregion metodos;
    }
}
