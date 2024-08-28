using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemapravc.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "CPF")]
        [MaxLength(12)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Telefone")]
        [MaxLength(13)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "TipoUsuario")]
        public TipoUsuario Tipo { get; set;}

        public enum TipoUsuario
    {
        Admin,
        User
    }
}

}
