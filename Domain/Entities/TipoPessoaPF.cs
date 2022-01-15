using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TipoPessoaPJ : Pessoa
    {

        public int CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
