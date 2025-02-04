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
    public partial class AddOrderForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public AddOrderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void OKbut_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox6.Text);
            string Name = textBox1.Text;
            string Auto = textBox2.Text;
            string Auto_num = textBox3.Text;
            string Work = textBox4.Text;
            string Summ = textBox5.Text;
            string query = "INSERT INTO Orders ([Номер заказа], [Заказчик], [Марка авто], [Номер авто], [Тип работ], [Сумма заказа]) VALUES (" + kod + ", '" + Name + "', '" + Auto + "', '" + Auto_num + "', '" + Work + "', '" + Summ + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ добавлен", "Внимание!");

        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
