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
    public class DatNotaSalida
    {
        #region sigleton
        private static readonly DatNotaSalida _instancia = new DatNotaSalida();
        public static DatNotaSalida Instancia
        {
            get
            {
                return DatNotaSalida._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO DE NOTAINGRESO
        public List<EntNotaSalida> ListarNotaSalida()
        {
            SqlCommand cmd = null;
            List<EntNotaSalida> lista = new List<EntNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNotaSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntNotaSalida ns = new EntNotaSalida();
                    ns.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    ns.Producto = dr["Producto"].ToString();
                    ns.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    ns.FecRegInsumo = Convert.ToDateTime(dr["FecRegInsumo"]);
                    ns.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(ns);
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
        public Boolean InsertarNotaSalida(EntNotaSalida ns)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", ns.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", ns.Cantidad);
                cmd.Parameters.AddWithValue("@FecRegInsumo", ns.FecRegInsumo);
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
        public Boolean EditarNotaSalida(EntNotaSalida ns)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarNotaSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", ns.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", ns.Cantidad);
                cmd.Parameters.AddWithValue("@FecRegInsumo", ns.FecRegInsumo);
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
        public Boolean AnularNotaSalida(EntNotaSalida ns)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularNotaSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", ns.IdProducto);
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
        public List<EntNotaSalida> LeerNotaSalida()
        {
            SqlCommand cmd = null;
            List<EntNotaSalida> leer = new List<EntNotaSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spLeerNotaSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntNotaSalida ns = new EntNotaSalida();
                    ns.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    ns.Producto = dr["Producto"].ToString();
                    ns.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    ns.FecRegInsumo = Convert.ToDateTime(dr["FecRegInsumo"]);
                    ns.Estado = Convert.ToBoolean(dr["Estado"]);
                    leer.Add(ns);
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
