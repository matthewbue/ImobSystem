using ImobSystem.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.Context
{
    public class ImobSystemContext : DbContext
    {
        public ImobSystemContext(DbContextOptions<ImobSystemContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Produto> Produtos { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

   