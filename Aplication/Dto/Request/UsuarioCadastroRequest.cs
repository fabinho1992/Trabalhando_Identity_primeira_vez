using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Request
{
    public class UsuarioCadastroRequest
    {
        [Required(ErrorMessage = "Campo {0} obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo {0} obrigatório!")]
        [StringLength(50, ErrorMessage = "Campo deve conter no máximo 50 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Compare(nameof(Senha), ErrorMessage = "Senhas devem ser iguais")]
        public string ConfirmacaoSenha { get; set; }

    }
}
