using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Response
{
    public class UsuarioCadastroResponse
    {
        public UsuarioCadastroResponse(bool success = true)
        {
            Erros = new List<string>();
            Success = success;
        }

        public bool Success { get; private set; }

        public List<string> Erros { get; private set; }

        public void AdicionarErros(IEnumerable<string> erros)
        {
            Erros.AddRange(erros);
        }

    }
}
