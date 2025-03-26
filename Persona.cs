using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace universidades
{
    public abstract class Persona : CRUD
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string email;

        public Persona(int id, string nombre, string apellido, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
 
        }

        public Persona()
        {
        }

        public void insertarBD() { }
        public void actualizarBD() { }
        public void eliminarBD() { }
        public object seleccionarBD()
        {
            return new object();
        }

        public List<object> seleccionarTodosBD()
        {
            List<object> listaaDevolver = new List<object>();
            return listaaDevolver;
        }

        // Implementación del método faltante de la interfaz CRUD

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
    }
}
