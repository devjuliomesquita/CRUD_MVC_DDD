using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projeto.MVC.Models.InputModels
{
    public class ClientInputModel
    {
        
        [Required(ErrorMessage = "Preencha do campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Preencha do campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Preencha do campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("E-mail")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
