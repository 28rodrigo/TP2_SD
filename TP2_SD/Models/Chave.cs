using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD.Models
{
    public class RegistoChave
    {
        [Key]
        public int ChaveId { get; set; }
        public string Numeros { get; set; }
        public string Estrelas { get; set; }
    }
}

