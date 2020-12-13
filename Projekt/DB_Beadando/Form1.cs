using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Beadando
{
    public partial class Form1 : Form
    {
        private ItemHandler itemHandler;
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();
            itemHandler = new ItemHandler();
            items = itemHandler.ListItems();
            loadItems();

        }

        public void loadItems()
        {
            foreach (Item i in items)
            {
                string itemInfo = i.Name + " (" + i.Quantity.ToString() + ")";
                listbox_availableItems.Items.Add(itemInfo);
            }
        }

    }
}
