namespace Client_Bosch
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.BackBut = new System.Windows.Forms.Button();
            this.ActionsBox = new System.Windows.Forms.GroupBox();
            this.PrintBut = new System.Windows.Forms.Button();
            this.AboutBut = new System.Windows.Forms.Button();
            this.DeleteBox = new System.Windows.Forms.Button();
            this.ChangeBox = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bosch_client_db1DataSet = new Client_Bosch.Bosch_client_db1DataSet();
            this.boschclientdb1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Client_Bosch.Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ActionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boschclientdb1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BackBut.Location = new System.Drawing.Point(12, 435);
            this.BackBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(94, 32);
            this.BackBut.TabIndex = 6;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // ActionsBox
            // 
            this.ActionsBox.Controls.Add(this.PrintBut);
            this.ActionsBox.Controls.Add(this.AboutBut);
            this.ActionsBox.Controls.Add(this.DeleteBox);
            this.ActionsBox.Controls.Add(this.ChangeBox);
            this.ActionsBox.Controls.Add(this.AddBut);
            this.ActionsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ActionsBox.Location = new System.Drawing.Point(0, 0);
            this.ActionsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActionsBox.Name = "ActionsBox";
            this.ActionsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActionsBox.Size = new System.Drawing.Size(800, 78);
            this.ActionsBox.TabIndex = 5;
            this.ActionsBox.TabStop = false;
            this.ActionsBox.Text = "Действия";
            this.ActionsBox.Enter += new System.EventHandler(this.ActionsBox_Enter);
            // 
            // PrintBut
            // 
            this.PrintBut.Location = new System.Drawing.Point(306, 22);
            this.PrintBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBut.Name = "PrintBut";
            this.PrintBut.Size = new System.Drawing.Size(94, 51);
            this.PrintBut.TabIndex = 6;
            this.PrintBut.Text = "Печать";
            this.PrintBut.UseVisualStyleBackColor = true;
            this.PrintBut.Click += new System.EventHandler(this.PrintBut_Click);
            // 
            // AboutBut
            // 
            this.AboutBut.Location = new System.Drawing.Point(757, 12);
            this.AboutBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AboutBut.Name = "AboutBut";
            this.AboutBut.Size = new System.Drawing.Size(31, 34);
            this.AboutBut.TabIndex = 4;
            this.AboutBut.Text = "?";
            this.AboutBut.UseVisualStyleBackColor = true;
            this.AboutBut.Click += new System.EventHandler(this.AboutBut_Click);
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(206, 22);
            this.DeleteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(94, 51);
            this.DeleteBox.TabIndex = 2;
            this.DeleteBox.Text = "Удалить";
            this.DeleteBox.UseVisualStyleBackColor = true;
            this.DeleteBox.Click += new System.EventHandler(this.DeleteBox_Click);
            // 
            // ChangeBox
            // 
            this.ChangeBox.Location = new System.Drawing.Point(106, 22);
            this.ChangeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(94, 51);
            this.ChangeBox.TabIndex = 1;
            this.ChangeBox.Text = "Изменить";
            this.ChangeBox.UseVisualStyleBackColor = true;
            this.ChangeBox.Click += new System.EventHandler(this.ChangeBox_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(6, 22);
            this.AddBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(94, 51);
            this.AddBut.TabIndex = 0;
            this.AddBut.Text = "Добавить";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.CurrentChanged += new System.EventHandler(this.ordersBindingSource2_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ordersBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 7;
            // 
            // bosch_client_db1DataSet
            // 
            this.bosch_client_db1DataSet.DataSetName = "Bosch_client_db1DataSet";
            this.bosch_client_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boschclientdb1DataSetBindingSource
            // 
            this.boschclientdb1DataSetBindingSource.DataSource = this.bosch_client_db1DataSet;
            this.boschclientdb1DataSetBindingSource.Position = 0;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.boschclientdb1DataSetBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Заказчик";
            this.dataGridViewTextBoxColumn2.HeaderText = "Заказчик";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Марка авто";
            this.dataGridViewTextBoxColumn3.HeaderText = "Марка авто";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер авто";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер авто";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Тип работ";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип работ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Сумма заказа";
            this.dataGridViewTextBoxColumn6.HeaderText = "Сумма заказа";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(112, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.ActionsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ActionsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boschclientdb1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.GroupBox ActionsBox;
        private System.Windows.Forms.Button AboutBut;
        private System.Windows.Forms.Button DeleteBox;
        private System.Windows.Forms.Button ChangeBox;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberautoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button PrintBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource boschclientdb1DataSetBindingSource;
        private Bosch_client_db1DataSet bosch_client_db1DataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}