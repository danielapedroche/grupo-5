<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="WabiSabiWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        Resumen de tu pedido:</p>
    <p class="auto-style1">
        Domicilio: (Añadir domicilio del usuario)</p>
    <p class="auto-style1">
        Seleccione un método de pago:</p>
    <asp:CheckBox ID="Efectivo" runat="server" />
    Efectivo<asp:CheckBox ID="PayPal" runat="server" />
    PayPal<asp:CheckBox ID="Tarjeta" runat="server" />
     Tarjeta<p class="auto-style1">
         Código promocional:</p>
    <p class="auto-style1">
        <asp:TextBox ID="Codigo" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        Observaciones:</p>
    <p class="auto-style1">
        <asp:TextBox ID="Observaciones" runat="server" Height="65px" Width="227px"></asp:TextBox>
    </p>
    <p class="auto-style1">
        (Nº total de productos)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio: (Precio Total)</p>
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style1">
        <asp:Button ID="ConfirmarPedido" runat="server" Text="Confirmar Pedido" />
    </p>
</asp:Content>