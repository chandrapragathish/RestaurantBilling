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
    public partial class kot : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        ClsReports RepData = new ClsReports();
        public kot()
        {
            InitializeComponent();
            cate_button_load();
        }



        /// ///////////Message warning/////////
        private void DisplayWarning(String message, int Interval = 3000)
        {
            try
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
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void kot_Load(object sender, EventArgs e)
        {
            try
            {
                txt_tabletype.ReadOnly = true;
                ///////////////////----Table------////////////////////
                DataTable dt = cdata.GetTable("select Code,convert(concat('Table-',TableNo),char(10)) TableNo from table_master where status='Service Available' order by TableNo asc");
                cbo_table.DataSource = dt;
                cbo_table.DisplayMember = "TableNo";
                cbo_table.ValueMember = "Code";
                cbo_table.Text = "Select";
                ///////////////////----Kot No------////////////////////
                txt_kotNo.ReadOnly = true;
                txt_kotNo.Text = cdata.GetSingleValue("SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'restaurant_billing' AND TABLE_NAME = 'kot'");

                ///////////////////----Waiter------////////////////////
                dt = cdata.GetTable("select Code,Name from waiter where  available=1 order by Code asc");
                cbo_waitecode.DataSource = dt;
                cbo_waitecode.DisplayMember = "Code";
                cbo_waitecode.ValueMember = "Code";
                cbo_waitecode.Text = "Select";

                ///////////////////----Grid view ------////////////////////
                dgv_kot.AllowUserToResizeRows = false;
                dgv_item.AllowUserToResizeColumns = false;
                dgv_item.AllowUserToResizeRows = false;
                dgv_process.AllowUserToResizeColumns = false;
                dgv_process.AllowUserToResizeRows = false;


                ///////////////////----Processing------////////////////////
             
                dgv_process.EnableHeadersVisualStyles = false;
                dgv_process.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");
                dgv_process.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_process.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgv_process.DefaultCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");

                dgv_process.DefaultCellStyle.ForeColor = Color.White;
               

                dgv_process.DataSource = cdata.GetTable("select kot_no kot,table_name 'Table' from kot");
                dgv_process.ClearSelection();
                dgv_process.Columns[0].Width = 50;
                dgv_process.Columns[1].Width = 90;
                dgv_process.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv_process.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgv_process.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                ///----Change color if all check box tick
                foreach (DataGridViewRow dr in dgv_process.Rows)
                {

                    if (cdata.GetSingleValue("select kot_no from kot_item where kot_no=" + dr.Cells[0].Value.ToString() + " and Status=0") == "")
                        dr.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("64, 128, 0");
                    else
                        dr.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");
                }
           
                ///////////////////----Available------////////////////////
                lst_available.DataSource = cdata.GetTable("select convert(concat('Table-',TableNo),char(10)) 'Table' from table_master where TableNo not in (select SUBSTRING(table_name, 7, 1) 'Table' from kot) and status='Service Available'");
                lst_available.DisplayMember = "Table";
                lst_available.ClearSelected();
            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }

        }
        private void txt_nop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }



        private void cbo_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_table.Text != "Select")
            {
                txt_tabletype.Text = cdata.GetSingleValue("select Location from table_master where Code=" + cbo_table.SelectedValue + " and status='Service Available'");
            }
        }
        private void cbo_waitecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_waitecode.Text != "Select")
            {
                txt_waitername.Text = cdata.GetSingleValue("select Name from waiter where Code=" + cbo_waitecode.SelectedValue + " and available=1");
                lst_waiter.Visible = false;
            }
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void cbo_table_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }


        /// ////////////--Waiter ---------/////////////

        private void cbo_waitecode_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }
        private void lst_waiter_DoubleClick(object sender, EventArgs e)
        {
            WaiterList();
        }

        private void lst_waiter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                WaiterList();
            else if (e.KeyCode == Keys.Escape)
                lst_waiter.Visible = false;
        }
        void WaiterList()
        {
            try
            {
                foreach (var item in lst_waiter.SelectedItems)
                {
                    txt_waitername.Text = ((DataRowView)item)["Name"].ToString();
                    cbo_waitecode.Text = ((DataRowView)item)["Code"].ToString();
                    break;
                }
                this.ActiveControl = txt_item;
                txt_item.Focus();
                lst_waiter.Visible = false;
                lst_itemCode.Visible = false;
                lstbx_Item.Visible = false;
            }
            catch { }
        }
        private void txt_waitername_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();

                dt = cdata.GetTable("select Name,Code  from waiter where Name like '" + txt_waitername.Text + "%' and available=1 order by Name asc");


                lst_waiter.DataSource = dt;
                lst_waiter.DisplayMember = "Name";
                lst_waiter.ValueMember = "Code";
                if (dt.Rows.Count > 0)
                {
                    lst_waiter.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void txt_waitername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (lst_waiter.Items.Count != 0)
                    {
                        foreach (var item in lst_waiter.SelectedItems)
                        {
                            txt_waitername.Text = ((DataRowView)item)["Name"].ToString();
                            cbo_waitecode.Text = ((DataRowView)item)["Code"].ToString();
                            break;
                        }
                        this.ActiveControl = txt_item;
                        txt_item.Focus();
                        lst_waiter.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.ActiveControl = lst_waiter;
                    lst_waiter.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                    lst_waiter.Visible = false;
            }
            catch { }
        }

        private void txt_waitername_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();

                dt = cdata.GetTable("select Name,Code  from waiter where Name like '" + txt_waitername.Text + "%' and available=1 order by Name asc");


                lst_waiter.DataSource = dt;
                lst_waiter.DisplayMember = "Name";
                lst_waiter.ValueMember = "Code";
                if (dt.Rows.Count > 0)
                {
                    lst_waiter.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        ////////Text Item///////////////////////
        private void txt_item_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (lstbx_Item.Items.Count != 0)
                    {
                        foreach (var item in lstbx_Item.SelectedItems)
                        {
                            txt_item.Text = ((DataRowView)item)["Name"].ToString();
                            txt_itemCode.Text = ((DataRowView)item)["Code"].ToString();
                            Enter_grid();
                            break;
                        }
                        this.ActiveControl = txt_qty;
                        txt_qty.Focus();
                        lst_itemCode.Visible = false;
                        lstbx_Item.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.ActiveControl = lstbx_Item;
                    lstbx_Item.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                    lstbx_Item.Visible = false;

            }
            catch { }
        }

        private void txt_item_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt_item = new DataTable();

                dt_item = cdata.GetTable("select Name,Code  from menu_item where Name like '" + txt_item.Text + "%' order by Code");


                lstbx_Item.DataSource = dt_item;
                lstbx_Item.DisplayMember = "Name";
                lstbx_Item.ValueMember = "Code";
                if (dt_item.Rows.Count > 0)
                {
                    lstbx_Item.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }
        private void txt_item_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_item = new DataTable();

                dt_item = cdata.GetTable("select Name,Code  from menu_item where Name like '" + txt_item.Text + "%' order by Code");


                lstbx_Item.DataSource = dt_item;
                lstbx_Item.DisplayMember = "Name";
                lstbx_Item.ValueMember = "Code";
                if (dt_item.Rows.Count > 0)
                {
                    lstbx_Item.Visible = true;
                    lst_itemCode.Visible = false;
                }
            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }


        /// /////////////<List Item ////////////////////

        private void lstbx_Item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListBoxEvent();
            else if (e.KeyCode == Keys.Escape)
                lstbx_Item.Visible = false;
        }
        private void lstbx_Item_DoubleClick(object sender, EventArgs e)
        {
            ListBoxEvent();
        }

        void ListBoxEvent()
        {
            try
            {
                foreach (var item in lstbx_Item.SelectedItems)
                {
                    txt_item.Text = ((DataRowView)item)["Name"].ToString();
                    txt_itemCode.Text = ((DataRowView)item)["Code"].ToString();
                    this.ActiveControl = txt_qty;
                    txt_qty.Focus();
                    break;
                }
                if (txt_qty.Text != "")
                {
                    Enter_grid();
                }
                else
                {
                    this.ActiveControl = txt_qty;
                    txt_qty.Focus();
                }

                lst_itemCode.Visible = false;
                lstbx_Item.Visible = false;
            }
            catch { }
        }

        ////////List Item Code///////////////////////
        private void lst_itemCode_DoubleClick(object sender, EventArgs e)
        {
            ListBoxItemCodeEvent();
        }

        private void lst_itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListBoxItemCodeEvent();
            else if (e.KeyCode == Keys.Escape)
                lst_itemCode.Visible = false;
        }
        void ListBoxItemCodeEvent()
        {
            try
            {
                foreach (var item in lst_itemCode.SelectedItems)
                {
                    txt_item.Text = ((DataRowView)item)["Name"].ToString();
                    txt_itemCode.Text = ((DataRowView)item)["Code"].ToString();
                    this.ActiveControl = txt_qty;
                    txt_qty.Focus();
                    break;
                }
                if (txt_qty.Text != "")
                {
                    Enter_grid();
                }
                else
                {
                    this.ActiveControl = txt_qty;
                    txt_qty.Focus();
                }

                lst_itemCode.Visible = false;
                lstbx_Item.Visible = false;
            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }
        ////////Text Item Code///////////////////////
        private void txt_itemCode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt_item = new DataTable();

                dt_item = cdata.GetTable("select Name,Code  from menu_item where Code like '" + txt_itemCode.Text + "%' order by Code");


                lst_itemCode.DataSource = dt_item;
                lst_itemCode.DisplayMember = "Code";
                lst_itemCode.ValueMember = "Code";
                if (dt_item.Rows.Count > 0)
                {
                    lst_itemCode.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void txt_itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (lst_itemCode.Items.Count != 0)
                    {
                        foreach (var item in lst_itemCode.SelectedItems)
                        {
                            txt_item.Text = ((DataRowView)item)["Name"].ToString();
                            txt_itemCode.Text = ((DataRowView)item)["Code"].ToString();
                            Enter_grid();
                            break;
                        }
                        this.ActiveControl = txt_qty;
                        txt_qty.Focus();
                        lst_itemCode.Visible = false;
                        lstbx_Item.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.ActiveControl = lst_itemCode;
                    lst_itemCode.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                    lst_itemCode.Visible = false;
            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }
        private void txt_itemCode_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_item = new DataTable();

                dt_item = cdata.GetTable("select Name,Code  from menu_item where Code like '" + txt_itemCode.Text + "%' order by Code");


                lst_itemCode.DataSource = dt_item;
                lst_itemCode.DisplayMember = "Code";
                lst_itemCode.ValueMember = "Code";
                if (dt_item.Rows.Count > 0)
                {
                    lst_itemCode.Visible = true;
                    lstbx_Item.Visible = false;
                }
            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }
        private void txt_itemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void clearItemtxt()
        {
            txt_item.Text = "";
            txt_itemCode.Text = "";
            txt_qty.Text = "";
            lst_itemCode.Visible = false;
            lstbx_Item.Visible = false;
        }

        /// /////////////--Qty-- ////////////////////
        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_grid();

            }
        }
        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        ///////////////////Enter Event For data grid view///////////////
        void Enter_grid()
        {
            try
            {
                if (txt_qty.Text != "" && txt_itemCode.Text != "")
                {
                    Boolean flag = true;
                    for (int i = 0; i < dgv_kot.Rows.Count; i++)
                    {
                        if (txt_itemCode.Text == dgv_kot.Rows[i].Cells["_Code"].Value.ToString())
                        {
                            dgv_kot.Rows[i].Cells["_Qty"].Value = txt_qty.Text;
                            dgv_kot.Rows[i].Cells["_Amount"].Value = Convert.ToDecimal(txt_qty.Text) * Convert.ToDecimal(dgv_kot.Rows[i].Cells["_Price"].Value);
                            flag = false;
                            dgv_kot.Rows[i].Selected = true;
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("'" + txt_item.Text + "' Updated Sucessfully!");
                        }
                    }
                    if (flag)
                    {
                        DataTable dt = new DataTable();
                        dt = cdata.GetTable("select M.Code Code,Name,U.Unit Unit,Price from menu_item M inner join item_unit U on M.Unit= U.Code where M.Code=" + txt_itemCode.Text + "");
                        dgv_kot.Rows.Add(false,dt.Rows[0][0], dt.Rows[0][1], txt_qty.Text, dt.Rows[0][2], dt.Rows[0][3], (Convert.ToDecimal(dt.Rows[0][3]) * Convert.ToInt16(txt_qty.Text)));
                        dgv_kot.Rows[dgv_kot.Rows.Count - 1].Selected = true;
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("'" + dt.Rows[0][1] + "' Added Sucessfully!");
                    }
                    // dgv_kot.ClearSelection();
                    //-------Total Count----------
                    btn_qty.Text = dgv_kot.Rows.Count.ToString() + ".0";
                    //------clear Item-------
                    clearItemtxt();
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
                clearItemtxt();
            }
        }

        private void dgv_kot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Grd_ItemUpdate();
            }

        }
        private void dgv_kot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_kot.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_kot.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_kot.Rows[selectedrowindex];

                if (Convert.ToBoolean(selectedRow.Cells[0].Value) == true)
                    selectedRow.Cells[0].Value = false;
                else
                    selectedRow.Cells[0].Value = true;
            }
        }
        private void dgv_kot_DoubleClick(object sender, EventArgs e)
        {
            Grd_ItemUpdate();
        }
       
        private void Grd_ItemUpdate()
        {
            if (dgv_kot.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_kot.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_kot.Rows[selectedrowindex];
                txt_itemCode.Text = Convert.ToString(selectedRow.Cells["_Code"].Value);
                txt_item.Text = Convert.ToString(selectedRow.Cells["_Name"].Value);
                txt_qty.Text = Convert.ToString(selectedRow.Cells["_Qty"].Value);
                lst_itemCode.Visible = false;
                lstbx_Item.Visible = false;
                txt_qty.Focus();
            }
        }

        /// <summary>
        /// ////////////////////// ---SAVE--- ///////////////////
        /// </summary>

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_table.Text != "Select" && cbo_waitecode.Text != "Select" && dgv_kot.Rows.Count > 0)

                    if (cdata.GetSingleValue("select kot_no from kot where kot_no=" + txt_kotNo.Text + "") == "")
                    {
                        Boolean result1 = false;
                        Boolean result = cdata.ExecuteQry("insert into kot(table_name,table_type,Nop,waiterCode,waiterName,Remark,DateTime)" +
                             " values('" + cbo_table.Text + "','" + txt_tabletype.Text + "'," + (txt_nop.Text == "" ? "null" : txt_nop.Text) + "," + cbo_waitecode.Text + ",'" + txt_waitername.Text + "','" + txt_remark.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");

                        for (int i = 0; i < dgv_kot.Rows.Count; i++)
                        {
                              string Status = (dgv_kot.Rows[i].Cells[0].Value).ToString() == "False" ? "0" : "1";
                              result1 = cdata.ExecuteQry("insert into kot_item(kot_no,item_code,item_name,qty,unit,price,Amount,Status)" +
                                  " values(" + txt_kotNo.Text + "," + dgv_kot.Rows[i].Cells["_Code"].Value + ",'" + dgv_kot.Rows[i].Cells["_Name"].Value + "'," + dgv_kot.Rows[i].Cells["_Qty"].Value + ",'" + dgv_kot.Rows[i].Cells["_Unit"].Value + "'," + dgv_kot.Rows[i].Cells["_Price"].Value + "," + dgv_kot.Rows[i].Cells["_Amount"].Value + ","+Status+")");
                          
                      
                        }
                        if (result1 && result)
                        {
                            Refresh();
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Kot Added Sucessfully!");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("kot Not Added!");
                        }
                    }
                    else
                    {
                        cdata.ExecuteQry("delete from kot_item where kot_no=" + txt_kotNo.Text + "");
                        Boolean result1 = false;
                        Boolean result = cdata.ExecuteQry("update kot set" +
                            " table_name='" + cbo_table.Text + "',table_type='" + txt_tabletype.Text + "',Nop=" + (txt_nop.Text == "" ? "null" : txt_nop.Text) + ",waiterCode=" + cbo_waitecode.Text + ",waiterName='" + txt_waitername.Text + "',Remark='" + txt_remark.Text + "',DateTime='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where kot_no=" + txt_kotNo.Text + "");

                        for (int i = 0; i < dgv_kot.Rows.Count; i++)
                        {
                            string Status = (dgv_kot.Rows[i].Cells[0].Value).ToString() == "False" ? "0" : "1";
                            result1 = cdata.ExecuteQry("insert into kot_item(kot_no,item_code,item_name,qty,unit,price,Amount,Status)" +
                                " values(" + txt_kotNo.Text + "," + dgv_kot.Rows[i].Cells["_Code"].Value + ",'" + dgv_kot.Rows[i].Cells["_Name"].Value + "'," + dgv_kot.Rows[i].Cells["_Qty"].Value + ",'" + dgv_kot.Rows[i].Cells["_Unit"].Value + "'," + dgv_kot.Rows[i].Cells["_Price"].Value + "," + dgv_kot.Rows[i].Cells["_Amount"].Value + "," + Status + ")");


                        }
                        if (result1 && result)
                        {
                            Refresh();
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Kot Updated Sucessfully!");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("kot Not Updated!");
                        }

                    }
                else
                {
                    if (cbo_table.Text == "Select")
                        lbl_table.ForeColor = Color.Red;
                    else
                        lbl_table.ForeColor = Color.Aqua;
                    if (cbo_waitecode.Text == "Select")
                        lbl_waiter.ForeColor = Color.Red;
                    else
                        lbl_waiter.ForeColor = Color.Aqua;


                    lbl_msg.ForeColor = Color.Red;
                    DisplayWarning("Plese fill all details!");
                }

            }
            catch { }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_kot.SelectedRows.Count > 0)
                {
                    int selectedrowindex = dgv_kot.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_kot.Rows[selectedrowindex];
                    DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete '" + Convert.ToString(selectedRow.Cells["_Name"].Value) + "'", "Delete '" + Convert.ToString(selectedRow.Cells["_Name"].Value) + "'", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cdata.GetSingleValue("select kot_no from kot where kot_no=" + txt_kotNo.Text + "") == "")
                            dgv_kot.Rows.RemoveAt(this.dgv_kot.SelectedRows[0].Index);
                        else
                        {
                            Boolean result = false;
                            result = cdata.ExecuteQry("delete from kot_item where item_code=" + dgv_kot.SelectedRows[0].Cells["_Code"].Value + "");
                            dgv_kot.Rows.RemoveAt(this.dgv_kot.SelectedRows[0].Index);
                        }
                        
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("Deleted Sucessfully!");
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            clearItemtxt();
            btn_qty.Text = "0.0";
            cbo_table.Text = "";
            txt_tabletype.Text = "";
            txt_kotNo.Text = cdata.GetSingleValue("select coalesce(MAX(kot_no)+1,1) Code from kot");
            txt_nop.Text = "";
            txt_waitername.Text = "";
            cbo_waitecode.Text = "";
            lst_waiter.Visible = false;
            lstbx_Item.Visible = false;
            lstbx_Item.Visible = false;
            dgv_kot.Rows.Clear();
            dgv_kot.Refresh();
            dgv_item.DataSource = new DataTable();
            txt_remark.Text = "";
            cbo_table.Text = "Select";
            cbo_waitecode.Text = "Select";

            ////////////////---Change color Red to 
            lbl_table.ForeColor = Color.Aqua;
            lbl_waiter.ForeColor = Color.Aqua;

            ///////////////////----Processing------////////////////////
            dgv_process.DataSource = cdata.GetTable("select kot_no kot,table_name 'Table' from kot");
            dgv_process.ClearSelection();
            dgv_process.Columns[0].Width = 50;
            dgv_process.Columns[1].Width = 90;
            dgv_process.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_process.DefaultCellStyle.ForeColor = Color.White;
            ///----Change color if all check box tick
            foreach (DataGridViewRow dr in dgv_process.Rows)
            {

                if (cdata.GetSingleValue("select kot_no from kot_item where kot_no=" + dr.Cells[0].Value.ToString() + " and Status=0") == "")
                    dr.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("64, 128, 0");
                else
                    dr.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");
            }
           

            ///////////////////----Available------////////////////////
            lst_available.DataSource = cdata.GetTable("select convert(concat('Table-',TableNo),char(10)) 'Table' from table_master where TableNo not in (select SUBSTRING(table_name, 7, 1) 'Table' from kot) and status='Service Available'");
            lst_available.DisplayMember = "Table";
            lst_available.ClearSelected();

            //////-----Enable False from Kot-----///////
            //cbo_table.Enabled = true;
            //cbo_waitecode.Enabled = true;
            //txt_waitername.ReadOnly = false;
            //txt_item.Enabled = true;
            //txt_itemCode.Enabled = true;
            //txt_qty.ReadOnly = false;
            //dgv_item.Enabled = true;
            //btn_remove.Visible = true;

            //////////////////////----from Kot------////////////
            btn_remove.Visible = true;
            Globalvar.kot = 0;
        }

        private void btn_kotProcess_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.ProcessKot menuItem = new Restaurant_Billing.Master.ProcessKot();
            menuItem.Show();
            this.Hide();
        }


        /// <summary>
        /// //////////  ---Category Button Load///////////////
        /// </summary>
        private void cate_button_load()
        {

            DataTable dt_cate = cdata.GetTable("select code,category from item_category ");

            int btnName = 0;

            if (dt_cate.Rows.Count > 0)
            {
                btnName++;

                int PosX = -2;
                int PosY = 5;

                int rowCount = -1;
                int numOfRows = dt_cate.Rows.Count;
                for (int i = 0; i < numOfRows; i++)
                {
                    if (i > 4 && i < 9)
                    {

                        if (i == 5)
                        {
                            PosX = 120;
                            PosY = 5;
                        }
                        else if (i < 9)
                        {
                            PosX = 120;
                            PosY = PosY;
                        }
                    }

                    //if (i > 9 && i < 14)
                    //{

                    //    if (i == 9)
                    //    {
                    //        PosX = 240;
                    //        PosY = 5;
                    //    }
                    //    else if( i > 9 && i < 14 )
                    //    {
                    //        PosX = 240;
                    //        PosY = PosY;
                    //    }
                    //}


                    rowCount++;

                    Button button = new Button();
                    button.Enabled = true;

                    button.BackColor = System.Drawing.ColorTranslator.FromHtml("0, 192, 192");
                    button.ForeColor = Color.Black;
                    button.Width = 122;
                    button.Height = 40;

                    button.Location = new Point(PosX, PosY);
                    button.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);

                    button.Click += new EventHandler(b_Click);

                    pnl_category.Controls.Add(button);
                    PosY += 38;
                    button.Text = dt_cate.Rows[rowCount].Field<string>(1);
                    button.Name = button.Text;




                }
            }



        }

        void b_Click(object sender, EventArgs e)
        {

            ItemShow(((System.Windows.Forms.Button)sender).Name);
        }

        private void ItemShow(string category)
        {
            DataTable dt = cdata.GetTable("select M.Code Code,Name,U.Unit Unit,Price from menu_item M inner join item_category C on M.Category= C.Code inner join item_unit U on M.Unit= U.Code where C.Category='" + category + "'");
            dgv_item.DataSource = dt;
            dgv_item.Columns[0].Width = 70;
            dgv_item.Columns[1].Width = 220;
            dgv_item.Columns[2].Width = 110;
            dgv_item.Columns[3].Width = 120;
            dgv_item.ClearSelection();
        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_item.Rows[rowIndex];
                Boolean flag = true;
                for (int i = 0; i < dgv_kot.Rows.Count; i++)
                {
                    if (row.Cells["Code"].Value.ToString() == dgv_kot.Rows[i].Cells["_Code"].Value.ToString())
                    {
                        dgv_kot.Rows[i].Cells["_Qty"].Value = Convert.ToInt16(dgv_kot.Rows[i].Cells["_Qty"].Value) + 1;
                        dgv_kot.Rows[i].Cells["_Amount"].Value = Convert.ToInt16(dgv_kot.Rows[i].Cells["_Qty"].Value) * Convert.ToDecimal(dgv_kot.Rows[i].Cells["_Price"].Value);
                        flag = false;
                        dgv_kot.Rows[i].Selected = true;
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("'" + dgv_kot.Rows[i].Cells["_Name"].Value + "' Updated Sucessfully!");
                    }
                }
                if (flag)
                {
                    DataTable dt = new DataTable();
                    dt = cdata.GetTable("select M.Code Code,Name,U.Unit Unit,Price from menu_item M inner join item_unit U on M.Unit= U.Code where M.Code=" + txt_itemCode.Text + "");
                    dgv_kot.Rows.Add(false,row.Cells["Code"].Value, row.Cells["Name"].Value, 1, row.Cells["Unit"].Value, row.Cells["Price"].Value, (Convert.ToDecimal(row.Cells["Price"].Value)));
                    dgv_kot.Rows[dgv_kot.Rows.Count - 1].Selected = true;
                    lbl_msg.ForeColor = Color.Lime;
                    DisplayWarning("'" + row.Cells["Name"].Value + "' Added Sucessfully!");
                }
                // dgv_kot.ClearSelection();
                //-------Total Count----------
                btn_qty.Text = dgv_kot.Rows.Count.ToString() + ".0";
                //------clear Item-------
                clearItemtxt();

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            Billing Main = new Billing();
            Main.Show();
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure want to Print kot", "KOT Bill", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PrintFunction();
            }
        }
        public void PrintFunction()
        {
            try
            {
                string PrntName = cdata.GetSingleValue("select PrinterName from printer where Enable=1");
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(RepData.FormatString("THE MADRAS RESTRO & CAFE", 33, 0));
                sb.AppendLine();

                sb.Append(RepData.FormatString("KOT:" + txt_kotNo.Text + "", 13, 1));
                sb.AppendLine(RepData.FormatString("" + DateTime.Now.ToString("dd-MM-yyyy hh:mm tt") + "", 20, 2));
                sb.AppendLine(RepData.FormatString("Table:" + cbo_table.Text.Substring(6, 1) + "", 20, 1));
                sb.Append(RepData.FormatString("S.No Items Ordered           Qty", 33, 0));
                sb.AppendLine();
                sb.AppendLine(RepData.Repeat("-", 33));
                int i = 1;
                Int32 total = 0;
                foreach (DataGridViewRow dr in dgv_kot.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells[0].Value) == false)
                    {
                        sb.Append(RepData.FormatString(i++.ToString(), 4, 1));
                        sb.Append(RepData.Space(1));
                        sb.Append(RepData.FormatString((dr.Cells["_Name"].Value.ToString()).Trim(), 21, 1));
                        sb.Append(RepData.FormatString((dr.Cells["_Qty"].Value.ToString()).Trim(), 6, 2));
                        sb.AppendLine();
                        total += Convert.ToInt32(dr.Cells["_Qty"].Value);
                    }
                }
                sb.AppendLine(RepData.Repeat("-", 33));

                ////--Total---/////
                sb.Append(RepData.FormatString("", 5, 1));
                sb.Append(RepData.FormatString("Total", 6, 1));
                sb.Append(RepData.FormatString(total.ToString(), 21, 2));
                sb.AppendLine();

                RepData.PrintFile(sb, PrntName);

            }
            catch (Exception ex)
            { }



        }

        private void lst_available_Click(object sender, EventArgs e)
        {
            foreach (var item in lst_available.SelectedItems)
            {
                cbo_table.Text = ((DataRowView)item)["Table"].ToString();
                txt_tabletype.Text = cdata.GetSingleValue("select Location from table_master where Code=" + cbo_table.SelectedValue + " and status='Service Available'");
            }
        }

        private void dgv_process_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ///////////////////----Items------////////////////////
                clearItemtxt();

                dgv_kot.Rows.Clear();
                dgv_kot.Refresh();

                dgv_item.DataSource = new DataTable();


                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_process.Rows[rowIndex];
                Globalvar.kot = Convert.ToInt64(dgv_process.SelectedRows[0].Cells["Kot"].Value);
                loadKOT();

            }
            catch
            {

            }
        }
        private void loadKOT()
        {
            try
            {

                DataTable dt = cdata.GetTable("select kot_no,table_name,table_type,Nop,waiterCode,waiterName from kot where kot_no=" + Globalvar.kot + "");
                txt_kotNo.Text = dt.Rows[0]["kot_no"].ToString();
                cbo_table.Text = dt.Rows[0]["table_name"].ToString();
                txt_tabletype.Text = dt.Rows[0]["table_type"].ToString();
                txt_nop.Text = dt.Rows[0]["Nop"].ToString();
                cbo_waitecode.Text = dt.Rows[0]["waiterCode"].ToString();
                txt_waitername.Text = dt.Rows[0]["waiterName"].ToString();
                dt = cdata.GetTable("select Status,item_code,item_name,qty,unit,price,Amount from kot_item  where kot_no=" + Globalvar.kot + "");
                foreach (DataRow dr in dt.Rows)
                    dgv_kot.Rows.Add(dr["Status"].ToString()=="0"?false:true, dr["item_code"], dr["item_name"], dr["qty"], dr["unit"], dr["price"], dr["Amount"]);
                lst_waiter.Visible = false;
              
                //////-----Enable False -----///////
                //cbo_table.Enabled = false;
                //cbo_waitecode.Enabled = false;
                //txt_waitername.ReadOnly = true;
                //txt_item.Enabled = false;
                //txt_itemCode.Enabled = false;
                //txt_qty.ReadOnly = true;
                //dgv_item.Enabled = false;
                //btn_remove.Visible = false;




            }
            catch { }

        }
       



    }

}

