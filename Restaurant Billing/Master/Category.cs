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
    public partial class Category : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();

        public Category()
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
            lstbx_category.SelectionMode = SelectionMode.None;
            DataTable dt = cdata.GetTable("select * from item_category");
            lstbx_category.DataSource = dt;
            lstbx_category.DisplayMember = "Category";
            lstbx_category.ValueMember = "Code";
            lstbx_category.ClearSelected();
            lstbx_category.SelectionMode = SelectionMode.One;
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
                    if (cdata.GetSingleValue("SELECT * from item_category where Category='" + txt_name.Text + "'") == "")
                    {
                        int flag = 0;
                        foreach (var item in lstbx_category.SelectedItems)
                        {
                            Boolean result = cdata.ExecuteQry("update  item_category set Category='" + txt_name.Text + "' where Code=" + ((DataRowView)item)["Code"].ToString() + "");
                            if (result)
                            {
                                lbl_msg.ForeColor = Color.Lime;
                                DisplayWarning("Category Updated sucessfully");
                                flag = 1;

                            }

                            else
                            {
                                flag = 1;
                                lbl_msg.ForeColor = Color.Red;
                                DisplayWarning("Category Not Updated");
                            }
                        }


                        if (flag == 0)
                        {
                            Boolean result = cdata.ExecuteQry("insert into item_category (Category) values('" + txt_name.Text + "')");
                            if (result == true)
                            {
                                lbl_msg.ForeColor = Color.Lime;
                                DisplayWarning("Category Added Sucessfully!");
                            }
                            else
                            {
                                lbl_msg.ForeColor = Color.Red;
                                DisplayWarning("Category Not Inserted");
                            }
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
            foreach (var item in lstbx_category.SelectedItems)
            {
                txt_name.Text = ((DataRowView)item)["Category"].ToString();

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

                foreach (var item in lstbx_category.SelectedItems)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete", "Delete Category", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Boolean result = cdata.ExecuteQry("delete from item_category where Code=" + ((DataRowView)item)["Code"].ToString() + "");
                        if (result)
                        {
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Category Deleted sucessfully");

                        }

                        else
                        {

                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Category Not Deleted");
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
