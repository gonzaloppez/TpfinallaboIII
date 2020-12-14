<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="LaboIII.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
  <div class="jumbotron">
        <asp:Panel runat="server" ID="pnlPlatos">
            <asp:GridView ID="gvdPlatos" runat="server" AutoGenerateColumns="true">                 
            </asp:GridView>
            <asp:Button ID="btnNuevo" Text="Nuevo Plato" runat="server" OnClick="btnNuevo_Click" />
        </asp:Panel>
       
      <asp:Panel ID="pnlAltaPlato" runat="server" Visible="false">
            <div>
                <asp:Label ID="LblID" Text="ID" runat="server"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" />
            </div>           
            <div>
                <asp:Label ID="lblNombre" Text="Nombre" runat="server"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblPrecio" Text="Precio " runat="server"></asp:Label>
                <asp:TextBox ID="txtPrecio" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblIDPlato" Text="IDPlato" runat="server" />
                <asp:TextBox ID="txtIDPlato" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblDescripcion" Text="Descripcion" runat="server" />
                <asp:TextBox ID="txtDescripcion" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblMail" Text="Mail" runat="server" />
                <asp:TextBox ID="txtEmail" runat="server" />
            </div>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar Plato" OnClick="btnGuardar_Click" />
        </asp:Panel>
    </div>

</asp:Content>
