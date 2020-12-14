using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Beadando
{
    class AdminHandler : DBManager
    {
        public List<Admin> loadAdmins()
        {
            //Adminok betöltése
            List<Admin> admins = new List<Admin>();

            OracleCommand cmd = new OracleCommand();
            
            cmd.Connection = openConn();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = @"SELECT username, password FROM admins";

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Admin admin = new Admin();

                admin.Username = (string)reader["username"];
                admin.Password = (string)reader["password"];

                admins.Add(admin);
            }

            reader.Close();

            return admins;
        }

    }
}
