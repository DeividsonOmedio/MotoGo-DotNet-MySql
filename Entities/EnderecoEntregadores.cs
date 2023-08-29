using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace motogoAPI.Entities
{
    public class EnderecoEntregadores
    {
        [Key]
        public int IdEnderecoEntregador { get; set; }
        
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MaxLength(15)]
        public int Numero { get; set; }

        [MaxLength(50)]
        public string Bairro { get; set; }

        [MaxLength(20)]
        public string Cep { get; set; }

        [MaxLength(25)]
        public string Cidade { get; set; }

        [MaxLength(3)]
        public string Uf { get; set; }
        public virtual Entregadores Entregador { get; set; }

        public int EntregadorId { get; set; }
        
        
        

       
        
        
    }
}