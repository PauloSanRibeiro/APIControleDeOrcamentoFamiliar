using Microsoft.EntityFrameworkCore;
using System;
using ControleDeOrcamentoFamiliar.Models;

namespace ControleDeOrcamentoFamiliar.Data
{
    public class OrcamentoContext : DbContext
    {
        public OrcamentoContext(DbContextOptions<OrcamentoContext> options) : base(options)
        {

        }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Despesas> Despesas { get; set; }


    }
}
