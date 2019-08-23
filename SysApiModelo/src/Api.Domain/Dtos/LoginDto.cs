using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Login é um campo obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório")]
        public string Senha { get; set; }
    }
}
