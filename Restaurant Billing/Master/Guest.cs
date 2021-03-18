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
    public partial class Guest : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public Guest()
        {
            InitializeComponent();

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (cdata.GetSingleValue("select  Code from guest where Code=" + txt_code.Text + "") == "")
                {

                    Boolean result = cdata.ExecuteQry("insert into guest (Name,Phone,Address) values('" + txt_name.Text + "'," + txt_phone.Text + ",'" + txt_Address.Text + "')");
                        if (result == true)
                        {
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Guest Added sucessfully");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Guest Not Added");
                        }
                   
                }
                else
                {
                    Boolean result = cdata.ExecuteQry("update  guest set Name='" + txt_name.Text + "',Phone='" + txt_phone.Text + "',Address='" + txt_Address.Text + "' where Code=" + txt_code.Text + " ");
                    if (result == true)
                    {
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("Guest Updated sucessfully");
                    }
                    else
                    {
                        lbl_msg.ForeColor = Color.Red;
                        DisplayWarning("Guest Not Updated");

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
            DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete", "Delete Guest", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Boolean result = cdata.ExecuteQry("delete from guest where Code=" + txt_code.Text + "");
                Refresh();
                clearTxt();
                if (result)
                {
                    DisplayWarning("Guest Deleted sucessfully");

                }

                else
                    DisplayWarning("Guest Not Deleted");
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
                txt_Address.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }
        void Refresh()
        {

            DataTable dt = cdata.GetTable("select  Code,Name,Phone, Address from guest order by Code");
            dgv.DataSource = dt;
            dgv.ClearSelection();
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 160;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 225;
            clearTxt();
        }
        void clearTxt()
        {
            txt_code.Text = "";
            txt_phone.Text = "";
            txt_name.Text = "";
            txt_Address.Text = "";
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

        private void Guest_Load(object sender, EventArgs e)
        {
            Refresh();
            txt_code.ReadOnly = true;
        }

       
    }
}
