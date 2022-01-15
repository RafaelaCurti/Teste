using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Data.Repositories;
using Domain.Entities;
using Microsoft.Extensions.Configuration;


namespace Context.Data
{
    public class COPARAR : IDbConectionRepository
    {
        private readonly string _connectionString;

        public COPARAR(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("TesteServer");
        }

        public IEnumerable<Pessoa> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);

            var pessoa = connection.Query<Pessoa>("SELECT * FROM Pessoas");

            return pessoa;
        }

        public int Insert(long step)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "INSERT INTO Pessoas (step)values (@step)";

            var result = connection.Execute(query, new { step = step });

            return result;
        }
    }
}
