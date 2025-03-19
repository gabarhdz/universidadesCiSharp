<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="universidades.usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-color:#abcabc;
            font-family:'Helvetica';
        }
        div {
            background-color: #303e5c;
            border-radius:15px;
        }
        p {
            color: white;
        }
        .header {
            background-color: #454545;
            color: white;
            border-radius:0px;
            text-align: center;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
                Formulario de registro
            </div>
        <p>
          Nombre
        </p>
            
        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        
        <p>
            Apellido</p>
        <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <p>
            Email
        </p>
        <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
        <p>
            contrasena</p>
        <p>
            <asp:TextBox ID="txt_contrasena" runat="server"></asp:TextBox>
        </p>
        <p>
             <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
        </p>
        </div>
    </form>
</body>
</html>
