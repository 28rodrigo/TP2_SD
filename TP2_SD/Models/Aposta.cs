using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD.Models
{
    public class RegistoAposta
    {
        [Key]
        public int RegistoApostaId { get; set; }

        public int NIF { get; set; }

        public DateTime Data { get; set; }

        public RegistoChave Chave { get; set; }
        
        public bool Arquivada { get; set; }

        public int Premio { get; set; }
    }
}

