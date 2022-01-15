using Dapper;
using Data.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class RepositoryBase
    {
        private readonly IDefaulConnectionDapper _connection;

        public RepositoryBase()
        {
            
        }

        public RepositoryBase(IDefaulConnectionDapper connection)
        {
            _connection = connection;
        }

        public void GetById(int id)
        {
            string query = $"SELECT * FROM Cliente WHERE clienteId = {id}";
            
            using (var connectionDb = _connection.Connection())
            {
                connectionDb.Open();
                var resultado = connectionDb.Query<Pessoa>(query);

                if (resultado.Any())
                {
                    // a consulta retornou algo. o que deseja fazer agora?
                }
                else
                {
                    // a consulta NÃO retornou algo. o que deseja fazer agora?
                }

                connectionDb.Close();
            }
        }
        
        public void Add(int id)
        {

        }
        
        public void Update(int id)
        {
        } 

        public void Remove(int id)
        {

        }
    }
}
