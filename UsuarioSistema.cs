using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace universidades
{
	public class UsuarioSistema : Persona
	{
		private String contrasena;
		public UsuarioSistema()
		{

		}

        public UsuarioSistema(int id, string nombre, string apellido, string email, string telefono) : base(id, nombre, apellido, email, telefono)
        {
        }
        public String contrasena { get => contrasena; set => contrasena = value; }

        public new void insertarBD()
		{
            //insertar en la base de datos
            using (SqlConnection con = new SqlConnection(General.basededatosactual))
			{
                using (SqlCommand cmd = new SqlCommand("INSERTAR_USUARIOSISTEMA", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@apellido", Apellido);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }



    }
}