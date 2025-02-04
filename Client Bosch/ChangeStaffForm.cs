using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Client_Bosch
{
    public partial class ChangeStaffForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public ChangeStaffForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void ChangeStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер сотрудника.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE Staff SET [Фамилия] ='" + textBox1.Text + "' WHERE [Персональный номер] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Фамилия сотрудника изменена", "Внимание!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер сотрудника.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE Staff SET [Имя] ='" + textBox2.Text + "' WHERE [Персональный номер] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Имя сотрудника изменено", "Внимание!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер сотрудника.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE Staff SET [Отчество] ='" + textBox3.Text + "' WHERE [Персональный номер] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Отчество сотрудника изменено", "Внимание!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер сотрудника.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE Staff SET [Должность] ='" + textBox4.Text + "' WHERE [Персональный номер] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Должность сотрудника изменена", "Внимание!");
            }
        }

        private void AddBut_Click(object sender, EventArgs e)
        {

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        
    }
}
