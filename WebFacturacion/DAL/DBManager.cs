using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.DAL
{
    public static class DBManager
    {

        public static String GetConnectionString(String bd)
        {

            String strCon = "";

            try
            {
                strCon = System.Configuration.ConfigurationManager.ConnectionStrings[bd].ConnectionString;
            }
            catch (Exception ex)
            {
            }

            return strCon;

        }

    }
}