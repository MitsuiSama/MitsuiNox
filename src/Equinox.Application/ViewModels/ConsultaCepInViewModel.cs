using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinox.Application.ViewModels
{
    public class ConsultaCepInViewModel
    {
        [Required(ErrorMessage = "O cep deve ser informado")]
        [RegularExpression(@"^\d{5}-?\d{3}$",ErrorMessage = "Cep Inválido")]
        public string Cep {  get; set; }
    }
}
