using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Request
{
    public class UsuarioLoginRequest
    {
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo {0} Obrigatório")]
        public string Senha { get; set; }
    }
}
