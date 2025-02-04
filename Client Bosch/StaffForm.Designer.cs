namespace Client_Bosch
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.ActionsBox = new System.Windows.Forms.GroupBox();
            this.PrintBut = new System.Windows.Forms.Button();
            this.AboutBut = new System.Windows.Forms.Button();
            this.DeleteBox = new System.Windows.Forms.Button();
            this.ChangeBox = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bosch_client_db1DataSet = new Client_Bosch.Bosch_client_db1DataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Client_Bosch.Bosch_client_db1DataSetTableAdapters.StaffTableAdapter();
            this.персональныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.персональныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionsBox
            // 
            this.ActionsBox.BackColor = System.Drawing.Color.LightBlue;
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
            this.ActionsBox.TabIndex = 7;
            this.ActionsBox.TabStop = false;
            this.ActionsBox.Text = "Действия";
            // 
            // PrintBut
            // 
            this.PrintBut.Location = new System.Drawing.Point(306, 22);
            this.PrintBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBut.Name = "PrintBut";
            this.PrintBut.Size = new System.Drawing.Size(133, 51);
            this.PrintBut.TabIndex = 6;
            this.PrintBut.Text = "Посмотреть информацию";
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
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BackBut.Location = new System.Drawing.Point(12, 435);
            this.BackBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(94, 32);
            this.BackBut.TabIndex = 9;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(112, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.персональныйНомерDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 12;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.bosch_client_db1DataSet;
            // 
            // bosch_client_db1DataSet
            // 
            this.bosch_client_db1DataSet.DataSetName = "Bosch_client_db1DataSet";
            this.bosch_client_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.bosch_client_db1DataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // персональныйНомерDataGridViewTextBoxColumn
            // 
            this.персональныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Персональный номер";
            this.персональныйНомерDataGridViewTextBoxColumn.HeaderText = "Персональный номер";
            this.персональныйНомерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.персональныйНомерDataGridViewTextBoxColumn.Name = "персональныйНомерDataGridViewTextBoxColumn";
            this.персональныйНомерDataGridViewTextBoxColumn.Width = 125;
            // 
            // персональныйНомерDataGridViewTextBoxColumn1
            // 
            this.персональныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Персональный номер";
            this.персональныйНомерDataGridViewTextBoxColumn1.HeaderText = "Персональный номер";
            this.персональныйНомерDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.персональныйНомерDataGridViewTextBoxColumn1.Name = "персональныйНомерDataGridViewTextBoxColumn1";
            this.персональныйНомерDataGridViewTextBoxColumn1.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.ActionsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.ActionsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ActionsBox;
        private System.Windows.Forms.Button AboutBut;
        private System.Windows.Forms.Button DeleteBox;
        private System.Windows.Forms.Button ChangeBox;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button PrintBut;
        private System.Windows.Forms.Button BackBut;
        private Bosch_client_db1DataSet bosch_client_db1DataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Bosch_client_db1DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn персональныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn персональныйНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
    }
}