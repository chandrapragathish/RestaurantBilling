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
    public partial class waiters : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public waiters()
        {
            InitializeComponent();

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (cdata.GetSingleValue("select convert(concat('Waiter-',Code),char(10)) Code from waiter where Code=" + txt_code.Text + "") == "")
                {

                    Boolean result = cdata.ExecuteQry("insert into waiter (Name,Phone,available) values('" + txt_name.Text + "'," + txt_phone.Text + "," + (cbo_available.Text == "Yes" ? 1 : 0) + ")");
                        if (result == true)
                        {
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Waiter Added sucessfully");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Waiter Not Added");
                        }
                   
                }
                else
                {
                    Boolean result = cdata.ExecuteQry("update  waiter set Name='" + txt_name.Text + "',Phone='" + txt_phone.Text + "',available=" + (cbo_available.Text == "Yes" ? 1 : 0) + " where Code=" + txt_code.Text + " ");
                    if (result == true)
                    {
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("Waiter Updated sucessfully");
                    }
                    else
                    {
                        lbl_msg.ForeColor = Color.Red;
                        DisplayWarning("Waiter Not Updated");

                    }
                }


                Refresh();
                clearTxt();
            }
            catch
            {
                Refresh();
                clearTxt(); DisplayWarning("Somthing went to wrong");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete", "Delete waiter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Boolean result = cdata.ExecuteQry("delete from waiter where Code=" + txt_code.Text + "");
                Refresh();
                clearTxt();
                if (result)
                {
                    DisplayWarning("waiter Deleted sucessfully");

                }

                else
                    DisplayWarning("waiter Not Deleted");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

       

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];
                txt_code.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                txt_name.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                txt_phone.Text = Convert.ToString(selectedRow.Cells["Phone"].Value);
                cbo_available.Text = selectedRow.Cells["available"].Value.ToString();
            }
        }
        void Refresh()
        {

            DataTable dt = cdata.GetTable("select  Code,Name,Phone,if(available=1,'Yes','No') available from waiter order by Code");
            dgv.DataSource = dt;
            dgv.ClearSelection();
            dgv.Columns[0].Width = 110;
            dgv.Columns[1].Width = 160;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 80;
            clearTxt();
        }
        void clearTxt()
        {
            txt_code.Text = "";
            txt_phone.Text = "";
            txt_name.Text = "";
            cbo_available.Text = "Yes";
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

        private void waiters_Load(object sender, EventArgs e)
        {
            Refresh();
        }

    }
}
