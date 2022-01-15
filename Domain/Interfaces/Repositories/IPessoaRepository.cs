using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repositories
{
    public interface IPessoaRepository : IRepositoryBase
    {
        TipoPessoaPF GetByPF(int id);
        TipoPessoaPF GetByPJ(int id);
    }
}
