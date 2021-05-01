using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ProdutoOrcamentoDAO : IRep<ProdutoOrcamento>
    {
        private readonly Context ctx;
        public ProdutoOrcamentoDAO(Context context)
        {
            ctx = context;
        }

        public bool Cadastrar(ProdutoOrcamento po)
        {
            ctx.ProdutoOrcamentos.Add(po);
            ctx.SaveChanges();
            return true;
        }

        public ProdutoOrcamento BuscarPorId(int id)
        {

            return ctx.ProdutoOrcamentos.Find(id);
        }
        public List<ProdutoOrcamento> Listar()
        {
            return ctx.ProdutoOrcamentos.Include(p => p.Produto).Include(o=>o.Orcamento).ToList();
        }
        public void AlterarProdutoOrçamento(ProdutoOrcamento po)
        {   if (po.Quantidade >= 0)
            {
                int id = po.IdProdutoOrcamento;
                ctx.ProdutoOrcamentos.Remove(BuscarPorId(id));
                ctx.SaveChanges();
            }
            ctx.ProdutoOrcamentos.Update(po);
            ctx.SaveChanges();
        }

        public List<ProdutoOrcamento> ListarporOrcamento(Orcamento orcamento)
        {
            return ctx.ProdutoOrcamentos.Include(op =>op.Orcamento ).Where(x => x.Orcamento == orcamento).Include(p => p.Produto).ToList();

        }

        public List<ProdutoOrcamento> ListarporProduto(Produto produto)
        {
            return ctx.ProdutoOrcamentos.Include(p => p.Produto).Where(p => p.Produto == produto).ToList();

        }

        public List<ProdutoOrcamento> ListarporNome(Orcamento orcamento)
        {
            return ctx.ProdutoOrcamentos.Include(op => op.Orcamento.NomeCliente).Where(x => x.Orcamento.NomeCliente == orcamento.NomeCliente).ToList();

        }


        public void Remover(int id)
        {

            ctx.ProdutoOrcamentos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }
    }
}
