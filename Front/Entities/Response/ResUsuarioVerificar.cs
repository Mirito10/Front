using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Entities
{
    public class ResUsuarioVerificar
    {
        public bool Resultado { get; set; }
        public string DescripcionError { get; set; }
        public Usuario User { get; set; }

        public ResUsuarioVerificar()
        {
        }

        public ResUsuarioVerificar(bool resultado, string descripcionError, Usuario user)
        {
            Resultado = resultado;
            DescripcionError = descripcionError;
            User = user;
        }
    }
}
