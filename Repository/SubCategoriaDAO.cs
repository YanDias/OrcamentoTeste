using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class SubCategoriaDAO : IRep<SubCategoria>
    {
        private readonly Context ctx;

        public SubCategoriaDAO(Context context)
        {
            ctx = context;
        }

        public List<SubCategoria> Listar()
        {
            return ctx.SubCategorias.ToList();
        }

        public bool Cadastrar (SubCategoria sub)
        {
            ctx.SubCategorias.Add(sub);
            ctx.SaveChanges();
            return true;
        }
        public SubCategoria BuscarPorId(int id)
        {
            return ctx.SubCategorias.Find(id);
        }


        public void Alterar(SubCategoria sub)
        {
            ctx.SubCategorias.Update(sub);
            ctx.SaveChanges();
        }
    }
}
