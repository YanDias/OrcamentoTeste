using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("ProdutosOrcamentos")]
    public class ProdutoOrcamento
    {
        public ProdutoOrcamento()
        {
            Produto = new Produto();
            Orcamento = new Orcamento();
        }

        [Key]
        public int IdProdutoOrcamento { get; set; }
        [Display(Name = "Produto:")]
        [Required(ErrorMessage = "Não Pode ser Vazio!")]
        public Produto Produto { get; set; }
        [Display(Name = "Orçamento:")]
        [Required(ErrorMessage = "Não Pode ser Vazio!")]
        public Orcamento Orcamento { get; set; }
        public int Quantidade { get; set; }

    }
}
