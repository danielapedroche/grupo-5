<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="WabiSabiWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Ofertas</h1>
    </div>
    <div>
        NIF
        <asp:TextBox ID="Codigo" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Nombre
        <asp:TextBox ID="Tipo" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Apellidos
        <asp:TextBox ID="Descripcion" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Email
        <asp:TextBox ID="TextBox1" runat="server"  Width="173px"></asp:TextBox>
        <br />
        <br />
        Contraseña
        <asp:TextBox ID="TextBox2" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        Telefono
        <asp:TextBox ID="TextBox3" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Direccion
        <asp:TextBox ID="TextBox4" runat="server"  Width="173px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;
        <br />
        FechaNac
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
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
