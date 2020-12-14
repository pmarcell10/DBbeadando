namespace DB_Beadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLabel = new System.Windows.Forms.Label();
            this.listbox_availableItems = new System.Windows.Forms.ListBox();
            this.lb_availableItems = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.itemQuantitySelector = new System.Windows.Forms.NumericUpDown();
            this.lb_db = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.lb_addItem = new System.Windows.Forms.Label();
            this.textBox_itemName = new System.Windows.Forms.TextBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantitySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(344, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(92, 38);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Üzlet";
            // 
            // listbox_availableItems
            // 
            this.listbox_availableItems.FormattingEnabled = true;
            this.listbox_availableItems.ItemHeight = 16;
            this.listbox_availableItems.Location = new System.Drawing.Point(32, 152);
            this.listbox_availableItems.Name = "listbox_availableItems";
            this.listbox_availableItems.Size = new System.Drawing.Size(258, 212);
            this.listbox_availableItems.TabIndex = 1;
            // 
            // lb_availableItems
            // 
            this.lb_availableItems.AutoSize = true;
            this.lb_availableItems.Location = new System.Drawing.Point(29, 116);
            this.lb_availableItems.Name = "lb_availableItems";
            this.lb_availableItems.Size = new System.Drawing.Size(127, 17);
            this.lb_availableItems.TabIndex = 2;
            this.lb_availableItems.Text = "Elérhető termékek:";
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(653, 20);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(110, 30);
            this.btn_Admin.TabIndex = 3;
            this.btn_Admin.Text = "Admin menü";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(434, 149);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 23);
            this.btn_Buy.TabIndex = 4;
            this.btn_Buy.Text = "Vásárlás";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // itemQuantitySelector
            // 
            this.itemQuantitySelector.Location = new System.Drawing.Point(318, 152);
            this.itemQuantitySelector.Name = "itemQuantitySelector";
            this.itemQuantitySelector.Size = new System.Drawing.Size(71, 22);
            this.itemQuantitySelector.TabIndex = 5;
            // 
            // lb_db
            // 
            this.lb_db.AutoSize = true;
            this.lb_db.Location = new System.Drawing.Point(395, 152);
            this.lb_db.Name = "lb_db";
            this.lb_db.Size = new System.Drawing.Size(24, 17);
            this.lb_db.TabIndex = 6;
            this.lb_db.Text = "db";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(599, 286);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(113, 46);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Visible = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(537, 235);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(73, 17);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.Visible = false;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(534, 186);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(77, 17);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Username:";
            this.lbl_Username.Visible = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(621, 231);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '-';
            this.textBox_password.Size = new System.Drawing.Size(151, 22);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.Visible = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(621, 186);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(151, 22);
            this.textBox_username.TabIndex = 8;
            this.textBox_username.Visible = false;
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Admin.Location = new System.Drawing.Point(565, 103);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(174, 32);
            this.lbl_Admin.TabIndex = 7;
            this.lbl_Admin.Text = "Admin Login";
            this.lbl_Admin.Visible = false;
            // 
            // lb_addItem
            // 
            this.lb_addItem.AutoSize = true;
            this.lb_addItem.Location = new System.Drawing.Point(315, 75);
            this.lb_addItem.Name = "lb_addItem";
            this.lb_addItem.Size = new System.Drawing.Size(137, 17);
            this.lb_addItem.TabIndex = 13;
            this.lb_addItem.Text = "Termék hozzáadása";
            this.lb_addItem.Visible = false;
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(318, 110);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(100, 22);
            this.textBox_itemName.TabIndex = 14;
            this.textBox_itemName.Visible = false;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(318, 197);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 15;
            this.btn_addItem.Text = "Hozzáadás";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.textBox_itemName);
            this.Controls.Add(this.lb_addItem);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.lbl_Admin);
            this.Controls.Add(this.lb_db);
            this.Controls.Add(this.itemQuantitySelector);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.lb_availableItems);
            this.Controls.Add(this.listbox_availableItems);
            this.Controls.Add(this.topLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantitySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.ListBox listbox_availableItems;
        private System.Windows.Forms.Label lb_availableItems;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.NumericUpDown itemQuantitySelector;
        private System.Windows.Forms.Label lb_db;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.Label lb_addItem;
        private System.Windows.Forms.TextBox textBox_itemName;
        private System.Windows.Forms.Button btn_addItem;
    }
}

