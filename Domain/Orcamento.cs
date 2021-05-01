using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Orcamentos")]
    public class Orcamento
    {
        public Orcamento()
        {
            
        }

        [Key]
        public int IdOrcamento { get; set; }
        
        [Display(Name = "Nome do Cliente:")]
        [Required(ErrorMessage = "Não pode ser Vazio")]
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }

    }
}

