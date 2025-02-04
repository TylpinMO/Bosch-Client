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

namespace Client_Bosch
{
    public partial class DeleteOrderForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public DeleteOrderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void DeleteOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bosch_client_db1DataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.bosch_client_db1DataSet.Orders);
        }

        private void DeleteOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void OKbut_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox6.Text);
            string query = "DELETE FROM Orders WHERE [Номер заказа] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о заказе удалены", "Внимание!");
        }
    }
}
