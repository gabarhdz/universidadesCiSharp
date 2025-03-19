using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace universidades
{
	public partial class usuario : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
                    }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            UsuarioSistema usuarioSistema = new UsuarioSistema(0, txt_nombre.Text, txt_apellido.Text, txt_email.Text);
            usuarioSistema.contrasena = txt_contrasena.Text;
            usuarioSistema.insertarBD();
        }

    }
}