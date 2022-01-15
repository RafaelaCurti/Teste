using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase
    {
        Pessoa GetById(int id);
        void Add(int id);
        void Update(int id);
        void Remove(int id);
        void Dispose();

    }
}
