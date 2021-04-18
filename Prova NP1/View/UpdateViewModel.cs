using System;
using System.ComponentModel.DataAnnotations;

namespace Prova_NP1.View
{
    public class UpdateViewModel
    {
        [Display(Name = "Nome do Usuario")]
        [Required(ErrorMessage = "O nome não pode ser nulo")]
        [MinLength(3, ErrorMessage = "Deve ter no minimo 3 caracteres")]
        [MaxLength(80, ErrorMessage = "Deve ter o maximo 80 caracteres")]
        public string ANome { get; set; }

        [Display(Name = "ACPF do Usuario")]
        [Required(ErrorMessage = "O ACPF não pode ser nulo")]
        [StringLength(11, ErrorMessage = "ACPF tem 11 caracteres")]
        public string ACPF { get; set; }

        [Display(Name = "ATelefone do Usuario")]
        [Required(ErrorMessage = "O ATelefone não pode ser nulo")]
        [StringLength(11, ErrorMessage = "ATelefone tem 11 caracteres")]
        public string ATelefone { get; set; }

        [Display(Name = "AEmail do Usuario")]
        [Required(ErrorMessage = "O AEmail não pode ser nulo")]
        [DataType(DataType.EmailAddress, ErrorMessage = "AEmail em formato inválido.")]
        public string AEmail { get; set; }

        [Display(Name = "AEmail do Usuario")]
        [Required(ErrorMessage = "O AEmail não pode ser nulo")]
        [Range(18, 65)]
        public int AIdade { get; set; }

    }
}
