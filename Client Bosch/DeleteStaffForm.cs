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
    public partial class DeleteStaffForm : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Bosch_client_db1.accdb";
        private OleDbConnection myConnection;
        public DeleteStaffForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Staff WHERE [Персональный номер] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике удалены", "Внимание!");
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            this.Close();
        }

        private void DeleteStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
