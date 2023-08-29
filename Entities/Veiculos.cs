using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace motogoAPI.Entities
{
    public class Veiculos
    {
        [Key]
        public int IdVeiculos { get; set; }
        
        public virtual Entregadores Entregador { get; set; }
        public int EntregadorId { get; set; }

        [MaxLength(10)]
        public string Placa { get; set; }

        [MaxLength(15)]
        public string Cor { get; set; }

        [MaxLength(25)]
        public string Marca { get; set; }

        [MaxLength(25)]
        public string Modelo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data/Hora do Pedido")]  
        public DateTime AnoFabricacao { get; set; }
        
        
        
    }
}