using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_Bosch
{
    public partial class ChangeOrderForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public ChangeOrderForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void OKbut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox6.Text);
                string query = "UPDATE Orders SET [Сумма заказа] ='" + textBox5.Text + "' WHERE [Номер заказа] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Сумма заказа изменена", "Внимание!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox6.Text);
                string query1 = "UPDATE Orders SET Заказчик ='" + textBox1.Text + "' WHERE [Номер заказа] = " + kod;
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                command1.ExecuteNonQuery();
                MessageBox.Show("Заказчик изменен", "Внимание!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox6.Text);
                string query2 = "UPDATE Orders SET [Марка авто] ='" + textBox2.Text + "' WHERE [Номер заказа] = " + kod;
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                command2.ExecuteNonQuery();
                MessageBox.Show("Марка авто изменена", "Внимание!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox6.Text);
                string query3 = "UPDATE Orders SET [Номер авто] ='" + textBox3.Text + "' WHERE [Номер заказа] = " + kod;
                OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                command3.ExecuteNonQuery();
                MessageBox.Show("Номер авто изменен", "Внимание!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox6.Text);
                string query4 = "UPDATE Orders SET [Тип работ] ='" + textBox4.Text + "' WHERE [Номер заказа] = " + kod;
                OleDbCommand command4 = new OleDbCommand(query4, myConnection);
                command4.ExecuteNonQuery();
                MessageBox.Show("Тип работ изменен", "Внимание!");
            }
        }

        private void ChangeOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
