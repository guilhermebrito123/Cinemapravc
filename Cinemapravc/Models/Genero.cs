using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemapravc.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        public ICollection <Filme> Filme { get; set; }
    }
}