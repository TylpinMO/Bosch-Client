namespace Client_Bosch
{
    partial class PrintOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOrderForm));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bosch_client_db1DataSet = new Client_Bosch.Bosch_client_db1DataSet();
            this.ordersTableAdapter = new Client_Bosch.Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(17, 37);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(185, 32);
            this.textBox6.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Номер заказа";
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.exportButton.Location = new System.Drawing.Point(192, 174);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(109, 34);
            this.exportButton.TabIndex = 55;
            this.exportButton.Text = "Печать";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.BackBut.Location = new System.Drawing.Point(307, 174);
            this.BackBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(94, 34);
            this.BackBut.TabIndex = 54;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.маркаАвтоDataGridViewTextBoxColumn,
            this.номерАвтоDataGridViewTextBoxColumn,
            this.типРаботDataGridViewTextBoxColumn,
            this.суммаЗаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 22);
            this.dataGridView1.TabIndex = 58;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.Width = 125;
            // 
            // маркаАвтоDataGridViewTextBoxColumn
            // 
            this.маркаАвтоDataGridViewTextBoxColumn.DataPropertyName = "Марка авто";
            this.маркаАвтоDataGridViewTextBoxColumn.HeaderText = "Марка авто";
            this.маркаАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маркаАвтоDataGridViewTextBoxColumn.Name = "маркаАвтоDataGridViewTextBoxColumn";
            this.маркаАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерАвтоDataGridViewTextBoxColumn
            // 
            this.номерАвтоDataGridViewTextBoxColumn.DataPropertyName = "Номер авто";
            this.номерАвтоDataGridViewTextBoxColumn.HeaderText = "Номер авто";
            this.номерАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерАвтоDataGridViewTextBoxColumn.Name = "номерАвтоDataGridViewTextBoxColumn";
            this.номерАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // типРаботDataGridViewTextBoxColumn
            // 
            this.типРаботDataGridViewTextBoxColumn.DataPropertyName = "Тип работ";
            this.типРаботDataGridViewTextBoxColumn.HeaderText = "Тип работ";
            this.типРаботDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типРаботDataGridViewTextBoxColumn.Name = "типРаботDataGridViewTextBoxColumn";
            this.типРаботDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаЗаказаDataGridViewTextBoxColumn
            // 
            this.суммаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаЗаказаDataGridViewTextBoxColumn.Name = "суммаЗаказаDataGridViewTextBoxColumn";
            this.суммаЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bosch_client_db1DataSet;
            // 
            // bosch_client_db1DataSet
            // 
            this.bosch_client_db1DataSet.DataSetName = "Bosch_client_db1DataSet";
            this.bosch_client_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // PrintOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(413, 219);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintOrderForm";
            this.Text = "Печать заказа";
            this.Load += new System.EventHandler(this.PrintOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bosch_client_db1DataSet bosch_client_db1DataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗаказаDataGridViewTextBoxColumn;
    }
}