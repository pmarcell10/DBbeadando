using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DB_Beadando
{
    class DBManager
    {
        public OracleConnection openConn()
        {
            OracleConnection conn = new OracleConnection();
            string connString = @"Data Source=localhost;User Id=system;Password=password;";
            conn.ConnectionString = connString;
            conn.Open();
            return conn;

        }
    }
}
