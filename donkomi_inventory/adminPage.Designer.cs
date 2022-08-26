namespace donkomi_inventory
{
    partial class adminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.attendants = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.adminIcon = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.adminIcon);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 704);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 530);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.category);
            this.panel5.Controls.Add(this.products);
            this.panel5.Controls.Add(this.attendants);
            this.panel5.Controls.Add(this.home);
            this.panel5.Location = new System.Drawing.Point(0, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 334);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightCyan;
            this.panel7.Controls.Add(this.vScrollBar1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(262, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(818, 704);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 705);
            this.panel3.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::donkomi_inventory.Properties.Resources.icons8_stockpile_64;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(36, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(290, 77);
            this.button6.TabIndex = 12;
            this.button6.Text = "Stock";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::donkomi_inventory.Properties.Resources.icons8_inspection_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(36, 571);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(290, 77);
            this.button5.TabIndex = 11;
            this.button5.Text = "Reorders";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::donkomi_inventory.Properties.Resources.icons8_sales_64;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(36, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 77);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sales Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::donkomi_inventory.Properties.Resources.icons8_home_page_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(818, 72);
            this.button2.TabIndex = 8;
            this.button2.Text = "    Home Page";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Gold;
            this.category.Dock = System.Windows.Forms.DockStyle.Top;
            this.category.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.category.FlatAppearance.BorderSize = 2;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Image = global::donkomi_inventory.Properties.Resources.icons8_products_64;
            this.category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.category.Location = new System.Drawing.Point(0, 204);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(262, 68);
            this.category.TabIndex = 6;
            this.category.Text = "  Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.category.UseVisualStyleBackColor = false;
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.Gold;
            this.products.Dock = System.Windows.Forms.DockStyle.Top;
            this.products.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.products.FlatAppearance.BorderSize = 2;
            this.products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Image = global::donkomi_inventory.Properties.Resources.icons8_handcart_64;
            this.products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products.Location = new System.Drawing.Point(0, 136);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(262, 68);
            this.products.TabIndex = 5;
            this.products.Text = "  Products";
            this.products.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.products.UseVisualStyleBackColor = false;
            // 
            // attendants
            // 
            this.attendants.BackColor = System.Drawing.Color.Gold;
            this.attendants.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendants.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.attendants.FlatAppearance.BorderSize = 2;
            this.attendants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendants.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendants.Image = global::donkomi_inventory.Properties.Resources.users;
            this.attendants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendants.Location = new System.Drawing.Point(0, 68);
            this.attendants.Name = "attendants";
            this.attendants.Size = new System.Drawing.Size(262, 68);
            this.attendants.TabIndex = 4;
            this.attendants.Text = "  Attendants";
            this.attendants.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attendants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attendants.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Gold;
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.home.FlatAppearance.BorderSize = 2;
            this.home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Image = global::donkomi_inventory.Properties.Resources.icons8_home_page_50;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(262, 68);
            this.home.TabIndex = 3;
            this.home.Text = "    Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home.UseVisualStyleBackColor = false;
            // 
            // adminIcon
            // 
            this.adminIcon.BackColor = System.Drawing.Color.Gold;
            this.adminIcon.BackgroundImage = global::donkomi_inventory.Properties.Resources.icons8_admin_settings_male_50;
            this.adminIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminIcon.Location = new System.Drawing.Point(0, 0);
            this.adminIcon.Name = "adminIcon";
            this.adminIcon.Size = new System.Drawing.Size(262, 106);
            this.adminIcon.TabIndex = 1;
            this.adminIcon.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Gold;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 4;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = global::donkomi_inventory.Properties.Resources.icons8_logout_50;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 636);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(262, 68);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "  Log Out";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Table goes here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Table goes here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Table goes here";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(797, 70);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 634);
            this.vScrollBar1.TabIndex = 16;
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 704);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "adminPage";
            this.Text = "adminPage";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox adminIcon;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button attendants;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}