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
    public partial class Tax : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public Tax()
        {
            InitializeComponent();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                Boolean result = cdata.ExecuteQry("update  Tax set CGST=" + txt_CGST.Text + ",SGST='" + txt_SGST.Text + "',S_Charge='" + txt_s_chrg.Text + "',Date='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "' ");
                if (result)
                {
                    lbl_msg.ForeColor = Color.Lime;
                    DisplayWarning("Tax Updated sucessfully");
                    Refresh();
                }
                else
                {
                    lbl_msg.ForeColor = Color.Red;
                    DisplayWarning("Tax Not Updated");
                    Refresh();
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("Somthing went to wrong");
                Refresh();
            }
        }

        private void Tax_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        void Refresh()
        {
            DataTable dt = cdata.GetTable("select * from tax");
            txt_SGST.Text = dt.Rows[0][0].ToString();
            txt_CGST.Text = dt.Rows[0][1].ToString();
            txt_s_chrg.Text = dt.Rows[0][2].ToString();
            txt_date.Text = dt.Rows[0][3].ToString();
        }
        private void DisplayWarning(String message, int Interval = 3000)
        {
            Timer timer = new Timer();
            timer.Interval = Interval;
            lbl_msg.Text = message;
            lbl_msg.Visible = true;

            // above two line sets the visibility and shows the message and interval elapses hide the visibility of the label. Elapsed will we called after Start() method.

            timer.Tick += (s, en) =>
            {
                lbl_msg.Visible = false;
                timer.Stop(); // Stop the timer(otherwise keeps on calling)
            };
            timer.Start(); // Starts the timer. 
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }
    }
}
