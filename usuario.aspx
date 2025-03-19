<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="universidades.usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-color:#32ee87;
            font-family:'Comic Sans MS';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre</div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Apellido</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Email<br />
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Email"></asp:TextBox>
        <p>
            Clave</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
