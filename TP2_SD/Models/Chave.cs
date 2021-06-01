using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD.Models
{
    public class Chave
    {
        public int ChaveId { get; set; }
        public string Numeros { get; set; }
        public string Estrelas { get; set; }
      
    }


    public class Aposta
    {
        [Key]
        public int NIF { get; set; }

        [Key]
        public DateTime date { get; set; }
        
        [Key]
        public Chave chave { get; set; }
        
        public bool arquivada { get; set; }

        public double premio { get; set; }
    }
}

