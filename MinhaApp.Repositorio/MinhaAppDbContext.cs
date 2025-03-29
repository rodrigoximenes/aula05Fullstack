using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaApp.Dominio;

namespace MinhaApp.Repositorio
{
    public class MinhaAppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public MinhaAppDbContext(DbContextOptions<MinhaAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
        }
    }
}
