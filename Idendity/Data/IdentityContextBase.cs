using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idendity.Data
{
    public class IdentityContextBase : IdentityDbContext<Usuario>
    {
        private IConfiguration IConfiguracao;

        public IdentityContextBase(DbContextOptions<IdentityContextBase> options, IConfiguration configuration) : base(options)
        {
            IConfiguracao = configuration;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringconfiguration = IConfiguracao["DefaultConnection"];
                optionsBuilder.UseSqlServer(stringconfiguration);
                base.OnConfiguring(optionsBuilder);
            }

        }


    }
}
