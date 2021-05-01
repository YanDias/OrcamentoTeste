using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class OrcamentoDAO : IRep<Orcamento>
    {
        private readonly Context ctx;

        public OrcamentoDAO(Context context)
        {
            ctx = context;
        }

        public List<Orcamento> Listar()
        {
            return ctx.Orcamentos.ToList();
        }

        public bool Cadastrar(Orcamento orc)
        {
            ctx.Orcamentos.Add(orc);
            ctx.SaveChanges();
            return true;
        }
        public Orcamento BuscarPorId(int id)
        {
            return ctx.Orcamentos.Find(id);
        }

        public Orcamento BuscarClientePorNome(Orcamento orc)
        {
            
            return ctx.Orcamentos.FirstOrDefault
                (x => x.NomeCliente.Equals(orc.NomeCliente));
        }

        public void Remover(int id)
        {

            ctx.Orcamentos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public void Alterar(Orcamento or)
        {
            ctx.Orcamentos.Update(or);
            ctx.SaveChanges();
        }


        /*FUNÇÃO de cliente comm nome Unico (poderia cer utilizada com email do cliente para evitar Redundancia no Banco de Dados
         * public bool CadastrarValidandoNome(Orcamento orc)
        {
            if (BuscarClientePorNome(orc) == null)
            {
                ctx.Orcamentos.Add(orc);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }*/
    }
}
