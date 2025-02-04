using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Bosch.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutBut_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void OrderBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void PriceBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceForm priceForm = new PriceForm();
            priceForm.Show();
        }

        private void StaffBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }
    }
}
