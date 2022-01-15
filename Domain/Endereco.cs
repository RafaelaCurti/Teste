using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }
    }
}
