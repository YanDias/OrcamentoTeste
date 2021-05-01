using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Produtos")]
    public class Produto
    {
       public Produto()
        {
            SubCategoria = new SubCategoria();
        }

            [Key]
            public int idProduto { get; set; }

            public String nome { get; set; }

            public SubCategoria SubCategoria { get; set; }
          
            public Double  Valor { get; set; }

    }
}
