using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Bosch.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButHide_Click(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = true;
            ButShow.Visible = true;
            ButHide.Visible = false;
        }

        private void ButShow_Click(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar=false;
            ButShow.Visible = false;
            ButHide.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = true;
            textBox_log.MaxLength = 20;
            textBox_pass.MaxLength = 20;
            ButHide.Visible = false;
            this.AcceptButton = butLog;
        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void textBox_log_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox_pass.Focus();
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                butLog.PerformClick();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_log.Text))
            {
                MessageBox.Show("Введите Логин.","Внимание!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_log.Focus();
                return;
            }
            try
            {
                Bosch_client_db1DataSetTableAdapters.login_staffTableAdapter user = new Bosch_client_db1DataSetTableAdapters.login_staffTableAdapter();
                Bosch_client_db1DataSet.login_staffDataTable dt = user.GetDataByLoginPassword(textBox_log.Text, textBox_pass.Text);
                if (dt.Rows.Count > 0) 
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Неправильно введен Логин или Пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
    }
}
