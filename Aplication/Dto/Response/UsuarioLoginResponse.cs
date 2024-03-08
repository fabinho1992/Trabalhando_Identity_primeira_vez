using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aplication.Dto.Response
{
    public class UsuarioLoginResponse
    {
        public bool Success { get; private set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]// essa anotação serve para que se der Success = false, o token e a data sejam nulos
        public string Token { get;  set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime Dataexpiracao { get; private set; }
        public List<string> Erros { get; private set; }

        public UsuarioLoginResponse(bool sucesso = true)
        {
            Success = sucesso;
            Erros = new List<string>();
        }

        public void AdicionarErro(string erro)
        {
            Erros.Add(erro);
        }

        public void AdicionarErros(IEnumerable<string> erros)
        {
            Erros.AddRange(erros);
        }
        
    }
}
