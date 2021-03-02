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
            dt = cdata.GetTable("select kot_no,table_name 'Table Name',Nop,WaiterName,waiterCode,sum(qty) Qty,count(*) 'Total Item',DateTime from kot group by kot_no order by DateTime asc");
            dgv.DataSource = dt;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void btn_kotProcess_Click(object sender, EventArgs e)
        {
            this.Close();
            kot Main = new kot();
            Main.Show();
        }





    }
}
