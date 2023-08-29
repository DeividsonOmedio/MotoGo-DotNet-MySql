using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace motogoAPI.Entities
{
    public class Entregadores
    {
        [Key]
        public int IdEntregador { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string Cpf { get; set; }

        [MaxLength(15, ErrorMessage="Minino de 8 caracteres"),MinLength(8)]
        public string Telefone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }
        public Boolean Disponibilidade { get; set; }
        public double? AvaliacaoMedia { get; set; }
        public string ImagemEntregador { get; set;}
        public string ImagemCnhEntregador { get; set;}
        public double? ValoresReceber { get; set; }
        public string ChavePix { get; set; }
        
        
        
        

    }
}