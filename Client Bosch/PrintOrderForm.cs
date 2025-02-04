using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Client_Bosch
{

    public partial class PrintOrderForm : Form
    {
        

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bosch_client_db1DataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.bosch_client_db1DataSet.Orders);

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount-2;i++)
            {
                for (j = 0; j < dataGridView1.ColumnCount-1;j++)
                {
                    wsh.Cells[i + 1,j + 1] = dataGridView1[j,1].Value.ToString();
                }
            }



            exApp.Visible = true;
        }
    }
}
