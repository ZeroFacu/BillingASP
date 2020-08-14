using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.View
{
    public partial class frmProducto : System.Web.UI.Page
    {

        #region Properties
        public List<Producto> ProductoList
        {
            get;
            set;
        }
        #endregion

        #region Methods

        public Int32 InsertarProducto(Producto obj)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = DAL.ProductoDAL.InsertarProducto(obj);

                if (affectedRows > 0)
                {
                    //mandar mensaje
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return affectedRows;
        }

        public List<Producto> SeleccionarProducto(Int32? Id_prod, String Descripcion_prod)
        {
            List<Producto> ProductoList = new List<Producto>();
            try
            {
                ProductoList = DAL.ProductoDAL.SeleccionarProducto(Id_prod, Descripcion_prod);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ProductoList;
        }

        public Int32 ActualizarProducto(Producto obj)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = DAL.ProductoDAL.ActualizarProducto(obj);

                if (affectedRows > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }

            return affectedRows;
        }

        public Int32 BorrarProducto(Int32 Id_prod)
        {

            Int32 affectedRows = 0;

            try
            {
                affectedRows = DAL.ProductoDAL.BorrarProducto(Id_prod);


                if (affectedRows > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }

            return affectedRows;
        }

        public void rellenarGridProductos(List<Producto> ProductoList)
        {
            try
            {
                gridProductos.DataSource = ProductoList;
                gridProductos.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            gridProductos.RowStyle.HorizontalAlign = HorizontalAlign.Center;

            try
            {
                if (!Page.IsPostBack)
                {

                    Int32? Id_prod = null;
                    String Descripcion_prod = "";

                    ProductoList = new List<Producto>();
                    ProductoList = SeleccionarProducto(Id_prod, Descripcion_prod);

                    rellenarGridProductos(ProductoList);
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto obj = new Producto();
                obj.Descripcion_prod = tbxDescripcion.Text;
                obj.Precio_prod = Convert.ToDecimal(tbxPrecio.Text);
                obj.FechaCaducidad_prod = Convert.ToDateTime(tbxFechaCaducidad.Text);
                obj.CodigoBarras_prod = tbxCodigoBarras.Text;
                obj.Proveedor_prod = tbxProveedor.Text;

                Int32 affectedRows = 0;

                affectedRows = InsertarProducto(obj);

                if (affectedRows > 0)
                {
                    lblmensaje.Text = "¡Registros añadidos correctamente!";

                    tbxDescripcion.Text = String.Empty;
                    tbxPrecio.Text = String.Empty;
                    tbxFechaCaducidad.Text = String.Empty;
                    tbxCodigoBarras.Text = String.Empty;
                    tbxProveedor.Text = String.Empty;

                    gridProductos.DataSource = null;
                    gridProductos.DataBind();

                    Int32? Id_prod = null;
                    String Descripcion_prod = "";

                    ProductoList = new List<Producto>();
                    ProductoList = SeleccionarProducto(Id_prod, Descripcion_prod);

                    rellenarGridProductos(ProductoList);
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32? Id_prod = null;
                String Descripcion_prod = "";

                ProductoList = new List<Producto>();
                ProductoList = SeleccionarProducto(Id_prod, Descripcion_prod);

                rellenarGridProductos(ProductoList);
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxDescripcion.Text = String.Empty;
            tbxPrecio.Text = String.Empty;
            tbxFechaCaducidad.Text = String.Empty;
            tbxCodigoBarras.Text = String.Empty;
            tbxProveedor.Text = String.Empty;
            lblmensaje.Text = String.Empty;

            gridProductos.DataSource = null;
            gridProductos.DataBind();
        }
        #endregion
    }
}