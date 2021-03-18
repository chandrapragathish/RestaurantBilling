namespace Restaurant_Billing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelslide = new System.Windows.Forms.Panel();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_kot = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btn_Master = new System.Windows.Forms.Button();
            this.pnl_Master = new System.Windows.Forms.Panel();
            this.btn_guest = new System.Windows.Forms.Button();
            this.btn_waiter = new System.Windows.Forms.Button();
            this.btn_tax = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_divsion = new System.Windows.Forms.Button();
            this.btn_itemUnit = new System.Windows.Forms.Button();
            this.btn_itemCategory = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.pnl_KOT = new System.Windows.Forms.Panel();
            this.btn_prsKot = new System.Windows.Forms.Button();
            this.btnkot = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnl_Master.SuspendLayout();
            this.pnl_KOT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panelslide);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_kot);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.btn_Master);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 89);
            this.panel1.TabIndex = 0;
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.Red;
            this.panelslide.Location = new System.Drawing.Point(250, 3);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(163, 10);
            this.panelslide.TabIndex = 1;
            // 
            // btn_billing
            // 
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Location = new System.Drawing.Point(590, 12);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(164, 74);
            this.btn_billing.TabIndex = 15;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            this.btn_billing.MouseHover += new System.EventHandler(this.btn_billing_MouseHover);
            // 
            // btn_kot
            // 
            this.btn_kot.FlatAppearance.BorderSize = 0;
            this.btn_kot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kot.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kot.ForeColor = System.Drawing.Color.White;
            this.btn_kot.Location = new System.Drawing.Point(420, 12);
            this.btn_kot.Name = "btn_kot";
            this.btn_kot.Size = new System.Drawing.Size(164, 74);
            this.btn_kot.TabIndex = 14;
            this.btn_kot.Text = "KOT";
            this.btn_kot.UseVisualStyleBackColor = true;
            this.btn_kot.Click += new System.EventHandler(this.btn_kot_Click);
            this.btn_kot.MouseHover += new System.EventHandler(this.btn_kot_MouseHover);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Restaurant_Billing.Properties.Resources.The_Madras;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(0, -4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(244, 97);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // btn_Master
            // 
            this.btn_Master.FlatAppearance.BorderSize = 0;
            this.btn_Master.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Master.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Master.ForeColor = System.Drawing.Color.White;
            this.btn_Master.Location = new System.Drawing.Point(250, 15);
            this.btn_Master.Name = "btn_Master";
            this.btn_Master.Size = new System.Drawing.Size(164, 74);
            this.btn_Master.TabIndex = 0;
            this.btn_Master.Text = "Master";
            this.btn_Master.UseVisualStyleBackColor = true;
            this.btn_Master.Click += new System.EventHandler(this.btn_Master_Click);
            this.btn_Master.MouseHover += new System.EventHandler(this.btn_Master_MouseHover);
            // 
            // pnl_Master
            // 
            this.pnl_Master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnl_Master.Controls.Add(this.btn_guest);
            this.pnl_Master.Controls.Add(this.btn_waiter);
            this.pnl_Master.Controls.Add(this.btn_tax);
            this.pnl_Master.Controls.Add(this.button1);
            this.pnl_Master.Controls.Add(this.btn_divsion);
            this.pnl_Master.Controls.Add(this.btn_itemUnit);
            this.pnl_Master.Controls.Add(this.btn_itemCategory);
            this.pnl_Master.Controls.Add(this.btn_item);
            this.pnl_Master.Location = new System.Drawing.Point(250, 86);
            this.pnl_Master.Name = "pnl_Master";
            this.pnl_Master.Size = new System.Drawing.Size(164, 429);
            this.pnl_Master.TabIndex = 3;
            this.pnl_Master.Visible = false;
            // 
            // btn_guest
            // 
            this.btn_guest.FlatAppearance.BorderSize = 0;
            this.btn_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guest.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guest.ForeColor = System.Drawing.Color.White;
            this.btn_guest.Location = new System.Drawing.Point(0, 370);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(161, 47);
            this.btn_guest.TabIndex = 4;
            this.btn_guest.Text = "Guest";
            this.btn_guest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guest.UseVisualStyleBackColor = true;
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // btn_waiter
            // 
            this.btn_waiter.FlatAppearance.BorderSize = 0;
            this.btn_waiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_waiter.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_waiter.ForeColor = System.Drawing.Color.White;
            this.btn_waiter.Location = new System.Drawing.Point(0, 317);
            this.btn_waiter.Name = "btn_waiter";
            this.btn_waiter.Size = new System.Drawing.Size(161, 47);
            this.btn_waiter.TabIndex = 3;
            this.btn_waiter.Text = "Waiter";
            this.btn_waiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_waiter.UseVisualStyleBackColor = true;
            this.btn_waiter.Click += new System.EventHandler(this.btn_waiter_Click);
            // 
            // btn_tax
            // 
            this.btn_tax.FlatAppearance.BorderSize = 0;
            this.btn_tax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tax.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tax.ForeColor = System.Drawing.Color.White;
            this.btn_tax.Location = new System.Drawing.Point(0, 264);
            this.btn_tax.Name = "btn_tax";
            this.btn_tax.Size = new System.Drawing.Size(161, 47);
            this.btn_tax.TabIndex = 2;
            this.btn_tax.Text = "Tax";
            this.btn_tax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tax.UseVisualStyleBackColor = true;
            this.btn_tax.Click += new System.EventHandler(this.btn_tax_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tables";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_divsion
            // 
            this.btn_divsion.FlatAppearance.BorderSize = 0;
            this.btn_divsion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divsion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divsion.ForeColor = System.Drawing.Color.White;
            this.btn_divsion.Location = new System.Drawing.Point(2, 158);
            this.btn_divsion.Name = "btn_divsion";
            this.btn_divsion.Size = new System.Drawing.Size(161, 47);
            this.btn_divsion.TabIndex = 0;
            this.btn_divsion.Text = "Item Division";
            this.btn_divsion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_divsion.UseVisualStyleBackColor = true;
            this.btn_divsion.Click += new System.EventHandler(this.btn_divsion_Click);
            // 
            // btn_itemUnit
            // 
            this.btn_itemUnit.FlatAppearance.BorderSize = 0;
            this.btn_itemUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemUnit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemUnit.ForeColor = System.Drawing.Color.White;
            this.btn_itemUnit.Location = new System.Drawing.Point(0, 105);
            this.btn_itemUnit.Name = "btn_itemUnit";
            this.btn_itemUnit.Size = new System.Drawing.Size(161, 47);
            this.btn_itemUnit.TabIndex = 0;
            this.btn_itemUnit.Text = "Item Unit";
            this.btn_itemUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemUnit.UseVisualStyleBackColor = true;
            this.btn_itemUnit.Click += new System.EventHandler(this.btn_itemUnit_Click);
            // 
            // btn_itemCategory
            // 
            this.btn_itemCategory.FlatAppearance.BorderSize = 0;
            this.btn_itemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemCategory.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemCategory.ForeColor = System.Drawing.Color.White;
            this.btn_itemCategory.Location = new System.Drawing.Point(0, 52);
            this.btn_itemCategory.Name = "btn_itemCategory";
            this.btn_itemCategory.Size = new System.Drawing.Size(161, 47);
            this.btn_itemCategory.TabIndex = 0;
            this.btn_itemCategory.Text = "Item Category";
            this.btn_itemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemCategory.UseVisualStyleBackColor = true;
            this.btn_itemCategory.Click += new System.EventHandler(this.btn_itemCategory_Click);
            // 
            // btn_item
            // 
            this.btn_item.FlatAppearance.BorderSize = 0;
            this.btn_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_item.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ForeColor = System.Drawing.Color.White;
            this.btn_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_item.Location = new System.Drawing.Point(0, 0);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(161, 47);
            this.btn_item.TabIndex = 0;
            this.btn_item.Text = "Menu Item";
            this.btn_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_item.UseVisualStyleBackColor = true;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // pnl_KOT
            // 
            this.pnl_KOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnl_KOT.Controls.Add(this.btn_prsKot);
            this.pnl_KOT.Controls.Add(this.btnkot);
            this.pnl_KOT.Location = new System.Drawing.Point(420, 86);
            this.pnl_KOT.Name = "pnl_KOT";
            this.pnl_KOT.Size = new System.Drawing.Size(164, 119);
            this.pnl_KOT.TabIndex = 3;
            this.pnl_KOT.Visible = false;
            // 
            // btn_prsKot
            // 
            this.btn_prsKot.FlatAppearance.BorderSize = 0;
            this.btn_prsKot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prsKot.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsKot.ForeColor = System.Drawing.Color.White;
            this.btn_prsKot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prsKot.Location = new System.Drawing.Point(3, 53);
            this.btn_prsKot.Name = "btn_prsKot";
            this.btn_prsKot.Size = new System.Drawing.Size(161, 47);
            this.btn_prsKot.TabIndex = 5;
            this.btn_prsKot.Text = "Processing";
            this.btn_prsKot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prsKot.UseVisualStyleBackColor = true;
            this.btn_prsKot.Click += new System.EventHandler(this.btn_prsKot_Click);
            // 
            // btnkot
            // 
            this.btnkot.FlatAppearance.BorderSize = 0;
            this.btnkot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkot.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkot.ForeColor = System.Drawing.Color.White;
            this.btnkot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkot.Location = new System.Drawing.Point(3, 0);
            this.btnkot.Name = "btnkot";
            this.btnkot.Size = new System.Drawing.Size(161, 47);
            this.btnkot.TabIndex = 4;
            this.btnkot.Text = "KOT";
            this.btnkot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkot.UseVisualStyleBackColor = true;
            this.btnkot.Click += new System.EventHandler(this.btnkot_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Location = new System.Drawing.Point(0, 722);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 29);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_KOT);
            this.Controls.Add(this.pnl_Master);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnl_Master.ResumeLayout(false);
            this.pnl_KOT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btn_Master;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_kot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Master;
        private System.Windows.Forms.Panel pnl_KOT;
        private System.Windows.Forms.Button btn_itemCategory;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_itemUnit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_divsion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tax;
        private System.Windows.Forms.Button btn_waiter;
        private System.Windows.Forms.Button btnkot;
        private System.Windows.Forms.Button btn_prsKot;
        private System.Windows.Forms.Button btn_guest;
    }
}