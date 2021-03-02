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
    public partial class Tables : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public Tables()
        {
            InitializeComponent();

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (cdata.GetSingleValue("select Code from table_master where Code=" + txt_code.Text + "") == "")
                {
                    if (cdata.GetSingleValue("select TableNo from table_master where TableNo=" + txt_tblno.Text + "") == "")
                    {

                        Boolean result = cdata.ExecuteQry("insert into table_master (TableNo,Location,Status) values(" + txt_tblno.Text + ",'" + cbo_location.Text + "','" + cbo_status.Text + "')");
                        if (result == true)
                        {
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Table Added sucessfully");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Table Not Added");
                        }
                    }
                    else
                        DisplayWarning(txt_tblno.Text + " is already exist!");
                }
                else
                {
                    Boolean result = cdata.ExecuteQry("update  table_master set TableNo=" + txt_tblno.Text + ",Location='" + cbo_location.Text + "',Status='" + cbo_status.Text + "' where Code=" + txt_code.Text + " ");
                    if (result == true)
                    {
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("Table Updated sucessfully");
                    }
                    else
                    {
                        lbl_msg.ForeColor = Color.Red;
                        DisplayWarning("Table Not Updated");

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
            DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete", "Delete Table", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Boolean result = cdata.ExecuteQry("delete from table_master where Code=" + txt_code.Text + "");
                Refresh();
                clearTxt();
                if (result)
                {
                    DisplayWarning("Table Deleted sucessfully");

                }

                else
                    DisplayWarning("Table Not Deleted");
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

        private void Tables_Load(object sender, EventArgs e)
        {

            Refresh();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];
                txt_code.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                txt_tblno.Text = Convert.ToString(selectedRow.Cells["TableNo"].Value).Substring(6, 1);
                cbo_location.Text = selectedRow.Cells["Location"].Value.ToString();
                cbo_status.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }
        void Refresh()
        {

            DataTable dt = cdata.GetTable("select Code,convert(concat('Table-',TableNo),char(10)) TableNo,Location,status from table_master order by TableNo");
            dgv.DataSource = dt;
            dgv.Columns["Code"].Visible = false;
            dgv.ClearSelection();
            dgv.Columns[1].Width = 110;
            dgv.Columns[2].Width = 160;
            dgv.Columns[3].Width = 200;
            clearTxt();
        }
        void clearTxt()
        {
            txt_code.Text = "";
            txt_tblno.Text = "";
            cbo_location.Text = "Select";
            cbo_status.Text = "Select";
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

    }
}
