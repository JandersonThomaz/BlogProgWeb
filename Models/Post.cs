using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProgWeb.Models
{
    public class Post
    {
        public int Id { get; set; }


        [Display(Name = "Título"), Required(ErrorMessage = "O campo {0} é obrigatório"), MaxLength(100, ErrorMessage = "No máximo {1} caracteres")]
        public string Titulo { get; set; }


        [Display(Name = "Subtitulo"), Required(ErrorMessage = "O campo {0} é obrigatório"), MaxLength(100, ErrorMessage = "No máximo {1} caracteres")]   
        public string SubTitulo { get; set; }


        [Display(Name = "Conteudo"), Required(ErrorMessage = "O campo {0} é obrigatório"), MaxLength(ErrorMessage = "No máximo {1} caracteres")] 
        public string Conteudo { get; set; }


        [Display(Name = "Categoria"), Required(ErrorMessage = "O campo {0} é obrigatório")]       
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
