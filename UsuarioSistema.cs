using System.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;

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

        public new List<UsuarioSistema> seleccionarTodosBD()
        {
            List<UsuarioSistema> listaDevolver = new List<UsuarioSistema>();
            using (SqlConnection con = new SqlConnection(General.basededatosactual))
            {
                using (SqlCommand cmd = new SqlCommand("SELECCIONAR_USUARIOS", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                           UsuarioSistema ITEM = new UsuarioSistema();
                            
                            ITEM.Nombre = dr[1].ToString();
                            ITEM.Apellido = dr[2].ToString();
                            ITEM.Email = dr[4].ToString();
                            listaDevolver.Add(ITEM);
                        }

                        dr.Close();
                    }
                    con.Close();
                    return listaDevolver;
                }
            }
        }
        public new void actualizarBD()
        {
            using (SqlConnection con = new SqlConnection(General.basededatosactual))
            {
                using (SqlCommand cmd = new SqlCommand("ACTUALIZAR_USUARIO", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add all parameters
                    cmd.Parameters.AddWithValue("@ID", Id);
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
                        throw new Exception("Error al actualizar en la base de datos: " + errorDetails);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error inesperado: " + ex.Message);
                    }
                }
            }
        }

        public new void eliminarBD()
        {
            using (SqlConnection con = new SqlConnection(General.basededatosactual))
            {
                using (SqlCommand cmd = new SqlCommand("ELIMINAR_USUARIO", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add all parameters
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = this.Id;
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                    
                }
            }
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