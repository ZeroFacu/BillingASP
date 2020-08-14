using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.DAL
{
    static public class ProductoDAL
    {
        static public SqlConnection con;

        static public Int32 InsertarProducto(Producto obj)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPIproductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_prod";
                parIdProducto.DbType = DbType.Int32;
                parIdProducto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@Descripcion_prod";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Direction = ParameterDirection.Input;
                parDescripcion.Value = obj.Descripcion_prod;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parPrecio = new SqlParameter();
                parPrecio.ParameterName = "@Precio_prod";
                parPrecio.SqlDbType = SqlDbType.Decimal;
                parPrecio.Direction = ParameterDirection.Input;
                parPrecio.Value = obj.Precio_prod;
                cmd.Parameters.Add(parPrecio);

                SqlParameter parFechaCaducidad = new SqlParameter();
                parFechaCaducidad.ParameterName = "@FechaCaducidad_prod";
                parFechaCaducidad.SqlDbType = SqlDbType.Date;
                parFechaCaducidad.Direction = ParameterDirection.Input;
                parFechaCaducidad.Value = obj.FechaCaducidad_prod;
                cmd.Parameters.Add(parFechaCaducidad);

                SqlParameter parCodigoBarras = new SqlParameter();
                parCodigoBarras.ParameterName = "@CodigoBarras_prod";
                parCodigoBarras.SqlDbType = SqlDbType.VarChar;
                parCodigoBarras.Direction = ParameterDirection.Input;
                parCodigoBarras.Value = obj.CodigoBarras_prod;
                cmd.Parameters.Add(parCodigoBarras);

                SqlParameter parProveedor = new SqlParameter();
                parProveedor.ParameterName = "@Proveedor_prod";
                parProveedor.SqlDbType = SqlDbType.VarChar;
                parProveedor.Direction = ParameterDirection.Input;
                parProveedor.Value = obj.Proveedor_prod;
                cmd.Parameters.Add(parProveedor);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    obj.Id_prod = Convert.ToInt32(cmd.Parameters["@Id_prod"].Value);
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

        static public Int32 BorrarProducto(Int32 Id_prod)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPDproductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_prod";
                parIdProducto.DbType = DbType.Int32;
                parIdProducto.Direction = ParameterDirection.Input;
                parIdProducto.Value = Id_prod;
                cmd.Parameters.Add(parIdProducto);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    Id_prod = Convert.ToInt32(cmd.Parameters["@Id_prod"].Value);
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

        static public Int32 ActualizarProducto(Producto obj)
        {

            Int32 affectedRows = 0;

            try
            {
                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPUproductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_prod";
                parIdProducto.DbType = DbType.Int32;
                parIdProducto.Direction = ParameterDirection.Input;
                parIdProducto.Value = obj.Id_prod;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@Descripcion_prod";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Direction = ParameterDirection.Input;
                parDescripcion.Value = obj.Descripcion_prod;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parPrecio = new SqlParameter();
                parPrecio.ParameterName = "@Precio_prod";
                parPrecio.SqlDbType = SqlDbType.Decimal;
                parPrecio.Direction = ParameterDirection.Input;
                parPrecio.Value = obj.Precio_prod;
                cmd.Parameters.Add(parPrecio);

                SqlParameter parFechaCaducidad = new SqlParameter();
                parFechaCaducidad.ParameterName = "@FechaCaducidad_prod";
                parFechaCaducidad.SqlDbType = SqlDbType.Date;
                parFechaCaducidad.Direction = ParameterDirection.Input;
                parFechaCaducidad.Value = obj.FechaCaducidad_prod;
                cmd.Parameters.Add(parFechaCaducidad);

                SqlParameter parCodigoBarras = new SqlParameter();
                parCodigoBarras.ParameterName = "@CodigoBarras_prod";
                parCodigoBarras.SqlDbType = SqlDbType.VarChar;
                parCodigoBarras.Direction = ParameterDirection.Input;
                parCodigoBarras.Value = obj.CodigoBarras_prod;
                cmd.Parameters.Add(parCodigoBarras);

                SqlParameter parProveedor = new SqlParameter();
                parProveedor.ParameterName = "@Proveedor_prod";
                parProveedor.SqlDbType = SqlDbType.VarChar;
                parProveedor.Direction = ParameterDirection.Input;
                parProveedor.Value = obj.Proveedor_prod;
                cmd.Parameters.Add(parProveedor);

                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    obj.Id_prod = Convert.ToInt32(cmd.Parameters["@Id_prod"].Value);
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

        static public List<Producto> SeleccionarProducto(Int32? Id_prod, String Descripcion_prod)
        {
            List<Producto> ProductoList = new List<Producto>();

            try
            {

                String conStr = DAL.DBManager.GetConnectionString("WebFacturacion");
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SPSproductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@Id_prod";
                parIdProducto.DbType = DbType.Int32;
                parIdProducto.Direction = ParameterDirection.Input;
                parIdProducto.Value = Id_prod;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@Descripcion_prod";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Direction = ParameterDirection.Input;
                parDescripcion.Value = String.IsNullOrEmpty(Descripcion_prod) ? null : Descripcion_prod;
                cmd.Parameters.Add(parDescripcion);

                con.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr != null)
                {

                    while (dr.Read())
                    {
                        Producto prod = new Producto();

                        prod.Id_prod = Convert.ToInt32(dr["Id_prod"].ToString());
                        prod.Descripcion_prod = dr["Descripcion_prod"].ToString();
                        prod.Precio_prod = Convert.ToDecimal(dr["Precio_prod"].ToString());
                        prod.FechaCaducidad_prod = Convert.ToDateTime(dr["FechaCaducidad_prod"].ToString());
                        prod.CodigoBarras_prod = dr["CodigoBarras_prod"].ToString();
                        prod.Proveedor_prod = dr["Proveedor_prod"].ToString();

                        ProductoList.Add(prod);

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

            return ProductoList;
        }

    }
}