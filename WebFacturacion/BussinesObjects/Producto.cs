using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFacturacion.BussinesObjects
{
    public class Producto
    {

        public Int32 Id_prod
        {
            get;
            set;
        }

        public String Descripcion_prod
        {
            get;
            set;
        }

        public Decimal Precio_prod
        {
            get;
            set;
        }

        public DateTime FechaCaducidad_prod
        {
            get;
            set;
        }

        public String CodigoBarras_prod
        {
            get;
            set;
        }

        public String Proveedor_prod
        {
            get;
            set;
        }

    }
}