using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Subcategorias")]
    public class SubCategoria
    {
        public SubCategoria() { }
       
        [Key]
        public int idSub { get; set; }
        [Display(Name = "Nome Categoria:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public String nome { get; set; }


    }
}
