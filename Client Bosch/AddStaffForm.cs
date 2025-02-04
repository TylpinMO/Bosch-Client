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
    public partial class AddStaffForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public AddStaffForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string Middle_name = textBox3.Text;
            string Position = textBox4.Text;

            string query = "INSERT INTO Staff ([Фамилия], [Имя], [Отчество], [Должность]) VALUES ('" + Name + "', '" + Surname + "', '" + Middle_name + "', '" + Position + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сотрудник добавлен", "Внимание!");
        }
    }
}
