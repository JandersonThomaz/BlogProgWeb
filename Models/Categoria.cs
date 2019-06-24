using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogProgWeb.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Nome"), Required(ErrorMessage = "O campo {0} é obrigatório"), MaxLength(100, ErrorMessage = "No máximo {1} caracteres")] 
        public string Nome { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}