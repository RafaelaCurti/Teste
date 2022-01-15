using System;

namespace Domain
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
