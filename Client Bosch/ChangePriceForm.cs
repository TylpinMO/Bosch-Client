using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Client_Bosch
{
    public partial class ChangePriceForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public ChangePriceForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер услуги.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE WorkTypePriceList SET [Тип работы] ='" + textBox1.Text + "' WHERE [Код] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Тип услуги изменен", "Внимание!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер услуги.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE WorkTypePriceList SET [Стоимость] ='" + textBox2.Text + "' WHERE [Код] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Стоимость услуги изменена", "Внимание!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите номер услуги.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {
                int kod = Convert.ToInt32(textBox5.Text);
                string query = "UPDATE WorkTypePriceList SET [Исполнитель] ='" + textBox3.Text + "' WHERE [Код] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Исполнитель услуги изменен", "Внимание!");
            }
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void ChangePriceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
