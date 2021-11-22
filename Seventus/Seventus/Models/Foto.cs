using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Models
{
    public class Foto
    {
        [Required]
        public string Arquivo { get; set; }
        [Required]
        public int IdEvento { get; set; }

    }
}
