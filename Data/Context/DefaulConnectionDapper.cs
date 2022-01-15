using Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Context
{
    public class DefaulConnectionDapper : IDefaulConnectionDapper
    {
        public IDbConnection Connection()
        {
            return new SqlConnection(@"Database=nomeBancoDAdos;Data Source=(local)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NomeBancoDados.mdf");
        }
    }
}
