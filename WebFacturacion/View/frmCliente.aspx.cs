using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFacturacion.BussinesObjects;

namespace WebFacturacion.View
{
    public partial class frmCliente : System.Web.UI.Page
    {

        #region Properties

        public List<Clientes> ClienteList
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public Int32 InsertarCliente(Clientes obj)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = DAL.ClientesDAL.InsertarCliente(obj);

                if (affectedRows > 0)
                {
                    //Mandar mensaje

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return affectedRows;

        }

        public List<Clientes> SeleccionarClientes(Int32? Id_cte, String Nombre_cte, String RFC_cte)
        {
            List<Clientes> ClientesList = new List<Clientes>();

            try
            {
                ClientesList = DAL.ClientesDAL.SeleccionarClientes(Id_cte, Nombre_cte, RFC_cte);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ClientesList;
        }

        public Int32 ActualizarCliente(Clientes obj)
        {
            Int32 affectedRows = 0;
            try
            {
                affectedRows = DAL.ClientesDAL.ActualizarCliente(obj);
                if (affectedRows > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }
            return affectedRows;
        }

        public Int32 BorrarCliente(Int32 Id_cte, String Nombre_cte)
        {

            Int32 affectedRows = 0;

            try
            {
                affectedRows = DAL.ClientesDAL.BorrarCliente(Id_cte, Nombre_cte);


                if (affectedRows > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }

            return affectedRows;
        }

        public void RellenarGridClientes(List<Clientes> ClienteList)
        {
            try
            {
                gridClientes.DataSource = ClienteList;
                gridClientes.DataBind();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {

            gridClientes.RowStyle.HorizontalAlign = HorizontalAlign.Center;

            try
            {
                if (!Page.IsPostBack)
                {
                    Int32? Id_cte = null;
                    String Nombre_cte = "";
                    String RFC_cte = "";

                    ClienteList = new List<Clientes>();
                    ClienteList = SeleccionarClientes(Id_cte, Nombre_cte, RFC_cte);

                    RellenarGridClientes(ClienteList);
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
                Clientes obj = new Clientes();
                obj.Nombre_cte = tbxNombreCliente.Text;
                obj.Direccion_cte = tbxDireccionCliente.Text;
                obj.Telefono_cte = tbxTelefonoCliente.Text;
                obj.RFC_cte = tbxRFC.Text;
                obj.Email_cte = tbxEmail.Text;
                obj.FechaNacimiento_cte = Convert.ToDateTime(tbxFechaNacimiento.Text);

                Int32 affectedRows = 0;

                affectedRows = InsertarCliente(obj);

                if (affectedRows > 0)

                {
                    lblmensaje.Text = "¡Registros añadidos correctamente!";

                    tbxNombreCliente.Text = String.Empty;
                    tbxDireccionCliente.Text = String.Empty;
                    tbxEmail.Text = String.Empty;
                    tbxRFC.Text = String.Empty;
                    tbxTelefonoCliente.Text = String.Empty;
                    tbxFechaNacimiento.Text = String.Empty;

                    gridClientes.DataSource = ClienteList;
                    gridClientes.DataBind();

                    Int32? Id_cte = null;
                    String Nombre_cte = "";
                    String RFC_cte = "";

                    ClienteList = new List<Clientes>();
                    ClienteList = SeleccionarClientes(Id_cte, Nombre_cte, RFC_cte);

                    RellenarGridClientes(ClienteList);

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

                Int32? Id_cte = null;
                String Nombre_cte = "";
                String RFC_cte = "";

                ClienteList = new List<Clientes>();
                ClienteList = SeleccionarClientes(Id_cte, Nombre_cte, RFC_cte);

                RellenarGridClientes(ClienteList);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombreCliente.Text = String.Empty;
            tbxDireccionCliente.Text = String.Empty;
            tbxEmail.Text = String.Empty;
            tbxRFC.Text = String.Empty;
            tbxTelefonoCliente.Text = String.Empty;
            tbxFechaNacimiento.Text = String.Empty;
            lblmensaje.Text = String.Empty;

            gridClientes.DataSource = null;
            gridClientes.DataBind();

        }

        #endregion

    }
}