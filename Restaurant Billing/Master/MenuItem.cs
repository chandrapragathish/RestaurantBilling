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
    public partial class MenuItem : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        Boolean GridSelect = false;
        public MenuItem()
        {
            InitializeComponent();
        }

        private void MenuItem_Load(object sender, EventArgs e)
        {
           
            Refresh();
            clearTxt();
        }
        void clearTxt()
        {
            txt_code.Text = cdata.GetSingleValue("select MAX(Code)+1 Code from menu_item");
            txt_name.Text = "";
            txt_printName.Text = "";
            cbo_category.Text = "Select";
            cbo_unit.Text = "Select";
            cbo_division.Text = "Select";
            txt_price.Text = "";
            txt_disc.Text = "";
        }
        void Refresh()
        {
            txt_code.Text = cdata.GetSingleValue("select MAX(Code)+1 Code from menu_item");
            GridSelect = false;
            txt_name.Text = "";
            txt_printName.Text = "";
            txt_price.Text = "";
            txt_disc.Text = "";

           

            DataTable dt = cdata.GetTable("select * from menu_item");
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
           

            dt = cdata.GetTable("select * from item_category");
            cbo_category.DataSource = dt;
            cbo_category.DisplayMember = "Category";
            cbo_category.Text = "Select";

            dt = cdata.GetTable("select * from item_unit");
            cbo_unit.DataSource = dt;
            cbo_unit.DisplayMember = "Unit";
            cbo_unit.Text = "Select";

            dt = cdata.GetTable("select * from item_division");
            cbo_division.DataSource = dt;
            cbo_division.DisplayMember = "Division";
            cbo_division.Text = "Select";
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
                if (cdata.GetSingleValue("select Code from menu_item where Code=" + txt_code.Text + "") == "")
                {
                    Boolean result = cdata.ExecuteQry("insert into menu_item (Name,PrintName,Category,Unit,Division,Price,Discount) values('" + txt_name.Text + "','" + txt_printName.Text + "','" + cbo_category.Text + "','" + cbo_unit.Text + "','" + cbo_division.Text + "','" + txt_price.Text + "','" + txt_disc.Text + "')");
                    if (result == true)
                        MessageBox.Show("Item Added sucessfully");
                    else
                        MessageBox.Show("Item Not Inserted");
                }
                else
                {
                    Boolean result = cdata.ExecuteQry("update  menu_item set Name='" + txt_name.Text + "',PrintName='" + txt_printName.Text + "',Category='" + cbo_category.Text + "',Unit='" + cbo_unit.Text + "',Division='" + cbo_division.Text + "',Price=" + txt_price.Text + ",Discount=" + txt_disc.Text + " where Code=" + txt_code.Text + " ");
                    if (result == true)
                        MessageBox.Show("Item Updated sucessfully");
                    else
                        MessageBox.Show("Item Not Updated");
                }
                Refresh();
                clearTxt();
            }
            catch { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Boolean result = cdata.ExecuteQry("delete from menu_item where Code=" + txt_code.Text + "");
            Refresh();
            clearTxt();
            if (result)
            {
                MessageBox.Show("Category Deleted sucessfully");

            }

            else
                MessageBox.Show("Category Not Deleted");

          
           
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
            clearTxt();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (GridSelect)
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txt_code.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                txt_name.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                txt_printName.Text = Convert.ToString(selectedRow.Cells["PrintName"].Value);
                cbo_category.Text = Convert.ToString(selectedRow.Cells["Category"].Value);
                cbo_unit.Text = Convert.ToString(selectedRow.Cells["Unit"].Value);
                cbo_division.Text = Convert.ToString(selectedRow.Cells["Division"].Value);
                txt_price.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
                txt_disc.Text = Convert.ToString(selectedRow.Cells["Discount"].Value);
            }
            GridSelect = true;
        }


    }
}
