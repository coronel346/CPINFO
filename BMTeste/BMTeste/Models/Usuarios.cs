using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMTeste.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        [Required]
        //[Required(ErrorMessage = "Digite o Nome")]
        //[StringLength(60, MinimumLength = 3)]
        public string Nome { get; set; }
        [Display(Name = "Idade")]
        //[Cpf(ErrorMessage = "O valor '{0}' é inválido para CPF")]
        public int Idade { get; set; }
        [Required]
        [Display(Name = "CPF")]
        //[Cpf(ErrorMessage = "O valor '{0}' é inválido para CPF")]
        public string CPF { get; set; }
    }
}