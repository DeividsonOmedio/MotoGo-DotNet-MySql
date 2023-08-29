using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace motogoAPI.Entities
{
    public class Pedidos
    {
        [Key]
        public int IdPedido { get; set; }

        public virtual Usuarios Usuario { get; set; }
        public int UsuarioId { get; set; }

        public virtual Entregadores? Entregadores { get; set; }
        public int? EntregadoresId { get; set; }

        public virtual EnderecosRetiradas EnderecoRetirada { get; set; }
        public int EnderecoRetiradaId { get; set; }

        public virtual EnderecosEntregas EnderecoEntregas { get; set; }
        public int EnderecoEntregasId { get; set; }
        public virtual Remessa Remessa { get; set; }
        public int RemessaId { get; set; }
        public  EnumStatusPedido StatusPedido { get; set; }
        public bool Chovendo { get; set; }
        public bool Noite { get; set; }
        public double DistanciaPrevista { get; set; }
        public double? Distanciapercorrida { get; set; }
        public double ValorPorKm { get; set; }
        public double valorPrevisto { get; set; }
        public double? ValorTotal { get; set; }
        public bool StatusPagamento { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data/Hora do Pedido")]  
        public DateTime DataHoraPedido { get; set; } 
        public  EnumStatusPedido? StatusCliente { get; set; } 
        public  EnumStatusPedido? StatusEntregador { get; set; } 
    }
}