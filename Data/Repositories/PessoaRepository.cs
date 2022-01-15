using Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PessoaRepository : RepositoryBase
    {
        private readonly IDefaulConnectionDapper _connection;

        public PessoaRepository(IDefaulConnectionDapper connection)
        {
            _connection = connection;
        }

        public void GetByPF(int id)
        {
            using(var con = _connection.Connection())
            {
                con.Open();
                con.Close();
            }
        }

        public void GetByPJ(int id)
        {

        }
    }
}
