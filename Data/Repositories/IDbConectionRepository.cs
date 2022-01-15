using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories
{
    public class IDbConectionRepository
    {
        public IEnumerable<Pessoa> ListAll();
        public int Insert(long step);
    }
}

