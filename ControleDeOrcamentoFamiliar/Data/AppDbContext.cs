using Microsoft.EntityFrameworkCore;
using System;
using ControleDeOrcamentoFamiliar.Models;

namespace ControleDeOrcamentoFamiliar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Receitas> receitas { get; set; }
        public DbSet<Despesas> Despesas { get; set; }


    }
}
