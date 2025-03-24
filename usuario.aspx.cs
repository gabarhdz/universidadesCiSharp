using System;
using System.Web.UI;

namespace universidades
{
    public partial class usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de UsuarioSistema con los valores de los TextBox
                UsuarioSistema usuarioSistema = new UsuarioSistema(
                    0,
                    txt_nombre.Text,
                    txt_apellido.Text,
                    txt_email.Text,
                    ""
                );
                usuarioSistema.Contrasena = txt_contrasena.Text;      
                // Insertar en  la base de datos
                usuarioSistema.insertarBD();

                // Mensaje de éxito
                lbl_mensaje.Text = "Usuario registrado correctamente.";
                lbl_mensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                // Mostrar error en caso de fallo
                lbl_mensaje.Text = "Error: " + ex.Message;
                lbl_mensaje.ForeColor = System.Drawing.Color.Red;
            }


        }
    }
}