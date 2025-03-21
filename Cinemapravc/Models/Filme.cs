using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemapravc.Models
{
    [Table("Filme")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MaxLength(20)]
        [Display(Name = "Titulo")]//O valor passado como parâmetro para o método Display() poderá ser exibido na interface de usuário, por exemplo: Se tivesse um atributo "password", poderia passar "senha" como parâmetro, para assim o usuário entender melhor
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Sinopse")]
        public string Sinopse { get; set; }
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }//Aqui estou acessando o objeto Genero, para assim poder saber o valor do id de gênero e assim armazená-lo ao GeneroId
        public int DiretorId { get; set; }

        [ForeignKey("DiretorId")]
        public Diretor Diretor { get; set; }
    }
}
