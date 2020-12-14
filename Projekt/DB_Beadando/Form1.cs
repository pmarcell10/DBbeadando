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
            loadItems();

        }

        public void loadItems()
        {
            items = itemHandler.ListItems();
            listbox_availableItems.DisplayMember = "BoxDisplay";
            foreach (Item i in items)
            {
                string itemInfo = i.Name + " (" + i.Quantity.ToString() + ")";
                listbox_availableItems.Items.Add(i);
            }
        }

        public void refreshItems()
        {
            listbox_availableItems.Items.Clear();
            loadItems();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if(listbox_availableItems.SelectedItem == null)
            {
                MessageBox.Show("Válassz terméket");
                return;
            }

            Item selectedItem = (Item)listbox_availableItems.SelectedItem;
            int selectedQuantity = (int)itemQuantitySelector.Value;
            try
            {
                if (itemHandler.Buy(selectedItem, selectedQuantity) != 0)
                    {
                        MessageBox.Show("Sikeresen megvásárolva: "+selectedQuantity+" db "+selectedItem.Name);
                        refreshItems();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
