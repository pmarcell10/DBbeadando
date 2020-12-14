using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private string uqid;

        public string Uqid // A képzeletbeli bolt termékének egyedi azonosítója, 4 betűből és 4 számból áll
        {
            get
            {
                return uqid;
            }
            set
            {        
                    uqid = value;
            }
        }

        public string BoxDisplay
        {
            get
            {
                return name + " (" + quantity + "db)";
            }
        }
    }
}
