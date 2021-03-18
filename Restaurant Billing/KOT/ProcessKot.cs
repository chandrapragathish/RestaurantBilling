using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Restaurant_Billing.Master
{
    public partial class ProcessKot : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public ProcessKot()
        {
            InitializeComponent();

        }

        private void ProcessKot_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cdata.GetTable("Select kot.kot_no KotNo,table_name 'Table Name',Nop,WaiterName,waiterCode,sum(qty) Qty,count(*) 'Total Item',DateTime from kot inner join kot_item on kot.kot_no=kot_item.kot_no GROUP by kot.kot_no order by kot.kot_no");
            dgv.DataSource = dt;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 130;
            dgv.Columns[2].Width = 70;
            dgv.Columns[3].Width = 120;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 115;
            dgv.Columns[7].Width = 250;
            dgv.Columns["KotNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Nop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["waiterCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Total Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ClearSelection();
        }

        
        private void btn_billing_Click(object sender, EventArgs e)
        {
            try
            {
                Globalvar.kot = Convert.ToInt64(dgv.SelectedRows[0].Cells["KotNo"].Value);
                this.Close();
                Billing Main = new Billing();
                Main.Show();
            }
            catch
            {
                MessageBox.Show("Please select Kot");
            }
        }
        private void btn_kot_Click(object sender, EventArgs e)
        {
            this.Close();
            kot Main = new kot();
            Main.Show();
        }

       

        private void btn_chgkot_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cdata.GetTable("Select kot.kot_no KotNo,table_name 'Table Name',Nop,WaiterName,waiterCode,sum(qty) Qty,count(*) 'Total Item',DateTime from kot inner join kot_item on kot.kot_no=kot_item.kot_no GROUP by kot.kot_no order by kot.kot_no");
            dgv.DataSource = dt;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 130;
            dgv.Columns[2].Width = 70;
            dgv.Columns[3].Width = 120;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 115;
            dgv.Columns[7].Width = 250;
            dgv.Columns["KotNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Nop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["waiterCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Total Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ClearSelection();
        }

   




    }
}
