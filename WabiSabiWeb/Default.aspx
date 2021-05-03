<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WabiSabiWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 class="auto-style1"> BIENVENIDOS A WABISABI</h1>
        <div>
        <asp:Button ID="Button1" runat="server" Text="Alergenos" OnClick="Alergenos_Click"/> 
        <asp:Button ID="Button2" runat="server" Text="Carrito" OnClick="Carrito_Click"/>
        <asp:Button ID="Button3" runat="server" Text="Menu" OnClick="Menu_Click"/>
        <asp:Button ID="Button4" runat="server" Text="Oferta" OnClick="Oferta_Click"/>
        <asp:Button ID="Button5" runat="server" Text="Orden" OnClick="Orden_Click"/> 
        <asp:Button ID="Button6" runat="server" Text="Pedido" OnClick="Pedido_Click"/>
        <asp:Button ID="Button7" runat="server" Text="Producto" OnClick="Producto_Click"/>
        <asp:Button ID="Button8" runat="server" Text="Reseña" OnClick="Reseña_Click"/>
        <asp:Button ID="Button9" runat="server" Text="Suscripcion" OnClick="Suscripcion_Click"/>
        <asp:Button ID="Button10" runat="server" Text="Usuario" OnClick="Usuario_Click"/>

        <br />
        <asp:Label ID="LabelRespuesta" runat="server"></asp:Label>

    </div>
 </asp:Content>