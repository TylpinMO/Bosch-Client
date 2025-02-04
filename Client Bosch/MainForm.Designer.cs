namespace Client_Bosch.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AboutBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.StaffBut = new System.Windows.Forms.Button();
            this.PriceBut = new System.Windows.Forms.Button();
            this.OrderBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutBut
            // 
            this.AboutBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AboutBut.Location = new System.Drawing.Point(741, 11);
            this.AboutBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AboutBut.Name = "AboutBut";
            this.AboutBut.Size = new System.Drawing.Size(47, 46);
            this.AboutBut.TabIndex = 9;
            this.AboutBut.Tag = "7";
            this.AboutBut.Text = "?";
            this.AboutBut.UseVisualStyleBackColor = true;
            this.AboutBut.Click += new System.EventHandler(this.AboutBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ExitBut.Location = new System.Drawing.Point(611, 396);
            this.ExitBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(177, 43);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Выйти";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // StaffBut
            // 
            this.StaffBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.StaffBut.Location = new System.Drawing.Point(12, 143);
            this.StaffBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffBut.Name = "StaffBut";
            this.StaffBut.Size = new System.Drawing.Size(177, 43);
            this.StaffBut.TabIndex = 7;
            this.StaffBut.Text = "Сотрудники";
            this.StaffBut.UseVisualStyleBackColor = true;
            this.StaffBut.Click += new System.EventHandler(this.StaffBut_Click);
            // 
            // PriceBut
            // 
            this.PriceBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PriceBut.Location = new System.Drawing.Point(12, 76);
            this.PriceBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceBut.Name = "PriceBut";
            this.PriceBut.Size = new System.Drawing.Size(177, 43);
            this.PriceBut.TabIndex = 6;
            this.PriceBut.Text = "Прейскурант";
            this.PriceBut.UseVisualStyleBackColor = true;
            this.PriceBut.Click += new System.EventHandler(this.PriceBut_Click);
            // 
            // OrderBut
            // 
            this.OrderBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.OrderBut.Location = new System.Drawing.Point(12, 11);
            this.OrderBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderBut.Name = "OrderBut";
            this.OrderBut.Size = new System.Drawing.Size(177, 43);
            this.OrderBut.TabIndex = 5;
            this.OrderBut.Text = "Заказы";
            this.OrderBut.UseVisualStyleBackColor = true;
            this.OrderBut.Click += new System.EventHandler(this.OrderBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.StaffBut);
            this.Controls.Add(this.PriceBut);
            this.Controls.Add(this.OrderBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button StaffBut;
        private System.Windows.Forms.Button PriceBut;
        private System.Windows.Forms.Button OrderBut;
    }
}