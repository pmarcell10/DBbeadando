using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DB_Beadando
{
    class ItemHandler : DBManager
    {
        public List<Item> ListItems()
        {
            //Termékek kilistázása
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
        public int getQuantity(int itemId)
        {
            //Aktuális készlet lekérdezése
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = openConn();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT quantity FROM items WHERE id = :id";

            OracleParameter pId = new OracleParameter();
            pId.OracleDbType = OracleDbType.Int32;
            pId.ParameterName = ":id";
            pId.Value = itemId;

            cmd.Parameters.Add(pId);

            OracleDataReader reader = cmd.ExecuteReader();

            int quantity = 0;

            while (reader.Read())
            {
                quantity = int.Parse(reader["quantity"].ToString());
            }

            return quantity;
            
        }

        public int Buy(Item i, int quantity)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = openConn();
            cmd.CommandType = System.Data.CommandType.Text;
            if (quantity == i.Quantity) // Ha pont annyit vásárolnak amennyi van, törlés
            {
                cmd.CommandText = "DELETE FROM items WHERE id = :id";

                OracleParameter pId = new OracleParameter();
                pId.ParameterName = ":id";
                pId.OracleDbType = OracleDbType.Int32;
                pId.Value = i.Id;

                cmd.Parameters.Add(pId);

                return cmd.ExecuteNonQuery();

            }
            else if (quantity < i.Quantity) //Egyébként csökkentjük a készletet a vásárolt mennyiséggel
            {
                cmd.CommandText = "UPDATE items SET quantity = :quantity WHERE id = :id";

                OracleParameter pQuantity = new OracleParameter();
                pQuantity.ParameterName = ":quantity";
                pQuantity.OracleDbType = OracleDbType.Int32;
                pQuantity.Value = getQuantity(i.Id) - quantity;

                OracleParameter pId = new OracleParameter();
                pId.ParameterName = ":id";
                pId.OracleDbType = OracleDbType.Int32;
                pId.Value = i.Id;

                cmd.Parameters.Add(pQuantity);
                cmd.Parameters.Add(pId);

                return cmd.ExecuteNonQuery();

            }

            else throw new Exception("Nincs ekkora mennyiség készleten!"); //Egyébként hiba, vásárlásnál elkapjuk

        }

        public int Add(string name, int quantity)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = openConn();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO items (id, name, quantity) VALUES (seq_item.nextval, :name, :quantity)";

            OracleParameter pName = new OracleParameter();
            pName.ParameterName = ":name";
            pName.OracleDbType = OracleDbType.Varchar2;
            pName.Value = name;

            OracleParameter pQuantity = new OracleParameter();
            pQuantity.ParameterName = ":quantity";
            pQuantity.OracleDbType = OracleDbType.Int32;
            pQuantity.Value = quantity;

            cmd.Parameters.Add(pName);
            cmd.Parameters.Add(pQuantity);

            return cmd.ExecuteNonQuery();
        }
    }
}
