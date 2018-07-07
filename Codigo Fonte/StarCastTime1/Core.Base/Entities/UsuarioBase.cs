using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Entities
{
    public class UsuarioBase : EntidadeBase
    {
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}
