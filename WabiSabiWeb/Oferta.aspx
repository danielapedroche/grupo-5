<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Oferta.aspx.cs" Inherits="WabiSabiWeb.Oferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Ofertas</h1>
    </div>
    <div>
        Codigo:
        <asp:TextBox ID="Codigo" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Nombre
        <asp:TextBox ID="Tipo" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Descripcion:
        <asp:TextBox ID="Descripcion" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Leer" runat="server" Text="Leer" OnClick="Read_Click" />
        &nbsp;
        <asp:Button ID="Crear" runat="server" Text="Crear" OnClick="Create_Click"/>
        &nbsp;
        <asp:Button ID="Actualizar" runat="server" Text="Actualizar" OnClick="Update_Click"/>
        &nbsp;
        <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Delete_Click"/>
        <br />
        <asp:label ID="LabelRespuesta" runat="server" Text=" " />
    </div>
</asp:Content>
