using Aplication.Dto.Request;
using Aplication.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface.Services
{
    public interface IIdentityService
    {
        Task<UsuarioCadastroResponse> CadastroUsuario(UsuarioCadastroRequest usuarioRequest);
        Task<UsuarioLoginResponse> Login(UsuarioLoginRequest usuarioLogin);
    }
}
