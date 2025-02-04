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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_Bosch
{
    public partial class AddPriceForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public AddPriceForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddPriceForm_Load(object sender, EventArgs e)
        {

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(textBox2.Text);
            string TypeWork = textBox1.Text;
            string Position = textBox3.Text;

            string query = "INSERT INTO WorkTypePriceList ([Тип работы], [Стоимость], [Исполнитель]) VALUES ('" + TypeWork + "', " + Price + ", '" + Position + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Услуга добавлена", "Внимание!");
        }
    }
}
