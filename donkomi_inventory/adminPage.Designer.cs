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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.attendants = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.adminIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.adminIcon);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 743);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 61);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 569);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.category);
            this.panel5.Controls.Add(this.products);
            this.panel5.Controls.Add(this.attendants);
            this.panel5.Controls.Add(this.home);
            this.panel5.Location = new System.Drawing.Point(0, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 334);
            this.panel5.TabIndex = 4;
            // 
            // category
            // 
            this.category.Dock = System.Windows.Forms.DockStyle.Top;
            this.category.FlatAppearance.BorderSize = 0;
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
            this.category.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.Dock = System.Windows.Forms.DockStyle.Top;
            this.products.FlatAppearance.BorderSize = 0;
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
            this.products.UseVisualStyleBackColor = true;
            // 
            // attendants
            // 
            this.attendants.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendants.FlatAppearance.BorderSize = 0;
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
            this.attendants.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderSize = 0;
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
            this.home.UseVisualStyleBackColor = true;
            // 
            // adminIcon
            // 
            this.adminIcon.BackgroundImage = global::donkomi_inventory.Properties.Resources.icons8_male_user_64;
            this.adminIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminIcon.Location = new System.Drawing.Point(0, 0);
            this.adminIcon.Name = "adminIcon";
            this.adminIcon.Size = new System.Drawing.Size(262, 106);
            this.adminIcon.TabIndex = 1;
            this.adminIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::donkomi_inventory.Properties.Resources.icons8_logout_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "  Log Out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(256, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 687);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(256, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(826, 5);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(262, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(818, 682);
            this.panel7.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reorders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::donkomi_inventory.Properties.Resources.icons8_home_page_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(818, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "    Home";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 743);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminPage";
            this.Text = "adminPage";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox adminIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button attendants;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}