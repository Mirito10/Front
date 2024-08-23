using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Entities
{
    public class Usuario
    {
        public long IdentificadorUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public byte[] FotoPerfil { get; set; }
        public bool? Estatus { get; set; }

        public Usuario()
        {
        }

        public Usuario(long identificadorUsuario, string nombre, DateTime? fechaNacimiento,
                       string correo, string contrasena, byte[] fotoPerfil, bool? estatus)
        {
            IdentificadorUsuario = identificadorUsuario;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            Contrasena = contrasena;
            FotoPerfil = fotoPerfil;
            Estatus = estatus;
        }
    }
}
