<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Página de usuarios</h1>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Alergenos" OnClick="Alergenos"/>
        <asp:Button ID="Button2" runat="server" Text="Carrito" OnClick="Carrito"/>
        <asp:Button ID="Button3" runat="server" Text="Menu" OnClick="Menu"/>
        <asp:Button ID="Button4" runat="server" Text="Oferta" OnClick="Oferta"/>
        <asp:Button ID="Button5" runat="server" Text="Orden" OnClick="Orden"/>
        <asp:Button ID="Button6" runat="server" Text="Pedido" OnClick="Pedido"/>
        <asp:Button ID="Button7" runat="server" Text="Producto" OnClick="Producto"/>
        <asp:Button ID="Button8" runat="server" Text="Reseña" OnClick="Reseña"/>
        <asp:Button ID="Button9" runat="server" Text="Suscripcion" OnClick="Suscripcion"/>
        <asp:Button ID="Button10" runat="server" Text="Usuario" OnClick="Usuario"/>

        <br />
        <asp:Label ID="LabelRespuesta" runat="server"></asp:Label>

    </div>
</asp:Content>