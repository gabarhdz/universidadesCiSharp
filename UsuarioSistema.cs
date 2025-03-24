using System.Data.SqlClient;
using System;
using System.Data;

namespace universidades
{
    public class UsuarioSistema : Persona
    {
        private string _contrasena;

        public UsuarioSistema() { }

        public UsuarioSistema(int id, string nombre, string apellido, string email, string contrasena)
        {
            // Initialize base class properties
            base.Id = id;
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.Email = email;

            // Initialize this class property
            this._contrasena = contrasena;
        }

        public string Contrasena
        {
            get => _contrasena;
            set => _contrasena = value;
        }

        public new void insertarBD()
        {
            using (SqlConnection con = new SqlConnection(General.basededatosactual))
            {
                using (SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add all parameters
                    cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", Apellido);
                    cmd.Parameters.AddWithValue("@EMAIL", Email);
                    cmd.Parameters.AddWithValue("@CONTRASENA", _contrasena);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Enhanced error information
                        string errorDetails = $"SQL Error Number: {ex.Number}, Message: {ex.Message}";
                        throw new Exception("Error al insertar en la base de datos: " + errorDetails);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error inesperado: " + ex.Message);
                    }
                }
            }
        }
    }
}