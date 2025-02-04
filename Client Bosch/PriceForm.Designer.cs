namespace Client_Bosch
{
    partial class PriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceForm));
            this.ActionsBox = new System.Windows.Forms.GroupBox();
            this.AboutBut = new System.Windows.Forms.Button();
            this.DeleteBox = new System.Windows.Forms.Button();
            this.ChangeBox = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.workTypePriceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bosch_client_db1DataSet = new Client_Bosch.Bosch_client_db1DataSet();
            this.workTypePriceListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workTypePriceListTableAdapter = new Client_Bosch.Bosch_client_db1DataSetTableAdapters.WorkTypePriceListTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ActionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTypePriceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypePriceListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionsBox
            // 
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
            this.ActionsBox.TabIndex = 7;
            this.ActionsBox.TabStop = false;
            this.ActionsBox.Text = "Действия";
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
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BackBut.Location = new System.Drawing.Point(12, 435);
            this.BackBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(94, 32);
            this.BackBut.TabIndex = 7;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // workTypePriceListBindingSource
            // 
            this.workTypePriceListBindingSource.DataMember = "WorkTypePriceList";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.типРаботыDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workTypePriceListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 8;
            // 
            // bosch_client_db1DataSet
            // 
            this.bosch_client_db1DataSet.DataSetName = "Bosch_client_db1DataSet";
            this.bosch_client_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workTypePriceListBindingSource1
            // 
            this.workTypePriceListBindingSource1.DataMember = "WorkTypePriceList";
            this.workTypePriceListBindingSource1.DataSource = this.bosch_client_db1DataSet;
            // 
            // workTypePriceListTableAdapter
            // 
            this.workTypePriceListTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // типРаботыDataGridViewTextBoxColumn
            // 
            this.типРаботыDataGridViewTextBoxColumn.DataPropertyName = "Тип работы";
            this.типРаботыDataGridViewTextBoxColumn.HeaderText = "Тип работы";
            this.типРаботыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типРаботыDataGridViewTextBoxColumn.Name = "типРаботыDataGridViewTextBoxColumn";
            this.типРаботыDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(112, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.ActionsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceForm";
            this.Text = "Прейскурант";
            this.Load += new System.EventHandler(this.PriceForm_Load);
            this.ActionsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workTypePriceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypePriceListBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ActionsBox;
        private System.Windows.Forms.Button AboutBut;
        private System.Windows.Forms.Button DeleteBox;
        private System.Windows.Forms.Button ChangeBox;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button BackBut;

        private System.Windows.Forms.BindingSource workTypePriceListBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bosch_client_db1DataSet bosch_client_db1DataSet;
        private System.Windows.Forms.BindingSource workTypePriceListBindingSource1;
        private Bosch_client_db1DataSetTableAdapters.WorkTypePriceListTableAdapter workTypePriceListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}