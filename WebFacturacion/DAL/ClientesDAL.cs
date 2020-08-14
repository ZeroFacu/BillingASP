using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.DAL
{
    static public class ClientesDAL
    {
        static public SqlConnection con;

        static public Int32 InsertarCliente(Clientes obj)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPIclientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@Id_cte";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdCliente);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre_cte";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Direction = ParameterDirection.Input;
                parNombre.Value = obj.Nombre_cte;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@Direccion_cte";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Direction = ParameterDirection.Input;
                parDireccion.Value = obj.Direccion_cte;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono_cte";
                parTelefono.SqlDbType = SqlDbType.Char;
                parTelefono.Direction = ParameterDirection.Input;
                parTelefono.Value = obj.Telefono_cte;
                cmd.Parameters.Add(parTelefono);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@Email_cte";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Direction = ParameterDirection.Input;
                parEmail.Value = obj.Email_cte;
                cmd.Parameters.Add(parEmail);

                SqlParameter parFechaNacimiento = new SqlParameter();
                parFechaNacimiento.ParameterName = "@FechaNacimiento_cte";
                parFechaNacimiento.SqlDbType = SqlDbType.Date;
                parFechaNacimiento.Direction = ParameterDirection.Input;
                parFechaNacimiento.Value = obj.FechaNacimiento_cte;
                cmd.Parameters.Add(parFechaNacimiento);

                SqlParameter parRFC = new SqlParameter();
                parRFC.ParameterName = "@RFC_cte";
                parRFC.SqlDbType = SqlDbType.VarChar;
                parRFC.Direction = ParameterDirection.Input;
                parRFC.Value = obj.RFC_cte;
                cmd.Parameters.Add(parRFC);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    obj.Id_cte = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
                }

                }

                catch (SqlException ex) 
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return affectedRows;

        }

        static public Int32 BorrarCliente(Int32 Id_cte, String RFC_cte)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPDclientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@Id_cte";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Direction = ParameterDirection.Input;
                parIdCliente.Value = Id_cte;
                cmd.Parameters.Add(parIdCliente);

                SqlParameter parRFC = new SqlParameter();
                parRFC.ParameterName = "@RFC_cte";
                parRFC.SqlDbType = SqlDbType.VarChar;
                parRFC.Direction = ParameterDirection.Input;
                parRFC.Value = RFC_cte;
                cmd.Parameters.Add(parRFC);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    Id_cte = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return affectedRows;

        }

        static public Int32 ActualizarCliente(Clientes obj)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPUclientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@Id_cte";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Direction = ParameterDirection.Input;
                parIdCliente.Value = obj.Id_cte;
                cmd.Parameters.Add(parIdCliente);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre_cte";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Direction = ParameterDirection.Input;
                parNombre.Value = obj.Nombre_cte;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@Direccion_cte";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Direction = ParameterDirection.Input;
                parDireccion.Value = obj.Direccion_cte;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@Telefono_cte";
                parTelefono.SqlDbType = SqlDbType.Char;
                parTelefono.Direction = ParameterDirection.Input;
                parTelefono.Value = obj.Telefono_cte;
                cmd.Parameters.Add(parTelefono);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@Email_cte";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Direction = ParameterDirection.Input;
                parEmail.Value = obj.Email_cte;
                cmd.Parameters.Add(parEmail);

                SqlParameter parFechaNacimiento = new SqlParameter();
                parFechaNacimiento.ParameterName = "@FechaNacimiento_cte";
                parFechaNacimiento.SqlDbType = SqlDbType.Date;
                parFechaNacimiento.Direction = ParameterDirection.Input;
                parFechaNacimiento.Value = obj.FechaNacimiento_cte;
                cmd.Parameters.Add(parFechaNacimiento);

                SqlParameter parRFC = new SqlParameter();
                parRFC.ParameterName = "@RFC_cte";
                parRFC.SqlDbType = SqlDbType.VarChar;
                parRFC.Direction = ParameterDirection.Input;
                parRFC.Value = obj.RFC_cte;
                cmd.Parameters.Add(parRFC);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    obj.Id_cte = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
                }

            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return affectedRows;

        }

        static public List<Clientes> SeleccionarClientes(Int32? Id_cte, String Nombre_cte, String RFC_cte)
        {
            List<Clientes> ClientesList = new List<Clientes>();

            try
            {

                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPSclientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@Id_cte";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Direction = ParameterDirection.Input;
                parIdCliente.Value = Id_cte;
                cmd.Parameters.Add(parIdCliente);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre_cte";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Direction = ParameterDirection.Input;
                parNombre.Value = String.IsNullOrEmpty(Nombre_cte) ? null : Nombre_cte;
                cmd.Parameters.Add(parNombre);

                SqlParameter parRFC = new SqlParameter();
                parRFC.ParameterName = "@RFC_cte";
                parRFC.SqlDbType = SqlDbType.VarChar;
                parRFC.Direction = ParameterDirection.Input;
                parRFC.Value = String.IsNullOrEmpty(RFC_cte) ? null : RFC_cte;
                cmd.Parameters.Add(parRFC);

                con.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr != null)
                {

                    while (dr.Read())
                    {
                        Clientes cte = new Clientes();

                        cte.Id_cte = Convert.ToInt32(dr["Id_cte"].ToString());
                        cte.Nombre_cte = dr["Nombre_cte"].ToString();
                        cte.Direccion_cte = dr["Direccion_cte"].ToString();
                        cte.Telefono_cte = dr["Telefono_cte"].ToString();
                        cte.Email_cte = dr["Email_cte"].ToString();
                        cte.FechaNacimiento_cte = Convert.ToDateTime(dr["FechaNacimiento_cte"].ToString());
                        cte.RFC_cte = dr["RFC_cte"].ToString();

                        ClientesList.Add(cte);

                    }

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return ClientesList;
        }

    }
}