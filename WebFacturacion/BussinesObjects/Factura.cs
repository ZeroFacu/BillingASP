using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFacturacion.BussinesObjects
{
    public class Factura
    {

        public Int32 Folio_fact
        {
            get;
            set;
        }

        public Int32 Id_cte
        {
            get;
            set;
        }

        public DateTime Fecha_cte
        {
            get;
            set;
        }

        public Decimal Total_fact
        {
            get;
            set;
        }
    }
}