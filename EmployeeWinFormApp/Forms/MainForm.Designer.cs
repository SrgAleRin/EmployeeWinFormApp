namespace EmployeeWinFormApp.Forms
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeTable = new System.Windows.Forms.Button();
            this.MonthPaymentSum = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeTable);
            this.panel1.Controls.Add(this.MonthPaymentSum);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 27);
            this.panel1.TabIndex = 0;
            // 
            // TimeTable
            // 
            this.TimeTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeTable.Location = new System.Drawing.Point(232, 0);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Size = new System.Drawing.Size(75, 27);
            this.TimeTable.TabIndex = 3;
            this.TimeTable.Text = "Табель";
            this.TimeTable.UseVisualStyleBackColor = true;
            this.TimeTable.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // MonthPaymentSum
            // 
            this.MonthPaymentSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthPaymentSum.Location = new System.Drawing.Point(307, 0);
            this.MonthPaymentSum.Name = "MonthPaymentSum";
            this.MonthPaymentSum.Size = new System.Drawing.Size(102, 27);
            this.MonthPaymentSum.TabIndex = 2;
            this.MonthPaymentSum.Text = "Сумма за месяц";
            this.MonthPaymentSum.UseVisualStyleBackColor = true;
            this.MonthPaymentSum.Click += new System.EventHandler(this.MonthPaymentSum_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.Add.Location = new System.Drawing.Point(409, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 27);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Del
            // 
            this.Del.Dock = System.Windows.Forms.DockStyle.Right;
            this.Del.Location = new System.Drawing.Point(484, 0);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 27);
            this.Del.TabIndex = 0;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.PaymentSum,
            this.PaymentType,
            this.Id});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(559, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // PaymentSum
            // 
            this.PaymentSum.DataPropertyName = "PaymentSum";
            this.PaymentSum.HeaderText = "Сумма";
            this.PaymentSum.Name = "PaymentSum";
            this.PaymentSum.ReadOnly = true;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "Тип оплаты";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 263);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MonthPaymentSum;
        private System.Windows.Forms.Button TimeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

