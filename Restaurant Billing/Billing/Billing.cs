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
    public partial class Billing : Form
    {
        ClsDataAccess cdata = new ClsDataAccess();
        ClsReports RepData = new ClsReports();
        public Billing()
        {
            InitializeComponent();
            cate_button_load();
        }

        DataTable dt_tax = new DataTable();

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
        ///////////////////----Date------////////////////////
        async void TimeUpdater()
        {
            while (true)
            {
                lbl_dte.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
                await Task.Delay(1000);
            }
        }
        private void Billing_Load(object sender, EventArgs e)
        {

            try
            {
                ///////////////////----Bill No------////////////////////
                txt_billNo.ReadOnly = true;
                txt_billNo.Text = cdata.GetSingleValue("SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'restaurant_billing' AND TABLE_NAME = 'billing'");

                ///////////////////----Date Time------////////////////////
                TimeUpdater();
                /////////////------Type-----------//////////////////////////
                cbo_billType.Text = "Dine In";

                ///////////////////----Table------////////////////////
                txt_tabletype.ReadOnly = true;
                DataTable dt = cdata.GetTable("select Code,convert(concat('Table-',TableNo),char(10)) TableNo from table_master where status='Service Available' order by TableNo asc");
                cbo_table.DataSource = dt;
                cbo_table.DisplayMember = "TableNo";
                cbo_table.ValueMember = "Code";
                cbo_table.Text = "Select";


                ///////////////////----Waiter------////////////////////
                dt = cdata.GetTable("select Code,Name from waiter where  available=1 order by Code asc");
                cbo_waitecode.DataSource = dt;
                cbo_waitecode.DisplayMember = "Code";
                cbo_waitecode.ValueMember = "Code";
                cbo_waitecode.Text = "Select";

                ///////////////////----Grid view ------////////////////////
                dgv_billing.AllowUserToResizeRows = false;
                dgv_item.AllowUserToResizeColumns = false;
                dgv_item.AllowUserToResizeRows = false;
                dgv_process.AllowUserToResizeColumns = false;
                dgv_process.AllowUserToResizeRows = false;

                /////////////////------Tax-------///////////////////
                dt_tax = cdata.GetTable("select SGST,CGST,S_Charge from tax");

                ///////////////////----Down------////////////////////
                txt_qtys.ReadOnly = true;
                txt_subTotal.ReadOnly = true;
                txt_SGST.ReadOnly = true;
                txt_CGST.ReadOnly = true;
                txt_servChrg.ReadOnly = true;
                txt_bal.ReadOnly = true;


                ///////////////////----Processing------////////////////////
                dgv_process.EnableHeadersVisualStyles = false;
                dgv_process.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");
                dgv_process.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_process.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgv_process.DefaultCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");

                dgv_process.DefaultCellStyle.ForeColor = Color.White;
                dgv_process.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("39, 44, 51");

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
                if (Globalvar.kot != 0)
                    loadKOT();

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }


        }
        private void loadKOT()
        {
            try
            {
                DataTable dt = cdata.GetTable("select table_name,table_type,Nop,waiterCode,waiterName from kot where kot_no=" + Globalvar.kot + "");

                ///////////////////----Dine In------////////////////////
                if (cbo_billType.Text != "Dine In")
                {
                    cbo_table.Text = "";
                    txt_tabletype.Text = "";
                    cbo_waitecode.Text = "";
                    txt_waitername.Text = "";
                }
                else
                {
                    cbo_table.Text = dt.Rows[0]["table_name"].ToString();
                    txt_tabletype.Text = dt.Rows[0]["table_type"].ToString();
                    cbo_waitecode.Text = dt.Rows[0]["waiterCode"].ToString();
                    txt_waitername.Text = dt.Rows[0]["waiterName"].ToString();
                }

                txt_nop.Text = dt.Rows[0]["Nop"].ToString();

                dt = cdata.GetTable("select item_code,item_name,qty,unit,price,Amount from kot_item  where kot_no=" + Globalvar.kot + "");
                foreach (DataRow dr in dt.Rows)
                    dgv_billing.Rows.Add(dr["item_code"], dr["item_name"], dr["qty"], dr["unit"], dr["price"], dr["Amount"]);
                Calculations();
                lst_waiter.Visible = false;
                lst_guest.Visible = false;
                lst_mbl.Visible = false;

                //////-----Enable False -----///////
                cbo_table.Enabled = false;
                cbo_waitecode.Enabled = false;
                txt_waitername.Enabled = false;
                txt_item.Enabled = false;
                txt_itemCode.Enabled = false;
                txt_qty.ReadOnly = true;
                dgv_item.Enabled = false;
                btn_remove.Visible = false;




            }
            catch { }

        }

        //////////Bill Type Event
        private void cbo_billType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_billType.Text != "Dine In")
            {
                cbo_table.Text = "";
                txt_tabletype.Text = "";
                cbo_waitecode.Text = "";
                txt_waitername.Text = "";
                cbo_table.Enabled = false;
                cbo_waitecode.Enabled = false;
                txt_waitername.Enabled = false;
                lst_waiter.Visible = false;
            }
            else if(Globalvar.kot==0)
            {
                cbo_table.Enabled = true;
                cbo_waitecode.Enabled = true;
                txt_waitername.Enabled = true;
                lst_waiter.Visible = false;
                cbo_table.Text = "Select";
                cbo_waitecode.Text = "Select";
            }
            else
            {
                cbo_table.Enabled = false;
                cbo_waitecode.Enabled = false;
                txt_waitername.Enabled = false;
               
                DataTable dt = cdata.GetTable("select table_name,table_type,Nop,waiterCode,waiterName from kot where kot_no=" + Globalvar.kot + "");
                cbo_table.Text = dt.Rows[0]["table_name"].ToString();
                txt_tabletype.Text = dt.Rows[0]["table_type"].ToString();
                cbo_waitecode.Text = dt.Rows[0]["waiterCode"].ToString();
                txt_waitername.Text = dt.Rows[0]["waiterName"].ToString();
                lst_waiter.Visible = false;
            }



        }

        ///////NOP key press
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
        #region Cbo Readonly
        private void cbo_billType_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }
        private void cbo_table_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }

        private void cbo_waitecode_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }
        private void cbo_payMode_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbo_dis_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        #endregion


        private void btn_home_Click(object sender, EventArgs e)
        {
            Globalvar.kot = 0;
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }


        ///////////////////------Waiter-------//////////////
        #region Waiter

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
                this.ActiveControl = txt_guest;
                txt_guest.Focus();
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
                    lst_itemCode.Visible = false;
                    lstbx_Item.Visible = false;
                    lst_guest.Visible = false;
                    lst_mbl.Visible = false;
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
                        this.ActiveControl = txt_guest;
                        txt_guest.Focus();
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
        #endregion


        ////////////---------Guest  ----------//////////////////////
        #region Guest and Mobile
        private void txt_guest_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = cdata.GetTable("select Name,Phone  from guest where Name like '" + txt_guest.Text + "%' order by Name asc");


                lst_guest.DataSource = dt;
                lst_guest.DisplayMember = "Name";
                lst_guest.ValueMember = "Phone";
                if (dt.Rows.Count > 0)
                {
                    lst_guest.Visible = true;
                    lst_itemCode.Visible = false;
                    lstbx_Item.Visible = false;
                    lst_waiter.Visible = false;
                    lst_mbl.Visible = false;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void txt_guest_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (lst_guest.Items.Count != 0)
                    {
                        foreach (var item in lst_guest.SelectedItems)
                        {
                            txt_guest.Text = ((DataRowView)item)["Name"].ToString();
                            txt_mobile.Text = ((DataRowView)item)["Phone"].ToString();
                            break;
                        }
                        this.ActiveControl = txt_qty;
                        txt_item.Focus();
                        lst_guest.Visible = false;
                        lst_mbl.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.ActiveControl = lst_guest;
                    lst_guest.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                    lst_guest.Visible = false;
            }
            catch { }
        }

        private void txt_guest_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = cdata.GetTable("select Name,Phone  from guest where Name like '" + txt_guest.Text + "%' order by Name asc");


                lst_guest.DataSource = dt;
                lst_guest.DisplayMember = "Name";
                lst_guest.ValueMember = "Phone";
                if (dt.Rows.Count > 0)
                {
                    lst_guest.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void lst_guest_DoubleClick(object sender, EventArgs e)
        {
            lst_guest_Event();
        }

        private void lst_guest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lst_guest_Event();
            else if (e.KeyCode == Keys.Escape)
                lst_guest.Visible = false;
        }
        void lst_guest_Event()
        {
            try
            {
                foreach (var item in lst_guest.SelectedItems)
                {
                    txt_guest.Text = ((DataRowView)item)["Name"].ToString();
                    txt_mobile.Text = ((DataRowView)item)["Phone"].ToString();
                    this.ActiveControl = txt_qty;
                    txt_item.Focus();
                    break;
                }
                lst_guest.Visible = false;
                lst_mbl.Visible = false;
            }
            catch { }
        }

        ////////////--------- Phone ----------//////////////////////


        private void txt_mobile_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = cdata.GetTable("select Name,Phone  from guest where Phone like '" + txt_mobile.Text + "%' order by Name asc");


                lst_mbl.DataSource = dt;
                lst_mbl.DisplayMember = "Phone";
                lst_mbl.ValueMember = "Phone";
                if (dt.Rows.Count > 0)
                {
                    lst_mbl.Visible = true;
                    lst_itemCode.Visible = false;
                    lstbx_Item.Visible = false;
                    lst_waiter.Visible = false;
                    lst_guest.Visible = false;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {

            try
            {

                DataTable dt = cdata.GetTable("select Name,Phone  from guest where Phone like '" + txt_mobile.Text + "%' order by Name asc");


                lst_mbl.DataSource = dt;
                lst_mbl.DisplayMember = "Phone";
                lst_mbl.ValueMember = "Phone";
                if (dt.Rows.Count > 0)
                {
                    lst_mbl.Visible = true;
                }

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        private void txt_mobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (lst_mbl.Items.Count != 0)
                    {
                        foreach (var item in lst_mbl.SelectedItems)
                        {
                            txt_guest.Text = ((DataRowView)item)["Name"].ToString();
                            txt_mobile.Text = ((DataRowView)item)["Phone"].ToString();
                            break;
                        }
                        this.ActiveControl = txt_qty;
                        txt_item.Focus();
                        lst_guest.Visible = false;
                        lst_mbl.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    this.ActiveControl = lst_mbl;
                    lst_mbl.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                    lst_mbl.Visible = false;
            }
            catch { }
        }
        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }


        private void lst_mbl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lst_mbl_Event();
            else if (e.KeyCode == Keys.Escape)
                lst_mbl.Visible = false;
        }

        private void lst_mbl_DoubleClick(object sender, EventArgs e)
        {
            lst_mbl_Event();
        }

        void lst_mbl_Event()
        {
            try
            {
                foreach (var item in lst_mbl.SelectedItems)
                {
                    txt_guest.Text = ((DataRowView)item)["Name"].ToString();
                    txt_mobile.Text = ((DataRowView)item)["Phone"].ToString();
                    this.ActiveControl = txt_qty;
                    txt_item.Focus();
                    break;
                }
                lst_guest.Visible = false;
                lst_mbl.Visible = false;
            }
            catch { }
        }
        #endregion

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
                    lst_waiter.Visible = false;
                    lst_guest.Visible = false;
                    lst_mbl.Visible = false;
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
                    lst_waiter.Visible = false;
                    lst_guest.Visible = false;
                    lst_mbl.Visible = false;

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
                    for (int i = 0; i < dgv_billing.Rows.Count; i++)
                    {
                        if (txt_itemCode.Text == dgv_billing.Rows[i].Cells["_Code"].Value.ToString())
                        {
                            dgv_billing.Rows[i].Cells["_Qty"].Value = txt_qty.Text;
                            dgv_billing.Rows[i].Cells["_Amount"].Value = Convert.ToDecimal(txt_qty.Text) * Convert.ToDecimal(dgv_billing.Rows[i].Cells["_Price"].Value);
                            flag = false;
                            dgv_billing.Rows[i].Selected = true;
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("'" + txt_item.Text + "' Updated Sucessfully!");
                        }
                    }
                    if (flag)
                    {
                        DataTable dt = new DataTable();
                        dt = cdata.GetTable("select M.Code Code,Name,U.Unit Unit,Price from menu_item M inner join item_unit U on M.Unit= U.Code where M.Code=" + txt_itemCode.Text + "");
                        dgv_billing.Rows.Add(dt.Rows[0][0], dt.Rows[0][1], txt_qty.Text, dt.Rows[0][2], dt.Rows[0][3], (Convert.ToDecimal(dt.Rows[0][3]) * Convert.ToInt16(txt_qty.Text)));
                        dgv_billing.Rows[dgv_billing.Rows.Count - 1].Selected = true;
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("'" + dt.Rows[0][1] + "' Added Sucessfully!");
                    }
                    // dgv_kot.ClearSelection();
                    //-------Total Count----------
                    btn_totalAmount.Text = dgv_billing.Rows.Count.ToString() + ".0";
                    //------clear Item-------
                    clearItemtxt();

                    //------Qty------
                    Calculations();
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

        private void dgv_kot_DoubleClick(object sender, EventArgs e)
        {
            Grd_ItemUpdate();
        }
        private void Grd_ItemUpdate()
        {
            if (dgv_billing.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_billing.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_billing.Rows[selectedrowindex];
                txt_itemCode.Text = Convert.ToString(selectedRow.Cells["_Code"].Value);
                txt_item.Text = Convert.ToString(selectedRow.Cells["_Name"].Value);
                txt_qty.Text = Convert.ToString(selectedRow.Cells["_Qty"].Value);
                lst_itemCode.Visible = false;
                lstbx_Item.Visible = false;
                txt_qty.Focus();
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////  Down Side    //////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_billing.SelectedRows.Count > 0)
                {
                    int selectedrowindex = dgv_billing.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_billing.Rows[selectedrowindex];
                    DialogResult dialogResult = MessageBox.Show("Are you Sure want to delete '" + Convert.ToString(selectedRow.Cells["_Name"].Value) + "'", "Delete '" + Convert.ToString(selectedRow.Cells["_Name"].Value) + "'", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dgv_billing.Rows.RemoveAt(this.dgv_billing.SelectedRows[0].Index);
                        Calculations();
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("Deleted Sucessfully!");
                    }
                }
            }
            catch
            {

            }
        }
        /////////---Calculations---///////////
        private void Calculations()
        {
            try
            {


                int qtys = 0;
                decimal subTotal = 0;
                for (int i = 0; i < dgv_billing.Rows.Count; i++)
                {
                    qtys += Convert.ToInt16(dgv_billing.Rows[i].Cells["_Qty"].Value);
                    subTotal += Convert.ToDecimal(dgv_billing.Rows[i].Cells["_Amount"].Value);
                }
                txt_qtys.Text = qtys.ToString();
                txt_subTotal.Text = subTotal.ToString("0.00");
                txt_SGST.Text = ((Convert.ToDecimal(dt_tax.Rows[0][0]) / 100) * subTotal).ToString("0.00");
                txt_CGST.Text = ((Convert.ToDecimal(dt_tax.Rows[0][1]) / 100) * subTotal).ToString("0.00");
                // if Pay Mode not in cash apply charges
                if (cbo_payMode.Text != "Cash")
                    txt_servChrg.Text = ((Convert.ToDecimal(dt_tax.Rows[0][2]) / 100) * subTotal).ToString("0.00");
                else
                {
                    txt_servChrg.Text = "0.00";
                }

                //Total Amount=SubTotal + SGST + CGST + Service Charge + Discount
                if (cbo_dis.Text != "%")
                    btn_totalAmount.Text = (subTotal + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text)).ToString();
                else
                {
                    string Discount = ((Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text) / 100) * subTotal).ToString("0.00");
                    btn_totalAmount.Text = (subTotal + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(Discount)).ToString();

                }
                // If paid text had some amount
                if (txt_paid.Text != "")
                    txt_bal.Text = (Convert.ToDecimal(txt_paid.Text) - Convert.ToDecimal(btn_totalAmount.Text)).ToString();

            }
            catch
            {

            }

        }
        ////////------Discount------//////////
        private void txt_dis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_subTotal.Text != "")
                {
                    //Total Amount=SubTotal + SGST + CGST + Service Charge + Discount
                    if (cbo_dis.Text != "%")
                        btn_totalAmount.Text = (Convert.ToDecimal(txt_subTotal.Text) + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text)).ToString();
                    else
                    {
                        string Discount = ((Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text) / 100) * Convert.ToDecimal(txt_subTotal.Text)).ToString("0.00");
                        btn_totalAmount.Text = (Convert.ToDecimal(txt_subTotal.Text) + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(Discount)).ToString();

                    }
                    // If paid text had some amount
                    if (txt_paid.Text != "")
                        txt_bal.Text = (Convert.ToDecimal(txt_paid.Text) - Convert.ToDecimal(btn_totalAmount.Text)).ToString();
                }

            }
            catch
            {

            }
        }
        private void cbo_dis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_subTotal.Text != "")
                {
                    //Total Amount=SubTotal + SGST + CGST + Service Charge + Discount
                    if (cbo_dis.Text != "%")
                        btn_totalAmount.Text = (Convert.ToDecimal(txt_subTotal.Text) + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text)).ToString();
                    else
                    {
                        string Discount = ((Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text) / 100) * Convert.ToDecimal(txt_subTotal.Text)).ToString("0.00");
                        btn_totalAmount.Text = (Convert.ToDecimal(txt_subTotal.Text) + Convert.ToDecimal(txt_SGST.Text) + Convert.ToDecimal(txt_CGST.Text) + Convert.ToDecimal(txt_servChrg.Text) - Convert.ToDecimal(Discount)).ToString();

                    }
                    // If paid text had some amount
                    if (txt_paid.Text != "")
                        txt_bal.Text = (Convert.ToDecimal(txt_paid.Text) - Convert.ToDecimal(btn_totalAmount.Text)).ToString();
                }
            }
            catch { }
        }
        private void txt_dis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        /////////////--------------PayMode----------------////////////////////////////
        private void cbo_payMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculations();
            if (cbo_payMode.Text != "Cash") {
                colan_Amount.Visible = true;
                lbl_Amount.Visible = true;
                cbo_Amount.Visible = true;

                lbl_paid.Visible = false;
                lbl_bal.Visible = false;
                colan_bal.Visible = false;
                colan_paid.Visible = false;
                txt_paid.Visible = false;
                txt_bal.Visible = false;
                txt_paid.Text="0";
                txt_bal.Text = "0";
            }
            else
            {
                colan_Amount.Visible = false;
                lbl_Amount.Visible = false;
                cbo_Amount.Visible = false;

                lbl_paid.Visible = true;
                lbl_bal.Visible = true;
                colan_bal.Visible = true;
                colan_paid.Visible = true;
                txt_paid.Visible = true;
                txt_bal.Visible = true;
                txt_paid.Text = "";
                txt_bal.Text = "";
            }
        }
        ///////--------Paid --------/////
        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text != "")
                txt_bal.Text = (Convert.ToDecimal(txt_paid.Text) - Convert.ToDecimal(btn_totalAmount.Text)).ToString();
            else
                txt_bal.Text = "";
        }
        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////  Right Side    //////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////  Down Side    //////////////////////////
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_table.Text != "Select" && cbo_waitecode.Text != "Select" && dgv_billing.Rows.Count > 0 && txt_paid.Text != "")
                    if (cdata.GetSingleValue("select billNo from billing where billNo=" + txt_billNo.Text + "") == "")
                    {
                        Boolean result1 = false;
                        Boolean result = cdata.ExecuteQry("insert into billing (Dte,BillType,NOP,TableNo,TableType,WaiterCode,WaiterName,Guest,Mobile,SubTotal,Qtys,DisType,Dis,SGST,CGST,sCharge,Total,PayMode,Paid,Balance,Received)" +
                             " values('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + cbo_billType.Text + "'," + (txt_nop.Text == "" ? "null" : txt_nop.Text) + ",'" + (cbo_table.Text == "" ? "" : cbo_table.Text) + "','" + (txt_tabletype.Text == "" ? "" : txt_tabletype.Text) + "'," + (cbo_waitecode.Text == "" ? "null" : cbo_waitecode.Text) + ",'" + (txt_waitername.Text == "" ? "" : txt_waitername.Text) + "'," +
                             "'" + txt_guest.Text + "'," + (txt_mobile.Text == "" ? "null" : txt_mobile.Text) + "," + txt_subTotal.Text + "," + txt_qtys.Text + ",'" + (cbo_dis.Text == "%" ? "1" : "0") + "'," + (txt_dis.Text == "" ? "0" : txt_dis.Text) + "," + txt_SGST.Text + "," + txt_CGST.Text + "," + txt_servChrg.Text + "," +
                             "'" + btn_totalAmount.Text + "','" + cbo_payMode.Text + "'," + txt_paid.Text + "," + txt_bal.Text + "," + (cbo_Amount.Text == "Received" ? "1" : "0") + ")");

                        for (int i = 0; i < dgv_billing.Rows.Count; i++)
                        {
                            result1 = cdata.ExecuteQry("insert into billing_items(BillNo,Code,Name,Qty,Unit,Price,Amount)" +
                            " values(" + txt_billNo.Text + "," + dgv_billing.Rows[i].Cells["_Code"].Value + ",'" + dgv_billing.Rows[i].Cells["_Name"].Value + "'," + dgv_billing.Rows[i].Cells["_Qty"].Value + ",'" + dgv_billing.Rows[i].Cells["_Unit"].Value + "'," + dgv_billing.Rows[i].Cells["_Price"].Value + "," + dgv_billing.Rows[i].Cells["_Amount"].Value + ")");

                        }
                        if (result1 && result)
                        {
                            if (Globalvar.kot != 0)
                            {
                                Boolean result2 = cdata.ExecuteQry("delete from kot_item where kot_no=" + Globalvar.kot + ""); cdata.ExecuteQry("delete from kot where kot_no=" + Globalvar.kot + "");
                            }
                            DialogResult dialogResult = MessageBox.Show("Are you Sure want to Print bill", "Print Bill", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                PrintFunction();
                            }
                            Refresh();
                            lbl_msg.ForeColor = Color.Lime;
                            DisplayWarning("Bill Added Sucessfully!");
                        }
                        else
                        {
                            lbl_msg.ForeColor = Color.Red;
                            DisplayWarning("Bill Not Added!");
                        }
                    }
                    else
                    {

                        lbl_msg.ForeColor = Color.Red;
                        DisplayWarning("Bill Number" + txt_billNo.Text + " is Already exist!");

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
                    if (txt_paid.Text == "")
                        lbl_paid.ForeColor = Color.Red;
                    else
                        lbl_paid.ForeColor = Color.Aqua;

                    lbl_msg.ForeColor = Color.Red;
                    DisplayWarning("Plese fill up details!");
                }

            }
            catch { }
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            ///////////////////----Bill No------////////////////////
            txt_billNo.Text = cdata.GetSingleValue("SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'restaurant_billing' AND TABLE_NAME = 'billing'");


            /////////////------Type-----------//////////////////////////
            cbo_billType.Text = "Dine In";

            /////////////------NOP-----------//////////////////////////
            txt_nop.Text = "";

            ///////////////////----Table------////////////////////
            cbo_table.Text = "Select";
            txt_tabletype.Text = "";

            ///////////////////----Waiter------////////////////////
            cbo_waitecode.Text = "Select";
            txt_waitername.Text = "";
            lst_waiter.Visible = false;

            ///////////////////----Guest------////////////////////
            txt_guest.Text = "";
            txt_mobile.Text = "";
            lst_guest.Visible = false;
            lst_mbl.Visible = false;

            ///////////////////----Items------////////////////////
            clearItemtxt();

            dgv_billing.Rows.Clear();
            dgv_billing.Refresh();

            dgv_item.DataSource = new DataTable();


            ////////////////////---Down calculation---/////////////////
            txt_qtys.Text = "";
            txt_subTotal.Text = "";
            cbo_dis.Text = "Rs";
            txt_dis.Text = "";
            txt_SGST.Text = "";
            txt_CGST.Text = "";
            txt_servChrg.Text = "";
            cbo_payMode.Text = "Cash";
            txt_paid.Text = "";
            txt_bal.Text = "";
            btn_totalAmount.Text = "0.00";

            ////////////////---Change color Red to 
            lbl_table.ForeColor = Color.Aqua;
            lbl_waiter.ForeColor = Color.Aqua;
            lbl_paid.ForeColor = Color.Aqua;

            ///////////////////----Processing------////////////////////
            dgv_process.DataSource = cdata.GetTable("select kot_no kot,table_name 'Table' from kot");
            dgv_process.ClearSelection();
            dgv_process.Columns[0].Width = 50;
            dgv_process.Columns[1].Width = 90;
            dgv_process.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            cbo_table.Enabled = true;
            cbo_waitecode.Enabled = true;
            txt_waitername.ReadOnly = false;
            txt_waitername.Enabled = true;
            txt_item.Enabled = true;
            txt_itemCode.Enabled = true;
            txt_qty.ReadOnly = false;
            dgv_item.Enabled = true;
            btn_remove.Visible = true;

            //////-----Enable False when paymeny mode cash-----///////
            colan_Amount.Visible = false;
            lbl_Amount.Visible = false;
            cbo_Amount.Visible = false;

            lbl_paid.Visible = true;
            lbl_bal.Visible = true;
            colan_bal.Visible = true;
            colan_paid.Visible = true;
            txt_paid.Visible = true;
            txt_bal.Visible = true;
            cbo_Amount.Text = "Received";

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
        /// //////////  ---Category Buttons and Item Showing datagridview---  ///////////////
        /// </summary>
        #region Category Button Load and Item Showing Datagridview
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
                for (int i = 0; i < dgv_billing.Rows.Count; i++)
                {
                    if (row.Cells["Code"].Value.ToString() == dgv_billing.Rows[i].Cells["_Code"].Value.ToString())
                    {
                        dgv_billing.Rows[i].Cells["_Qty"].Value = Convert.ToInt16(dgv_billing.Rows[i].Cells["_Qty"].Value) + 1;
                        dgv_billing.Rows[i].Cells["_Amount"].Value = Convert.ToInt16(dgv_billing.Rows[i].Cells["_Qty"].Value) * Convert.ToDecimal(dgv_billing.Rows[i].Cells["_Price"].Value);
                        flag = false;
                        dgv_billing.Rows[i].Selected = true;
                        Calculations();
                        lbl_msg.ForeColor = Color.Lime;
                        DisplayWarning("'" + dgv_billing.Rows[i].Cells["_Name"].Value + "' Updated Sucessfully!");
                    }
                }
                if (flag)
                {
                    DataTable dt = new DataTable();
                    dt = cdata.GetTable("select M.Code Code,Name,U.Unit Unit,Price from menu_item M inner join item_unit U on M.Unit= U.Code where M.Code=" + txt_itemCode.Text + "");
                    dgv_billing.Rows.Add(row.Cells["Code"].Value, row.Cells["Name"].Value, 1, row.Cells["Unit"].Value, row.Cells["Price"].Value, (Convert.ToDecimal(row.Cells["Price"].Value)));
                    dgv_billing.Rows[dgv_billing.Rows.Count - 1].Selected = true;
                    Calculations();
                    lbl_msg.ForeColor = Color.Lime;
                    DisplayWarning("'" + row.Cells["Name"].Value + "' Added Sucessfully!");
                }

                //------clear Item-------
                clearItemtxt();

            }
            catch
            {
                lbl_msg.ForeColor = Color.Red;
                DisplayWarning("something went to wrong");
            }
        }

        #endregion

        private void btn_copy_Click(object sender, EventArgs e)
        {

        }
        #region PrintFunction
        public void PrintFunction()
        {
            try
            {
                string PrntName = cdata.GetSingleValue("select PrinterName from printer where Enable=1");
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(RepData.FormatString("THE MADRAS RESTRO & CAFE", 33, 0));
                sb.AppendLine();
                sb.AppendLine(RepData.FormatString("ShopNo 26 & 27,Nexus Business Hub", 33, 0));
                sb.AppendLine(RepData.FormatString("Zadeshwar Road, Bharuch - 392001", 33, 0));
                sb.AppendLine(RepData.FormatString(" Phone - 8849988480", 33, 0));
                sb.AppendLine(RepData.Repeat("-", 33));
                sb.Append(RepData.FormatString("B.No:" + txt_billNo.Text + "", 14, 1));
                sb.AppendLine(RepData.FormatString("" + DateTime.Now.ToString("dd-MM-yyyy hh:mmtt") + "", 19, 2));
                if (cbo_billType.Text == "Dine In")
                    sb.AppendLine(RepData.FormatString("Table:" + cbo_table.Text.Substring(6, 1) + "", 20, 1));
                sb.Append(RepData.FormatString("Item            Rate  Qty  Amount", 33, 0)); //Item=15 Rate=6 Qty=4 Amount=6
                sb.AppendLine();
                sb.AppendLine(RepData.Repeat("-", 33));

                foreach (DataGridViewRow dr in dgv_billing.Rows)
                {
                    sb.Append(RepData.FormatString((cdata.GetSingleValue("select PrintName from menu_item where Code=" + dr.Cells["_Code"].Value + "")).Trim(), 15, 1));
                    sb.Append(RepData.FormatString((dr.Cells["_Price"].Value.ToString()).Trim(), 6, 2));
                    sb.Append(RepData.FormatString((dr.Cells["_Qty"].Value.ToString()).Trim(), 3, 2));
                    sb.Append(RepData.FormatString((dr.Cells["_Amount"].Value.ToString()).Trim(), 9, 2));
                    sb.AppendLine();
                }
                sb.AppendLine(RepData.Repeat("-", 33));
                ////--SubTotal---/////
                sb.Append(RepData.FormatString("SubTotal", 8, 1));
                sb.Append(RepData.FormatString(txt_qtys.Text, 16, 2));
                sb.Append(RepData.FormatString(txt_subTotal.Text, 9, 2));
                sb.AppendLine();
                ////--SGST---/////
                sb.Append(RepData.FormatString("SGST", 4, 1));
                sb.Append(RepData.FormatString("", 19, 2));
                sb.Append(RepData.FormatString(txt_SGST.Text, 10, 2));
                sb.AppendLine();
                ////--CGST---/////
                sb.Append(RepData.FormatString("CGST", 4, 1));
                sb.Append(RepData.FormatString("", 19, 2));
                sb.Append(RepData.FormatString(txt_CGST.Text, 10, 2));
                sb.AppendLine();
                ////--Discount---/////
                sb.Append(RepData.FormatString("Discount", 8, 1));
                sb.Append(RepData.FormatString("", 15, 2));
                if (cbo_dis.Text != "%")
                    sb.Append(RepData.FormatString(txt_dis.Text == "" ? "0.00" : Convert.ToDecimal(txt_dis.Text).ToString("0.00"), 10, 2));
                else
                {
                    string Discount = ((Convert.ToDecimal(txt_dis.Text == "" ? "0" : txt_dis.Text) / 100) * Convert.ToDecimal(txt_subTotal.Text)).ToString("0.00");
                    sb.Append(RepData.FormatString(txt_dis.Text == "" ? "0.00" : Discount, 10, 2));
                }

                sb.AppendLine();
                ////--CGST---/////
                sb.Append(RepData.FormatString("S.Charge", 8, 1));
                sb.Append(RepData.FormatString("", 15, 2));
                sb.Append(RepData.FormatString(txt_servChrg.Text, 10, 2));
                sb.AppendLine();

                ////--Total---/////
                sb.AppendLine(RepData.Repeat("-", 33));
                sb.Append(RepData.FormatString("Total", 5, 1));
                sb.Append(RepData.FormatString("", 15, 2));
                sb.Append(RepData.FormatString("₹ " + btn_totalAmount.Text, 13, 2));
                sb.AppendLine();

                sb.AppendLine(RepData.Repeat("-", 33));
                if (txt_guest.Text == "")
                    sb.AppendLine(RepData.FormatString(" THANK YOU VISIT AGAIN ", 33, 0));
                else
                    sb.AppendLine(RepData.FormatString("THANK YOU '" + txt_guest.Text.ToUpper() + "' VISIT AGAIN", 33, 0));
                sb.AppendLine(RepData.Repeat("*", 33));
                sb.AppendLine(RepData.FormatString("NO PAIN NO GAIN", 33, 0));



                RepData.PrintFile(sb, PrntName);

            }
            catch (Exception ex)
            { }



        }
        #endregion
        private void btn_kot_Click(object sender, EventArgs e)
        {
            Globalvar.kot = 0;
            kot Main = new kot();
            Main.Show();
            this.Close();
        }
        ///////////-------KOT PROCESS-------//////////////////
        private void dgv_process_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                ///////////////////----Items------////////////////////
                clearItemtxt();

                dgv_billing.Rows.Clear();
                dgv_billing.Refresh();

                dgv_item.DataSource = new DataTable();


                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_process.Rows[rowIndex];
                Globalvar.kot = Convert.ToInt64(dgv_process.SelectedRows[0].Cells["Kot"].Value);
                loadKOT();

                 ////////////////---Change color Red to 
            lbl_table.ForeColor = Color.Aqua;
            lbl_waiter.ForeColor = Color.Aqua;
            lbl_paid.ForeColor = Color.Aqua;

            }
            catch
            {

            }

        }






















    }
}
