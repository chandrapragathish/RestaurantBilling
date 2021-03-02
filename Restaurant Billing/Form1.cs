using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
      
        private void createButton()
        {
           
            for (int i = 0; i < 10; ++i)
            {
                Button button = new Button();
                button.Location = new Point(button.Width * i + 4, 0);
                button.Text = "Button"+i;
                button.Click += new EventHandler(b_Click);
                panel1.Controls.Add(button);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.Button)sender).Name + " clicked");
        }
    }
}
