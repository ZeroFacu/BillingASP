using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.DAL
{
    static public class DetalleFacturaDAL
    {

        static public Int32 InsertarDetalleFactura(DetalleFactura obj)
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

        static public Int32 BorrarDetalleFactura(Int32 Folio_fact, Int32 Consecutivo_det)
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

        static public Int32 ActualizarDetalleFactura(DetalleFactura obj)
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

        static public List<DetalleFactura> SeleccionarDetalleFactura(Int32 Folio_fact, Int32 Consecutivo_det, Int32 Id_prod, Int32 Cantidad_det, Decimal SubTotal_det)
        {
            List<DetalleFactura> DetalleFacturaList = new List<DetalleFactura>();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return DetalleFacturaList;
        }

    }
}