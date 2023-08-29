using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace motogoAPI.Entities
{
    public class EnderecosRetiradas
    {
        [Key]
        public int IdEnderecoRetirada { get; set; }

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
    }
}