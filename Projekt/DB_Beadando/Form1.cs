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

        private AdminHandler adminHandler;
        private List<Admin> admins;

        public Form1()
        {
            InitializeComponent();
            itemHandler = new ItemHandler();
            loadItems();
            adminHandler = new AdminHandler();
            admins = adminHandler.loadAdmins();

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

        public void showAdminMenu()
        {
            lbl_Admin.Visible = false;
            lbl_Username.Visible = false;
            lbl_Password.Visible = false;
            textBox_username.Visible = false;
            textBox_password.Visible = false;
            btn_Login.Visible = false;

            btn_Buy.Visible = false;
            topLabel.Text = "Admin menü";
            lb_addItem.Visible = true;
            textBox_itemName.Visible = true;
            btn_addItem.Visible = true;

        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if(listbox_availableItems.SelectedItem == null) // Ha nincs termék kiválasztva
            {
                MessageBox.Show("Válassz terméket");
                return;
            }

            Item selectedItem = (Item)listbox_availableItems.SelectedItem;
            int selectedQuantity = (int)itemQuantitySelector.Value;
            if(selectedQuantity == 0) // Ha nincs mennyiség kiválasztva
            {
                MessageBox.Show("Válassz mennyiséget!");
                return;
            }
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

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            lbl_Admin.Visible = true;
            lbl_Username.Visible = true;
            lbl_Password.Visible = true;
            textBox_username.Visible = true;
            textBox_password.Visible = true;
            btn_Login.Visible = true;

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            foreach (Admin admin in admins)
            {
                if (admin.Username == textBox_username.Text && admin.Password == textBox_password.Text)
                {
                    MessageBox.Show("Sikeres bejelentkezés!");
                    showAdminMenu();
                    return;
                }

            }
            MessageBox.Show("Sikertelen felhasználónév, vagy jelszó!");
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            string name = textBox_itemName.Text;
            int quantity = (int)itemQuantitySelector.Value;
            try
            {
                itemHandler.Add(name, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Sikeres hozzáadás");
            refreshItems();
        }
    }
}
