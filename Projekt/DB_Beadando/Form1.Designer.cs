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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

