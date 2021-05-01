using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface IRep <c>
    {
        bool Cadastrar(c objeto);
        c BuscarPorId(int id);
        List<c> Listar();
    }
}
