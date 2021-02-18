namespace Restaurant_Billing.Master
{
    partial class Category
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
            System.Windows.Forms.Label lbl_Name;
            System.Windows.Forms.Label lbl_category;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.itemMaster = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lstbx_category = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            lbl_Name = new System.Windows.Forms.Label();
            lbl_category = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Name.ForeColor = System.Drawing.Color.Aqua;
            lbl_Name.Location = new System.Drawing.Point(97, 110);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new System.Drawing.Size(100, 28);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Category";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_category.ForeColor = System.Drawing.Color.White;
            lbl_category.Location = new System.Drawing.Point(3, 5);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new System.Drawing.Size(104, 30);
            lbl_category.TabIndex = 23;
            lbl_category.Text = "Category";
            // 
            // itemMaster
            // 
            this.itemMaster.AutoSize = true;
            this.itemMaster.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMaster.ForeColor = System.Drawing.Color.Red;
            this.itemMaster.Location = new System.Drawing.Point(23, 24);
            this.itemMaster.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemMaster.Name = "itemMaster";
            this.itemMaster.Size = new System.Drawing.Size(265, 32);
            this.itemMaster.TabIndex = 0;
            this.itemMaster.Text = "CATEGORY MASTER";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(233, 105);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 36);
            this.txt_name.TabIndex = 15;
            // 
            // lstbx_category
            // 
            this.lstbx_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lstbx_category.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_category.ForeColor = System.Drawing.Color.Ivory;
            this.lstbx_category.FormattingEnabled = true;
            this.lstbx_category.ItemHeight = 28;
            this.lstbx_category.Location = new System.Drawing.Point(567, 138);
            this.lstbx_category.Name = "lstbx_category";
            this.lstbx_category.Size = new System.Drawing.Size(284, 452);
            this.lstbx_category.TabIndex = 21;
            this.lstbx_category.SelectedIndexChanged += new System.EventHandler(this.lstbx_category_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::Restaurant_Billing.Properties.Resources.Refresh1;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(339, 411);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(144, 57);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = global::Restaurant_Billing.Properties.Resources.Home1;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(339, 528);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(144, 57);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Restaurant_Billing.Properties.Resources.Delete11;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(339, 306);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(144, 57);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Restaurant_Billing.Properties.Resources.Save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(339, 197);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 56);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(lbl_category);
            this.panel1.Location = new System.Drawing.Point(567, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 43);
            this.panel1.TabIndex = 22;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Lime;
            this.lbl_msg.Location = new System.Drawing.Point(219, 154);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(264, 26);
            this.lbl_msg.TabIndex = 24;
            this.lbl_msg.Text = "Category Added Sucessfully";
            this.lbl_msg.Visible = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstbx_category);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(lbl_Name);
            this.Controls.Add(this.itemMaster);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MenuItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemMaster;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ListBox lstbx_category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_msg;
    }
}