using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Entities
{
    public class UsuarioEntity:BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
