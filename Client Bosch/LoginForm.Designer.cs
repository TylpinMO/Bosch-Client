namespace Client_Bosch.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.butInfo = new System.Windows.Forms.Button();
            this.butLog = new System.Windows.Forms.Button();
            this.ButShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(134, 172);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(268, 43);
            this.textBox_log.TabIndex = 3;
            this.textBox_log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_log_KeyPress);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(134, 251);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(268, 43);
            this.textBox_pass.TabIndex = 4;
            this.textBox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_KeyPress);
            // 
            // butInfo
            // 
            this.butInfo.Location = new System.Drawing.Point(12, 434);
            this.butInfo.Name = "butInfo";
            this.butInfo.Size = new System.Drawing.Size(46, 46);
            this.butInfo.TabIndex = 5;
            this.butInfo.Text = "?";
            this.butInfo.UseVisualStyleBackColor = true;
            this.butInfo.Click += new System.EventHandler(this.butInfo_Click);
            // 
            // butLog
            // 
            this.butLog.Location = new System.Drawing.Point(184, 435);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(135, 46);
            this.butLog.TabIndex = 6;
            this.butLog.Text = "Вход";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // ButShow
            // 
            this.ButShow.Location = new System.Drawing.Point(408, 251);
            this.ButShow.Name = "ButShow";
            this.ButShow.Size = new System.Drawing.Size(46, 43);
            this.ButShow.TabIndex = 7;
            this.ButShow.Text = "👁";
            this.ButShow.UseVisualStyleBackColor = true;
            this.ButShow.Click += new System.EventHandler(this.ButShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Client_Bosch.Properties.Resources.BOSCH;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButHide
            // 
            this.ButHide.Location = new System.Drawing.Point(408, 251);
            this.ButHide.Name = "ButHide";
            this.ButHide.Size = new System.Drawing.Size(46, 43);
            this.ButHide.TabIndex = 8;
            this.ButHide.Text = "👁";
            this.ButHide.UseVisualStyleBackColor = true;
            this.ButHide.Click += new System.EventHandler(this.ButHide_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(497, 493);
            this.Controls.Add(this.ButHide);
            this.Controls.Add(this.ButShow);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.butInfo);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button butInfo;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button ButShow;
        private System.Windows.Forms.Button ButHide;
    }
}