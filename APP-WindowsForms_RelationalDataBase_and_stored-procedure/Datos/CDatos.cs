using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using APP_WindowsForms_RelationalDataBase_and_stored_procedure.Entidad;
using System.Windows.Forms;

namespace APP_WindowsForms_RelationalDataBase_and_stored_procedure.Datos
{
    class CDatos
    {
        public int GuardarRolUsuario(Rol pRol)
        {
            CConexion cn = new CConexion();
            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spguardar_rol", conexion))
                    {
                        int ultimoRegistro = 0;
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                        id.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(id);

                        cmd.Parameters.Add(new SqlParameter("@nombre", pRol.nombre));
                        cmd.ExecuteNonQuery();

                        if (id.Value != DBNull.Value)
                        {
                            ultimoRegistro = Convert.ToInt32(id.Value);
                        }
                        return ultimoRegistro;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
        }
        public void GuardarPermiso(Permiso pPermiso)
        {
            CConexion cn = new CConexion();
            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarPermiso", conexion))
                    {
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@rolusuarioid", pPermiso.rolUsuarioid));
                        cmd.Parameters.Add(new SqlParameter("@opcionid", pPermiso.opcionid));
                        cmd.Parameters.Add(new SqlParameter("@permitido", pPermiso.permitido));

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public DataTable ComboRol()
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spComboRol", conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return dt;
            }
        }
        public void GuardarUsuario(Usuario pUsuario)
        {
            CConexion cn = new CConexion();
            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarUsuario", conexion))
                    {
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@nombre", pUsuario.usuario));
                        cmd.Parameters.Add(new SqlParameter("@passwordd", pUsuario.password));
                        cmd.Parameters.Add(new SqlParameter("@rolid", pUsuario.rolid));

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public int BuscarUsuario(string pUsuario, string pPassword)
        {
            CConexion cn = new CConexion();
            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spBuscarUsuario", conexion))
                    {
                        int id = 0;
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter idRol = new SqlParameter("@idUsuario", SqlDbType.Int);
                        idRol.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idRol);

                        cmd.Parameters.Add(new SqlParameter("@nombre", pUsuario));
                        cmd.Parameters.Add(new SqlParameter("@passwordd", pPassword));

                        cmd.ExecuteNonQuery();
                        if (idRol.Value != DBNull.Value)
                        {
                            id = Convert.ToInt32(idRol.Value);
                        }
                        return id;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            }
        }
        public List<Permiso> SelectOpcion(int pIdRol)
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cn.StrinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSelectOpcion", conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idRol", pIdRol));
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        List<Permiso> Opcion = (from row in dt.AsEnumerable()
                                                select new Permiso()
                                                {
                                                    id = int.Parse(row["id"].ToString()),
                                                    rolUsuarioid = int.Parse(row["rolUsuarioid"].ToString()),
                                                    opcionid = int.Parse(row["opcionid"].ToString()),
                                                    permitido = bool.Parse(row["permitido"].ToString())
                                                }).ToList();
                        return Opcion;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }

    }
}
