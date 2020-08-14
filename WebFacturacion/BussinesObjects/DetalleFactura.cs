using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFacturacion.BussinesObjects
{
    public class DetalleFactura
    {

        public Int32 Folio_fact
        {
            get;
            set;
        }

        public Int32 Consecutivo_det
        {
            get;
            set;
        }

        public Int32 Id_prod
        {
            get;
            set;
        }

        public Int32 Cantidad_det
        {
            get;
            set;
        }

        public Decimal SubTotal_det
        {
            get;
            set;
        }

    }
}