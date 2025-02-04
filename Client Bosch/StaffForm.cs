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
using Excel = Microsoft.Office.Interop.Excel;

namespace Client_Bosch
{
    public partial class StaffForm : Form
    {
        public StaffForm()
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

        private void AddBut_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
        }

        private void ChangeBox_Click(object sender, EventArgs e)
        {
            ChangeStaffForm changeStaffForm = new ChangeStaffForm();
            changeStaffForm.ShowDialog();
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            DeleteStaffForm deleteStaffForm = new DeleteStaffForm();
            deleteStaffForm.ShowDialog();
        }

        private void PrintBut_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }



            exApp.Visible = true;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bosch_client_db1DataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.bosch_client_db1DataSet.Staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.bosch_client_db1DataSet.Staff);
        }
    }
}
