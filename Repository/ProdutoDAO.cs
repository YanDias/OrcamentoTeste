using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ProdutoDAO : IRep<Produto>
    {
        private readonly Context ctx;

        public ProdutoDAO(Context context)
        {
            ctx = context;
        }

        public List<Produto> Listar()
        {
            return ctx.Produtos.Include(x=>x.SubCategoria).ToList();
        }

        public bool Cadastrar(Produto prod)
        {
            ctx.Produtos.Add(prod);
            ctx.SaveChanges();
            return true;
        }
        public Produto BuscarPorId(int id)
        {
            return ctx.Produtos.Find(id);
        }

        public void Remover(int id)
        {

            ctx.Produtos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public void Alterar(Produto p)
        {
            ctx.Produtos.Update(p);
            ctx.SaveChanges();
        }

    }
}