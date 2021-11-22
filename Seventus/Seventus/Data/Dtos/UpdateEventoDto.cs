using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Data.Dtos
{
    public class UpdateEventoDto
    {

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFinal { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "O CEP deve ter 8 caracteres")]
        public string CEP { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string UF { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public int Interessados { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public bool Situacao { get; set; }

    }
}
