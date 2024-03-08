using Aplication.Dto.Request;
using Aplication.Dto.Response;
using Aplication.Interface.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idendity.Service
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public Task<UsuarioCadastroResponse> CadastroUsuario(UsuarioCadastroRequest usuarioRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioLoginResponse> Login(UsuarioLoginRequest usuarioLogin)
        {
            throw new NotImplementedException();
        }
    }
}
