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
        }
        void Refresh()
        {
            txt_code.Text = cdata.GetSingleValue("select MAX(Code)+1 Code from menu_item");
            GridSelect = false;
            txt_name.Text = "";
            txt_printName.Text = "";
            txt_price.Text = "";



            DataTable dt = cdata.GetTable("select M.Code Code,Name,PrintName,M.Category Code_Category,C.Category Category,M.Unit Code_Unit,U.Unit Unit,M.Division Code_Division,D.Division Division,Price from menu_item M inner join item_category C on M.Category= C.Code inner join item_unit U on M.Unit= U.Code  inner join item_division D on M.Division= D.Code ");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Code_Category"].Visible = false;
            dataGridView1.Columns["Code_Unit"].Visible = false;
            dataGridView1.Columns["Code_Division"].Visible = false;
            dataGridView1.ClearSelection();
           

            dt = cdata.GetTable("select * from item_category");
            cbo_category.DataSource = dt;
            cbo_category.DisplayMember = "Category";
            cbo_category.ValueMember = "Code";

            dt = cdata.GetTable("select * from item_unit");
            cbo_unit.DataSource = dt;
            cbo_unit.DisplayMember = "Unit";
            cbo_unit.ValueMember = "Code";

            dt = cdata.GetTable("select * from item_division");
            cbo_division.DataSource = dt;
            cbo_division.DisplayMember = "Division";
            cbo_division.ValueMember = "Code";

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
                    Boolean result = cdata.ExecuteQry("insert into menu_item (Name,PrintName,Category,Unit,Division,Price) values('" + txt_name.Text + "','" + txt_printName.Text + "'," + cbo_category.SelectedValue + "," + cbo_unit.SelectedValue + "," + cbo_division.SelectedValue + ",'" + txt_price.Text + "')");
                    if (result == true)
                        MessageBox.Show("Item Added sucessfully");
                    else
                        MessageBox.Show("Item Not Inserted");
                }
                else
                {
                    Boolean result = cdata.ExecuteQry("update  menu_item set Name='" + txt_name.Text + "',PrintName='" + txt_printName.Text + "',Category=" + cbo_category.SelectedValue + ",Unit=" + cbo_unit.SelectedValue + ",Division=" + cbo_division.SelectedValue + ",Price=" + txt_price.Text + " where Code=" + txt_code.Text + " ");
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
                cbo_category.SelectedValue = Convert.ToInt16(selectedRow.Cells["Code_Category"].Value);
                cbo_category.Text =selectedRow.Cells["Category"].Value.ToString();
                cbo_unit.SelectedValue = Convert.ToInt16(selectedRow.Cells["Code_Unit"].Value);
                cbo_unit.Text = selectedRow.Cells["Unit"].Value.ToString();
                cbo_division.SelectedValue = Convert.ToInt16(selectedRow.Cells["Code_Division"].Value);
                cbo_division.Text = selectedRow.Cells["Division"].Value.ToString();
                txt_price.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
            }
            GridSelect = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }


    }
}
