using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace motogoAPI.Entities
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }
        
        [MaxLength(15, ErrorMessage="Minino de 8 caracteres"),MinLength(8)]
        public string Telefone { get; set; }
        public EnumMeioDePagamentoPadrao MeioDePagamentoPadrao { get; set; }
            
    }
}