<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WabiSabiWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        Carrito:</p>
    <p class="auto-style1">
        -(Imagen) Precio Ud. x Cantidad
        <asp:Button ID="Button2" runat="server" Height="19px" Text="Eliminar" Width="65px" />
        <asp:Button ID="Button3" runat="server" Height="19px" Text="+1" Width="40px" />
    </p>
    <p class="auto-style1">
        Total:(coste total del pedido)</p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" Text="Tramitar Pedido" OnClick="Button1_Click" />
    </p>
</asp:Content>
