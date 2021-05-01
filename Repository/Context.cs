using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Repository
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<ProdutoOrcamento> ProdutoOrcamentos { get; set; }


    }
}
