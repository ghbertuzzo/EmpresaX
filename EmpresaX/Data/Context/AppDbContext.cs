using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Data.Context
{
    public class AppDbContext
    {
        private readonly string _connectionString;

        public AppDbContext()
        {
            _connectionString = "Host=127.0.0.1;Port=5432;Database=empresa_x;Username=postgres;Password=admin";
        }

        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
