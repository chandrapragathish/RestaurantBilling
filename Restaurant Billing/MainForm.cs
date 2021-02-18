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
            pnl_billing.Visible = false;

        }

        private void btn_Master_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_Master);
            pnl_Master.Visible = true;
            pnl_KOT.Visible = false;
            pnl_billing.Visible = false;
        }

        private void btn_billing_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_billing);
            pnl_billing.Visible = true;
            pnl_Master.Visible = false;
            pnl_KOT.Visible = false;
        }

        private void btn_kot_MouseHover(object sender, EventArgs e)
        {
            movepanel(btn_kot);
            pnl_KOT.Visible = true;
            pnl_Master.Visible = false;
            pnl_billing.Visible = false;
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
            pnl_billing.Visible = false;
        }

        private void btn_kot_Click(object sender, EventArgs e)
        {
            movepanel(btn_kot);
            pnl_KOT.Visible = true;
            pnl_Master.Visible = false;
            pnl_billing.Visible = false;
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            movepanel(btn_billing);
            pnl_billing.Visible = true;
            pnl_Master.Visible = false;
            pnl_KOT.Visible = false;
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

      

    }
}
