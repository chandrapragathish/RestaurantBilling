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
    public partial class Division : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        public Division()
        {
            InitializeComponent();

        }

        private void MenuItem_Load(object sender, EventArgs e)
        {
            Refresh();

        }
        void Refresh()
        {
            txt_name.Text = "";
            lstbx_division.SelectionMode = SelectionMode.None;
            DataTable dt = cdata.GetTable("select * from item_division");
            lstbx_division.DataSource = dt;
            lstbx_division.DisplayMember = "Division";
            lstbx_division.ValueMember = "Code";
            lstbx_division.ClearSelected();
            lstbx_division.SelectionMode = SelectionMode.One;
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "")
                    if (cdata.GetSingleValue("SELECT * from item_division where Division='" + txt_name.Text + "'") == "")
                    {
                        int flag = 0;
                        foreach (var item in lstbx_division.SelectedItems)
                        {
                            Boolean result = cdata.ExecuteQry("update  item_division set Division='" + txt_name.Text + "' where Code=" + ((DataRowView)item)["Code"].ToString() + "");
                            if (result)
                            {
                                lbl_msg.ForeColor = Color.Lime;
                                DisplayWarning("Division Updated sucessfully");
                                flag = 1;
                            }

                            else
                            {
                                flag = 1;
                                lbl_msg.ForeColor = Color.Red;
                                DisplayWarning("Division Not Updated");
                            }

                        }

                        if (flag == 0)
                        {
                            Boolean result = cdata.ExecuteQry("insert into item_division (Division) values('" + txt_name.Text + "')");
                            if (result == true)
                            {
                                lbl_msg.ForeColor = Color.Lime;
                                DisplayWarning("Division Added Sucessfully!");
                            }
                            else
                            {
                                lbl_msg.ForeColor = Color.Red;
                                DisplayWarning("Division Not Inserted");
                            }
                            Refresh();
                        }
                    }
                    else
                    {
                        lbl_msg.ForeColor = Color.Red;
                        DisplayWarning("'" + txt_name.Text + "' is Already exist");
                    }


                Refresh();



            }
            catch { }
        }

        private void lstbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in lstbx_division.SelectedItems)
            {
                txt_name.Text = ((DataRowView)item)["Division"].ToString();

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {

                foreach (var item in lstbx_division.SelectedItems)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete", "Delete Division", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Boolean result = cdata.ExecuteQry("delete from item_division where Code=" + ((DataRowView)item)["Code"].ToString() + "");
                        if (result)
                        {
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Division Deleted sucessfully");

                        }

                        else
                        {

                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Division Not Deleted");
                        }

                    }
                    Refresh();
                }

            }
            catch { }

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
