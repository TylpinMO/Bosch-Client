namespace Client_Bosch
{
    partial class DeleteOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOrderForm));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OKbut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.bosch_client_db1DataSet = new Client_Bosch.Bosch_client_db1DataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Client_Bosch.Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(12, 36);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(185, 32);
            this.textBox6.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Номер заказа";
            // 
            // OKbut
            // 
            this.OKbut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.OKbut.Location = new System.Drawing.Point(330, 241);
            this.OKbut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKbut.Name = "OKbut";
            this.OKbut.Size = new System.Drawing.Size(109, 32);
            this.OKbut.TabIndex = 50;
            this.OKbut.Text = "Удалить";
            this.OKbut.UseVisualStyleBackColor = true;
            this.OKbut.Click += new System.EventHandler(this.OKbut_Click);
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.BackBut.Location = new System.Drawing.Point(445, 241);
            this.BackBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(94, 32);
            this.BackBut.TabIndex = 49;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // bosch_client_db1DataSet
            // 
            this.bosch_client_db1DataSet.DataSetName = "Bosch_client_db1DataSet";
            this.bosch_client_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bosch_client_db1DataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OKbut);
            this.Controls.Add(this.BackBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteOrderForm";
            this.Text = "Удаление заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.DeleteOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bosch_client_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OKbut;
        private System.Windows.Forms.Button BackBut;
        private Bosch_client_db1DataSet bosch_client_db1DataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Bosch_client_db1DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}