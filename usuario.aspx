<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="universidades.usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f5f5f5;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            -moz-animation-iteration-count:4s;
        }
        
        #form1 {
            background: linear-gradient(to bottom right, #ffffff, #e6f0fa);
            border-radius: 10px;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
            padding: 30px;
            width: 400px;
        }
        
        .header {
            background: linear-gradient(135deg, #2c5282, #4299e1);
            color: white;
            font-size: 24px;
            font-weight: 600;
            text-align: center;
            padding: 15px;
            margin: -30px -30px 20px -30px;
            border-radius: 10px 10px 0 0;
        }
        
        p {
            color: #4a5568;
            font-weight: 500;
            margin-bottom: 5px;
            margin-top: 15px;
        }
        
        input[type="text"],
        input[type="email"],
        input[type="password"] {
            width: 100%;
            padding: 12px;
            border: 1px solid #cbd5e0;
            border-radius: 5px;
            font-size: 16px;
            box-sizing: border-box;
            transition: border 0.3s ease;
        }
        
        input[type="text"]:focus,
        input[type="email"]:focus,
        input[type="password"]:focus {
            border: 1px solid #4299e1;
            outline: none;
            box-shadow: 0 0 0 3px rgba(66, 153, 225, 0.3);
        }
        
        .boton-submit {
            background: linear-gradient(to right, #2c5282, #4299e1);
            color: white;
            border: none;
            border-radius: 5px;
            padding: 12px 20px;
            font-size: 16px;
            font-weight: 600;
            cursor: pointer;
            width: 100%;
            margin-top: 20px;
            transition: transform 0.2s ease;
        }
        
        .boton-submit:hover {
            transform: translateY(-2px);
            box-shadow: 0 4px 8px rgba(44, 82, 130, 0.3);
        }
        .btn-borrar {
            background-color: red;
            color: white;
        }
        
        [id$=lbl_mensaje] {
            display: block;
            font-size: 14px;
            margin-top: 15px;
            text-align: center;
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
        <p>
            Email
        </p>
        <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
        <p>
            contrasena</p>
        <p>
            <asp:TextBox ID="txt_contrasena" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
             <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" CssClass="boton-submit" />
        </p>
        <p>
            <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Red"></asp:Label>
        </p>
        </div>

        <asp:GridView runat="server" ID="GrillaUsuariosSistemas">
    <Columns>
        <asp:TemplateField HeaderText="Acciones">
            <ItemTemplate>
                <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CommandName="Eliminar" OnClick="Gridview1_clickfila" cssClass="btn-borrar" CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    </form>

    
    >
</body>
</html>
