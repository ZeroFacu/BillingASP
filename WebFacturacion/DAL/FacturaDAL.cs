using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.DAL
{
    static public class FacturaDAL
    {

        static public Int32 InsertarFactura(Factura obj)
        {

            Int32 affectedRows = 0;

            try
            {
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return affectedRows;

        }

        static public Int32 BorrarFactura(Int32 Folio_fact)
        {

            Int32 affectedRows = 0;

            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return affectedRows;

        }

        static public Int32 ActualizarFactura(Factura obj)
        {

            Int32 affectedRows = 0;

            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return affectedRows;

        }

        static public List<Factura> SeleccionarFactura(Int32 Folio_fact, Int32 Id_cte, DateTime Fecha_cte, Decimal Total_fact)
        {
            List<Factura> FacturaList = new List<Factura>();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return FacturaList;
        }

    }
}