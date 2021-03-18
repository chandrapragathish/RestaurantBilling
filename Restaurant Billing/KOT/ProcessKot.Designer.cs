namespace Restaurant_Billing.Master
{
    partial class ProcessKot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessKot));
            this.itemMaster = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_kot = new System.Windows.Forms.Button();
            this.btn_chgkot = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // itemMaster
            // 
            this.itemMaster.AutoSize = true;
            this.itemMaster.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMaster.ForeColor = System.Drawing.Color.Red;
            this.itemMaster.Location = new System.Drawing.Point(23, 24);
            this.itemMaster.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemMaster.Name = "itemMaster";
            this.itemMaster.Size = new System.Drawing.Size(238, 32);
            this.itemMaster.TabIndex = 0;
            this.itemMaster.Text = "PROCESSING KOT";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 85);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(971, 561);
            this.dgv.TabIndex = 32;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = global::Restaurant_Billing.Properties.Resources.HomeSmall;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(878, 675);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 40);
            this.btn_home.TabIndex = 71;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_kot
            // 
            this.btn_kot.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_kot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kot.Image = global::Restaurant_Billing.Properties.Resources.ProcessSmall;
            this.btn_kot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kot.Location = new System.Drawing.Point(562, 675);
            this.btn_kot.Name = "btn_kot";
            this.btn_kot.Size = new System.Drawing.Size(128, 40);
            this.btn_kot.TabIndex = 73;
            this.btn_kot.Text = "New KOT";
            this.btn_kot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kot.UseVisualStyleBackColor = false;
            this.btn_kot.Click += new System.EventHandler(this.btn_kot_Click);
            // 
            // btn_chgkot
            // 
            this.btn_chgkot.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_chgkot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chgkot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chgkot.Image = global::Restaurant_Billing.Properties.Resources.ProcessSmall;
            this.btn_chgkot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chgkot.Location = new System.Drawing.Point(1081, 449);
            this.btn_chgkot.Name = "btn_chgkot";
            this.btn_chgkot.Size = new System.Drawing.Size(154, 40);
            this.btn_chgkot.TabIndex = 74;
            this.btn_chgkot.Text = "Change KOT";
            this.btn_chgkot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chgkot.UseVisualStyleBackColor = false;
            this.btn_chgkot.Visible = false;
            this.btn_chgkot.Click += new System.EventHandler(this.btn_chgkot_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.Image = global::Restaurant_Billing.Properties.Resources.Billing;
            this.btn_billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_billing.Location = new System.Drawing.Point(422, 675);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(111, 40);
            this.btn_billing.TabIndex = 122;
            this.btn_billing.Text = "Billing";
            this.btn_billing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Image = global::Restaurant_Billing.Properties.Resources.Remove;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(1094, 506);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(118, 40);
            this.btn_remove.TabIndex = 123;
            this.btn_remove.Text = "Remove";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Visible = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::Restaurant_Billing.Properties.Resources.RefeshSmall1;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(723, 675);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(127, 40);
            this.btn_refresh.TabIndex = 124;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ProcessKot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_billing);
            this.Controls.Add(this.btn_chgkot);
            this.Controls.Add(this.btn_kot);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.itemMaster);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProcessKot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MenuItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProcessKot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemMaster;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_kot;
        private System.Windows.Forms.Button btn_chgkot;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_refresh;
    }
}