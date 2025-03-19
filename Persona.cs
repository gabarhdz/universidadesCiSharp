using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace universidades
{
	public abstract class Persona
	{
		private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string contrasena;
        private string telefono;

        public Persona(int id, string nombre, string apellido, string email, string contrasena, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.contrasena = contrasena;
            this.telefono = telefono;
        }

        public Persona()
        {
        }



        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected string Email { get => email; set => email = value; }
        protected string Contrasena { get => contrasena; set => contrasena = value; }
        protected string Telefono { get => telefono; set => telefono = value; } 
         
    }
}