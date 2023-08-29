using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace motogoAPI.Entities
{
    public class Precos
    {
        [Key]
        public int IdPreco { get; set; } = 1;
        
        public double PrecoKm { get; set; } = 0;
        
        public double Preco1Kg { get; set; } = 0;
        public double Preco3Kg { get; set; } = 0;
        public double Preco8Kg { get; set; } = 0;
        public double Preco12Kg { get; set; } = 0;
        
        public double PrecoDia { get; set; } = 0;
        
        public double PrecoNoite { get; set; } = 0;
        
        public double PrecoChuva { get; set; } = 0;
        public double PrecoTempo { get; set; } = 0;
        public double PorcentagemEntregador { get; set; } = 0;
        
        
    }
}