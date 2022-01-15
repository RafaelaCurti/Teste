using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TipoPessoaPF : Pessoa
    {
        public int Id { get; set; }
        public int CNPJ { get; set; }
        public DateTime DataAbertura { get; set; }
        public string NomeFantasia { get; set; }

    }
}
