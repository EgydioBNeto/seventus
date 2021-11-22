using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Models
{
    public class Organizador
    {
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Senha { get; set; }




    }
}
