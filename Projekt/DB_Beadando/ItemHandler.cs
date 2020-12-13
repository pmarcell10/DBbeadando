using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Beadando
{
    class ItemHandler : DBManager
    {
        public List<Item> ListItems()
        {
            List<Item> items = new List<Item>();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = openConn();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = @"SELECT id, name, quantity FROM items";

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                Item item = new Item();
                item.Id = int.Parse(reader["id"].ToString());
                item.Name = (string)reader["name"];
                item.Quantity = int.Parse(reader["quantity"].ToString());

                items.Add(item);
            }

            reader.Close();

            return items;
        }
    }
}
