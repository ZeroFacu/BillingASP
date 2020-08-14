<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="WebFacturacion.View.frmProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Productos</title>
    <link rel="icon" type="image/png" sizes="180x180" href="assets/images/favicon.png">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">         
    <link rel="stylesheet" href="assets/css/overrides.css">
    <link rel="stylesheet" href="assets/css/smoothproducts.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Montserrat:400,400i,700,700i,600,600i">    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.min.css">
</head>
<body>

     <!-- Navbar-->   
    <nav class="navbar navbar-light navbar-expand-lg fixed-top bg-white clean-navbar">

    <!-- Logo -->      
    <div class="container"><a class="navbar-brand logo" href="#"><img id="logo" src="assets/images/logo.png"></a>      

     <div
     class="collapse navbar-collapse" id="navcol-1">
     <ul class="nav navbar-nav ml-auto">
     <li class="nav-item" role="presentation"><a class="nav-link">@FACUNDO&nbsp;<i class="fa fa-user-circle"></i></a></li>
     <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Menú</a>
     <div class="dropdown-menu" role="menu"><a class="dropdown-item" role="presentation" href="#">Cerrar Sesión</a>
     </li>
     </ul>
     </div>
     </div>
     </nav>
    <!-- Navbar End-->   

     <!-- Text Info -->
     <main class="page contact-us-page">
     <div class="container">
     <div class="block-heading">
     </div>

        <center><form id="form1" runat="server">
        <div>

        <div class="desing"><br /><br />
        <asp:Label ID = "lblDescripcion" runat = "server" Text = "Descripción del producto: " Width="200px" Font-Names="Bahnschrift"></asp:Label>
        <asp:TextBox ID = "tbxDescripcion" style="text-align:center" runat = "server" Text = "" Width="300px"></asp:TextBox>
        </div>

        <div class="desing">
        <asp:Label ID = "lblPrecio" runat = "server" Text = "Precio del producto: " Width="200px" Font-Names="Bahnschrift"></asp:Label>
        <asp:TextBox ID = "tbxPrecio" style="text-align:center" runat = "server" Text = "" Width="300px"></asp:TextBox>
        </div>

        <div class="desing">
        <asp:Label ID = "lblFechaCaducidad" runat = "server" Text = "Fecha de caducidad: " Width="200px" Font-Names="Bahnschrift"></asp:Label>
        <asp:TextBox ID = "tbxFechaCaducidad" style="text-align:center" runat = "server" Text = "" Width="300px"></asp:TextBox>
        </div>

        <div class="desing">
        <asp:Label ID = "lblCodigoBarras" runat = "server" Text = "Codigo de barras: " Width="200px" Font-Names="Bahnschrift"></asp:Label>
        <asp:TextBox ID = "tbxCodigoBarras" style="text-align:center" runat = "server" Text = "" Width="300px"></asp:TextBox>
        </div>

        <div class="desing">
        <asp:Label ID = "lblProveedor" runat = "server" Text = "Proveedor del producto: " Width="200px" Font-Names="Bahnschrift"></asp:Label>
        <asp:TextBox ID = "tbxProveedor" style="text-align:center" runat = "server" Text = "" Width="300px"></asp:TextBox>
        </div>

        <div><br>
        <asp:Label ID = "lblmensaje" runat = "server" Text = ""></asp:Label>
        </div><br>

        <div class="desing">
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
        </div>

        <div><br />
            <asp:GridView ID="gridProductos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" DataKeyNames="Id_prod">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="Id_prod" HeaderText="Id. Producto" InsertVisible="False" ReadOnly="True" SortExpression="Id_prod" />
                    <asp:BoundField DataField="Descripcion_prod" HeaderText="Descripción del producto" SortExpression="Descripcion_prod" />
                    <asp:BoundField DataField="Precio_prod" HeaderText="Precio del producto" SortExpression="Precio_prod" />
                    <asp:BoundField DataField="Proveedor_prod" HeaderText="Proveedor del producto" SortExpression="Proveedor_prod" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView><br />

        </center>
        </div>

        </div>
    </form>
  </main>
    
    <!-- Footer Dark -->
    <footer class="page-footer dark">
    <div class="container">
    <div class="row">
    <div class="col-sm-12" align="center">
    <li><a href="#"><i class="fa fa-envelope-o"></i>&nbsp;info@cesunbc.edu.mx<br></a></li><p>
    <li><a href="#"><i class="fa fa-phone"></i>&nbsp;+52 (664) 686 1601<br></a></li>
    </div>
    </div>
    </div>

    <!-- Footer Copyright -->
    <div class="footer-copyright">
    <p>© Cesun Universidad</p>
    </div>
    </footer>


    <!-- JavaScript -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.js"></script>
    <script src="assets/js/smoothproducts.min.js"></script>
    <script src="assets/js/theme.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/i18n/defaults-*.min.js"></script>
    <!-- Final JavaScript -->

</body>
</html>
