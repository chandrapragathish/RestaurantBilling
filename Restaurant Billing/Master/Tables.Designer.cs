﻿namespace Restaurant_Billing.Master
{
    partial class Tables
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.itemMaster = new System.Windows.Forms.Label();
            this.txt_tblno = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbo_location = new System.Windows.Forms.ComboBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            lbl_Name = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Name.ForeColor = System.Drawing.Color.Aqua;
            lbl_Name.Location = new System.Drawing.Point(97, 110);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new System.Drawing.Size(154, 28);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Table Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Aqua;
            label1.Location = new System.Drawing.Point(97, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 28);
            label1.TabIndex = 33;
            label1.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Aqua;
            label2.Location = new System.Drawing.Point(259, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 28);
            label2.TabIndex = 34;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Aqua;
            label3.Location = new System.Drawing.Point(259, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 28);
            label3.TabIndex = 35;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Aqua;
            label4.Location = new System.Drawing.Point(259, 214);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 28);
            label4.TabIndex = 38;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Aqua;
            label5.Location = new System.Drawing.Point(97, 214);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 28);
            label5.TabIndex = 37;
            label5.Text = "Status";
            // 
            // itemMaster
            // 
            this.itemMaster.AutoSize = true;
            this.itemMaster.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMaster.ForeColor = System.Drawing.Color.Red;
            this.itemMaster.Location = new System.Drawing.Point(23, 24);
            this.itemMaster.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemMaster.Name = "itemMaster";
            this.itemMaster.Size = new System.Drawing.Size(206, 32);
            this.itemMaster.TabIndex = 0;
            this.itemMaster.Text = "TABLE MASTER";
            // 
            // txt_tblno
            // 
            this.txt_tblno.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tblno.Location = new System.Drawing.Point(292, 107);
            this.txt_tblno.Name = "txt_tblno";
            this.txt_tblno.Size = new System.Drawing.Size(250, 36);
            this.txt_tblno.TabIndex = 15;
            this.txt_tblno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tblno_KeyPress);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::Restaurant_Billing.Properties.Resources.Refresh1;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(220, 410);
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
            this.btn_home.Location = new System.Drawing.Point(398, 410);
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
            this.btn_delete.Location = new System.Drawing.Point(398, 304);
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
            this.btn_save.Location = new System.Drawing.Point(220, 304);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 56);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Lime;
            this.lbl_msg.Location = new System.Drawing.Point(311, 259);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(231, 26);
            this.lbl_msg.TabIndex = 25;
            this.lbl_msg.Text = "Table Added Sucessfully";
            this.lbl_msg.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(584, 107);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(515, 360);
            this.dgv.TabIndex = 32;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // cbo_location
            // 
            this.cbo_location.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_location.FormattingEnabled = true;
            this.cbo_location.Items.AddRange(new object[] {
            "General",
            "A/C Room"});
            this.cbo_location.Location = new System.Drawing.Point(292, 163);
            this.cbo_location.Name = "cbo_location";
            this.cbo_location.Size = new System.Drawing.Size(250, 36);
            this.cbo_location.TabIndex = 39;
            this.cbo_location.Text = "Select";
            // 
            // cbo_status
            // 
            this.cbo_status.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Service Available",
            "Not Available"});
            this.cbo_status.Location = new System.Drawing.Point(292, 211);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(250, 36);
            this.cbo_status.TabIndex = 40;
            this.cbo_status.Text = "Select";
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(292, 86);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(10, 22);
            this.txt_code.TabIndex = 41;
            this.txt_code.Visible = false;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.cbo_location);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tblno);
            this.Controls.Add(lbl_Name);
            this.Controls.Add(this.itemMaster);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MenuItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemMaster;
        private System.Windows.Forms.TextBox txt_tblno;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbo_location;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.TextBox txt_code;
    }
}