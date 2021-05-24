<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="WabiSabiWeb.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Producto</h1>
    </div>
    <div>
        Codigo:
        <asp:TextBox ID="Codigo" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Nombre
        <asp:TextBox ID="Nombre" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Descripcion
        <asp:TextBox ID="Descripcion" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Precio:
        <asp:TextBox ID="Precio" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <asp:Button ID="Leer" runat="server" Text="Leer" OnClick="Leer_Click" />
        &nbsp;
        <asp:Button ID="Crear" runat="server" Text="Crear" OnClick="Crear_Click"/>
        &nbsp;
        <asp:Button ID="Actualizar" runat="server" Text="Actualizar" OnClick="Actualizar_Click"/>
        &nbsp;
        <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Borrar_Click"/>
        <br />
        <asp:label ID="LabelRespuesta" runat="server" Text=" " />
    </div>
</asp:Content>
