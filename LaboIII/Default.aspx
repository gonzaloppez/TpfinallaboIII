<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LaboIII._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Panel runat="server" ID="pnlPedidos_X_plato">
            <asp:GridView ID="gvdPedidos" runat="server" AutoGenerateColumns="true">                 
            </asp:GridView>
        </asp:Panel>

        <asp:Label Text="Ingrese ID de plato" runat="server" />
        <asp:TextBox ID="txtIDPlato" runat="server" />
        <asp:Button Text="Aceptar" OnClick="btnAceptar" runat="server" />

        <div class="jumbotron">
        <asp:Panel runat="server" ID="Panel1">
            <asp:GridView ID="gvdRecaudacionPorPlato" runat="server" AutoGenerateColumns="true">                 
            </asp:GridView>
        </asp:Panel>

</asp:Content>
