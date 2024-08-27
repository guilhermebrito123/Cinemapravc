using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemapravc.Models
{
    [Table("Diretor")]
    public class Diretor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Sobre")]
        public string Sobre { get; set;}
        public ICollection <Filme> Filmes { get; set; }
    }
}