using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universidades
{
    interface CRUD
    {
        void insertarBD();
        void actualizarBD();
        void eliminarBD();
        object seleccionarBD();

        List<object> seleccionarTodosDB();

    }
}
