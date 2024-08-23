using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Entities
{
    public static class Sesion
    {
        public static long idUsuario { get; set; }

        public static string Nombre { get; set; }

        public static string Email { get; set; }


        public static void cerrarSesion()
        {
            Sesion.idUsuario = 0;
            Sesion.Nombre = String.Empty;
            Sesion.Email = String.Empty;

        }
    }
}
