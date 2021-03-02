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
            this.btn_kotProcess = new System.Windows.Forms.Button();
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
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1070, 561);
            this.dgv.TabIndex = 32;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = global::Restaurant_Billing.Properties.Resources.HomeSmall;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(975, 674);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(124, 40);
            this.btn_home.TabIndex = 71;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_kotProcess
            // 
            this.btn_kotProcess.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_kotProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kotProcess.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kotProcess.Image = global::Restaurant_Billing.Properties.Resources.ProcessSmall;
            this.btn_kotProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kotProcess.Location = new System.Drawing.Point(829, 674);
            this.btn_kotProcess.Name = "btn_kotProcess";
            this.btn_kotProcess.Size = new System.Drawing.Size(124, 40);
            this.btn_kotProcess.TabIndex = 73;
            this.btn_kotProcess.Text = "KOT";
            this.btn_kotProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kotProcess.UseVisualStyleBackColor = false;
            this.btn_kotProcess.Click += new System.EventHandler(this.btn_kotProcess_Click);
            // 
            // ProcessKot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btn_kotProcess);
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
        private System.Windows.Forms.Button btn_kotProcess;
    }
}