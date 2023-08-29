using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace motogoAPI.Entities
{
    public class Remessa
    {
        [Key]
        public int IdRemessa { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double? Peso { get; set; }
        public double? Altura { get; set; }
        public double? Comprimento { get; set; }
        public double? Largura { get; set; }
        public double? Valor { get; set; }
        public string? ImagemProduto { get; set; }
        
        
        
    }
}