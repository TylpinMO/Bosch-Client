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
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace Client_Bosch
{
    
    public partial class OrderForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public OrderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
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

        private void AddBut_Click(object sender, EventArgs e)
        {
            AddOrderForm addForm = new AddOrderForm();
            addForm.ShowDialog();
        }

        private void ChangeBox_Click(object sender, EventArgs e)
        {
            ChangeOrderForm changeForm = new ChangeOrderForm();
            changeForm.ShowDialog();
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            DeleteOrderForm deleteForm = new DeleteOrderForm();
            deleteForm.ShowDialog();
        }

        private void PrintBut_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }



            exApp.Visible = true;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bosch_client_db1DataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.bosch_client_db1DataSet.Orders);

        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.bosch_client_db1DataSet.Orders);
        }

        private void ordersBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ActionsBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
