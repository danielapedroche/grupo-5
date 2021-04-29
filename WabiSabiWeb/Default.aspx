<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WabiSabiWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1> Página de usuarios</h1>
    <div>
        <p>
            NIF:<asp:TextBox ID="TextBox4" Textmode="SingleLine" Columns="30" runat="server"></asp:TextBox>
        </p>
        <p>
            Nombre:<asp:TextBox ID="TextBox5" Textmode="SingleLine" Columns="30" runat="server"></asp:TextBox>
        </p>
        <p>
            Edad:<asp:TextBox ID="TextBox6" Textmode="SingleLine" Columns="30" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button8" runat="server" Text="Leer" OnClick="Leer"/>
        <asp:Button ID="Button9" runat="server" Text="Leer Primero" OnClick="LeerPrimero"/>
        <asp:Button ID="Button10" runat="server" Text="Leer Anterior" OnClick="LeerAnterior"/>
        <asp:Button ID="Button11" runat="server" Text="Leer Siguiente" OnClick="LeerSiguiente"/>
        <asp:Button ID="Button12" runat="server" Text="Crear" OnClick="Crear"/>
        <asp:Button ID="Button13" runat="server" Text="Actualizar" OnClick="Actualizar"/>
        <asp:Button ID="Button14" runat="server" Text="Borrar" OnClick="Borrar"/>

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </div>
 </asp:Content>