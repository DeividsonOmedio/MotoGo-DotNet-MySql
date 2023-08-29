using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace motogoAPI.Entities
{
    public class Funcionarios
    {
        [Key]
        public int IdFuncionario { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }

        [MaxLength(15)]
        public string Telefone { get; set; }
        public string Cargo { get; set; }

        public int Permissao { get; set; }
        public string ImagemFuncionario { get; set;}
        public string ImagemDocumentoFuncionario { get; set;}

    }
}