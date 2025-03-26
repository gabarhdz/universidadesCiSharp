using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace universidades
{
    public partial class usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            UsuarioSistema usuarioSistema = new UsuarioSistema();
            List<UsuarioSistema> listadeusuariosSistemaenBD = new List<UsuarioSistema> ();
            foreach(UsuarioSistema us in usuarioSistema.seleccionarTodosBD())
            {
                listadeusuariosSistemaenBD.Add(us);
            }

            var datosFiltrados  = listadeusuariosSistemaenBD.Select(p => new
            {
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email
            }).ToList();
            GrillaUsuariosSistemas.DataSource = datosFiltrados;
            GrillaUsuariosSistemas.DataBind();
        }

        protected void Gridview1_clickfila(object sender, EventArgs e) 
        {
             Button btn = sender as Button;
            if (btn != null) {
                int id = int.Parse(btn.CommandArgument);
                UsuarioSistema us = new UsuarioSistema();
                us.Id = id;
                us.eliminarBD();
                cargarGrilla();
            }

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
                cargarGrilla();
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