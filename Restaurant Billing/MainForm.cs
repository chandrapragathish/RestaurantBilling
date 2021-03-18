using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Billing.Master;

namespace Restaurant_Billing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
        }

       

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pnl_Master.Visible = false;
            pnl_KOT.Visible = false;

        }

        private void btn_Master_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_Master);
            pnl_Master.Visible = true;
            pnl_KOT.Visible = false;
        }

        private void btn_billing_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_billing);
            pnl_Master.Visible = false;
            pnl_KOT.Visible = false;
        }

        private void btn_kot_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_kot);
            pnl_KOT.Visible = true;
            pnl_Master.Visible = false;
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.MenuItem menuItem = new Restaurant_Billing.Master.MenuItem();
            menuItem.Show();
            this.Hide();
        }

        private void btn_itemCategory_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Category menuItem = new Restaurant_Billing.Master.Category();
            menuItem.Show();
            this.Hide();
        }

        private void btn_Master_Click(object sender, EventArgs e)
        {
            movepanel(btn_Master);
            pnl_Master.Visible = true;
            pnl_KOT.Visible = false;
        }

        private void btn_kot_Click(object sender, EventArgs e)
        {
            movepanel(btn_kot);
            pnl_KOT.Visible = true;
            pnl_Master.Visible = false;
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Billing menuItem = new Restaurant_Billing.Master.Billing();
            menuItem.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_itemUnit_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Unit menuItem = new Restaurant_Billing.Master.Unit();
            menuItem.Show();
            this.Hide();
        }

        private void btn_divsion_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Division menuItem = new Restaurant_Billing.Master.Division();
            menuItem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Tables menuItem = new Restaurant_Billing.Master.Tables();
            menuItem.Show();
            this.Hide();
        }

        private void btn_tax_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Tax menuItem = new Restaurant_Billing.Master.Tax();
            menuItem.Show();
            this.Hide();
        }

        private void btn_waiter_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.waiters menuItem = new Restaurant_Billing.Master.waiters();
            menuItem.Show();
            this.Hide();
        }

        private void btnkot_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.kot menuItem = new Restaurant_Billing.Master.kot();
            menuItem.Show();
            this.Hide();
        }

        private void btn_prsKot_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.ProcessKot menuItem = new Restaurant_Billing.Master.ProcessKot();
            menuItem.Show();
            this.Hide();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            Restaurant_Billing.Master.Guest menuItem = new Restaurant_Billing.Master.Guest();
            menuItem.Show();
            this.Hide();
        }

      

    }
}
