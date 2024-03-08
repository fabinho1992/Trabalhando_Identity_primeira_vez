using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Configuration
{
    public class ContextBase : DbContext
    {
        private readonly IConfiguration IConfiguracao;

        public ContextBase(IConfiguration configuration, DbContextOptions<ContextBase> options) : base(options)
        {
            IConfiguracao = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringconfiguration = IConfiguracao["DefaultConnection"];
                optionsBuilder.UseSqlServer(stringconfiguration);
                base.OnConfiguring(optionsBuilder);
            }
            
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }


}
