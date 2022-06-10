using Microsoft.EntityFrameworkCore;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
