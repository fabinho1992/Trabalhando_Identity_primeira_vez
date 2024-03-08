using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idendity
{
    public class Usuario : IdentityUser
    {
        
        public string Cpf { get; set; }
    }
}
