using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projeto.MVC.Models.InputModels
{
    public class ProductInputModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Preencha do campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Nome")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Preencha do campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preencha o campo com um valor")]
        [Range(typeof(decimal), "0","9999999999")]
        [DisplayName("Valor R$")]
        public decimal ProductValue { get; set; }

        public int ClientId { get; set; }
    }
}
