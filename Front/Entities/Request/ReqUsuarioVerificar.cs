using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Entities.Request
{
    public class ReqUsuarioVerificar
    {
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public ReqUsuarioVerificar()
        {
        }

        public ReqUsuarioVerificar(string correo, string contrasena)
        {
            Correo = correo;
            Contrasena = contrasena;
        }
    }
}
