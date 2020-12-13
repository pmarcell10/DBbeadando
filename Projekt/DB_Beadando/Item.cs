using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DB_Beadando
{
    class Item
    {
        private int id;
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value == null)
                {
                    throw new Exception("A név nem lehet üres.!");
                }
                else name = value;             
            }
        }

        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Elfogyott a termék!");
                }
                else quantity = value;
            }
        }
    }
}
