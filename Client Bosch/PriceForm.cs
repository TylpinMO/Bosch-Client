using Client_Bosch.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Bosch
{
    public partial class PriceForm : Form
    {
        public PriceForm()
        {
            InitializeComponent();
        }

        private void AboutBut_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(); 
            mainForm.Show();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bosch_client_db1DataSet.WorkTypePriceList". При необходимости она может быть перемещена или удалена.
            this.workTypePriceListTableAdapter.Fill(this.bosch_client_db1DataSet.WorkTypePriceList);

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            AddPriceForm addPriceForm = new AddPriceForm();
            addPriceForm.ShowDialog();
        }

        private void ChangeBox_Click(object sender, EventArgs e)
        {
            ChangePriceForm changePriceForm = new ChangePriceForm();
            changePriceForm.ShowDialog();
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            DeletePriceForm deletePriceForm = new DeletePriceForm();
            deletePriceForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workTypePriceListTableAdapter.Fill(this.bosch_client_db1DataSet.WorkTypePriceList);
        }
    }
}
