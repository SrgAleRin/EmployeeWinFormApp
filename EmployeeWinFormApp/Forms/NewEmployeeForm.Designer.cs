namespace EmployeeWinFormApp.Forms
{
    partial class NewEmployeeForm
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
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNamePnl = new System.Windows.Forms.Panel();
            this.FirstNamePnl = new System.Windows.Forms.Panel();
            this.MiddleNamePnl = new System.Windows.Forms.Panel();
            this.PaymentTypePnl = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PaymentTypeLbl = new System.Windows.Forms.Label();
            this.PaymentSumPnl = new System.Windows.Forms.Panel();
            this.PaymentSumTxtBx = new System.Windows.Forms.TextBox();
            this.PaymentSumLbl = new System.Windows.Forms.Label();
            this.PaymentPnl = new System.Windows.Forms.Panel();
            this.ButtonsPnl = new System.Windows.Forms.Panel();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.LastNamePnl.SuspendLayout();
            this.FirstNamePnl.SuspendLayout();
            this.MiddleNamePnl.SuspendLayout();
            this.PaymentTypePnl.SuspendLayout();
            this.PaymentSumPnl.SuspendLayout();
            this.PaymentPnl.SuspendLayout();
            this.ButtonsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastNameTextBox.Location = new System.Drawing.Point(0, 13);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNameTextBox.Location = new System.Drawing.Point(0, 13);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddleNameTextBox.Location = new System.Drawing.Point(0, 13);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.MiddleNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastNameLabel.Location = new System.Drawing.Point(0, 0);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "Имя";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddleNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MiddleNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddleNameLabel.TabIndex = 5;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // LastNamePnl
            // 
            this.LastNamePnl.AutoSize = true;
            this.LastNamePnl.Controls.Add(this.LastNameTextBox);
            this.LastNamePnl.Controls.Add(this.LastNameLabel);
            this.LastNamePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastNamePnl.Location = new System.Drawing.Point(0, 0);
            this.LastNamePnl.Name = "LastNamePnl";
            this.LastNamePnl.Size = new System.Drawing.Size(333, 33);
            this.LastNamePnl.TabIndex = 6;
            // 
            // FirstNamePnl
            // 
            this.FirstNamePnl.AutoSize = true;
            this.FirstNamePnl.Controls.Add(this.FirstNameTextBox);
            this.FirstNamePnl.Controls.Add(this.FirstNameLabel);
            this.FirstNamePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNamePnl.Location = new System.Drawing.Point(0, 66);
            this.FirstNamePnl.Name = "FirstNamePnl";
            this.FirstNamePnl.Size = new System.Drawing.Size(333, 33);
            this.FirstNamePnl.TabIndex = 7;
            // 
            // MiddleNamePnl
            // 
            this.MiddleNamePnl.AutoSize = true;
            this.MiddleNamePnl.Controls.Add(this.MiddleNameTextBox);
            this.MiddleNamePnl.Controls.Add(this.MiddleNameLabel);
            this.MiddleNamePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddleNamePnl.Location = new System.Drawing.Point(0, 33);
            this.MiddleNamePnl.Name = "MiddleNamePnl";
            this.MiddleNamePnl.Size = new System.Drawing.Size(333, 33);
            this.MiddleNamePnl.TabIndex = 7;
            // 
            // PaymentTypePnl
            // 
            this.PaymentTypePnl.Controls.Add(this.comboBox1);
            this.PaymentTypePnl.Controls.Add(this.PaymentTypeLbl);
            this.PaymentTypePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaymentTypePnl.Location = new System.Drawing.Point(0, 0);
            this.PaymentTypePnl.Name = "PaymentTypePnl";
            this.PaymentTypePnl.Size = new System.Drawing.Size(237, 37);
            this.PaymentTypePnl.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // PaymentTypeLbl
            // 
            this.PaymentTypeLbl.AutoSize = true;
            this.PaymentTypeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentTypeLbl.Location = new System.Drawing.Point(0, 0);
            this.PaymentTypeLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PaymentTypeLbl.Name = "PaymentTypeLbl";
            this.PaymentTypeLbl.Size = new System.Drawing.Size(66, 13);
            this.PaymentTypeLbl.TabIndex = 0;
            this.PaymentTypeLbl.Text = "Тип оплаты";
            // 
            // PaymentSumPnl
            // 
            this.PaymentSumPnl.Controls.Add(this.PaymentSumTxtBx);
            this.PaymentSumPnl.Controls.Add(this.PaymentSumLbl);
            this.PaymentSumPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.PaymentSumPnl.Location = new System.Drawing.Point(243, 0);
            this.PaymentSumPnl.Name = "PaymentSumPnl";
            this.PaymentSumPnl.Size = new System.Drawing.Size(90, 37);
            this.PaymentSumPnl.TabIndex = 9;
            // 
            // PaymentSumTxtBx
            // 
            this.PaymentSumTxtBx.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentSumTxtBx.Location = new System.Drawing.Point(0, 13);
            this.PaymentSumTxtBx.Name = "PaymentSumTxtBx";
            this.PaymentSumTxtBx.Size = new System.Drawing.Size(90, 20);
            this.PaymentSumTxtBx.TabIndex = 1;
            // 
            // PaymentSumLbl
            // 
            this.PaymentSumLbl.AutoSize = true;
            this.PaymentSumLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentSumLbl.Location = new System.Drawing.Point(0, 0);
            this.PaymentSumLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PaymentSumLbl.Name = "PaymentSumLbl";
            this.PaymentSumLbl.Size = new System.Drawing.Size(81, 13);
            this.PaymentSumLbl.TabIndex = 0;
            this.PaymentSumLbl.Text = "Сумма оплаты";
            // 
            // PaymentPnl
            // 
            this.PaymentPnl.Controls.Add(this.PaymentSumPnl);
            this.PaymentPnl.Controls.Add(this.PaymentTypePnl);
            this.PaymentPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentPnl.Location = new System.Drawing.Point(0, 99);
            this.PaymentPnl.Name = "PaymentPnl";
            this.PaymentPnl.Size = new System.Drawing.Size(333, 37);
            this.PaymentPnl.TabIndex = 9;
            // 
            // ButtonsPnl
            // 
            this.ButtonsPnl.Controls.Add(this.Ok);
            this.ButtonsPnl.Controls.Add(this.Cancel);
            this.ButtonsPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPnl.Location = new System.Drawing.Point(0, 165);
            this.ButtonsPnl.Name = "ButtonsPnl";
            this.ButtonsPnl.Size = new System.Drawing.Size(333, 30);
            this.ButtonsPnl.TabIndex = 10;
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ok.Location = new System.Drawing.Point(183, 0);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 30);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Сохранить";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Location = new System.Drawing.Point(258, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 30);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 195);
            this.Controls.Add(this.ButtonsPnl);
            this.Controls.Add(this.PaymentPnl);
            this.Controls.Add(this.FirstNamePnl);
            this.Controls.Add(this.MiddleNamePnl);
            this.Controls.Add(this.LastNamePnl);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            this.LastNamePnl.ResumeLayout(false);
            this.LastNamePnl.PerformLayout();
            this.FirstNamePnl.ResumeLayout(false);
            this.FirstNamePnl.PerformLayout();
            this.MiddleNamePnl.ResumeLayout(false);
            this.MiddleNamePnl.PerformLayout();
            this.PaymentTypePnl.ResumeLayout(false);
            this.PaymentTypePnl.PerformLayout();
            this.PaymentSumPnl.ResumeLayout(false);
            this.PaymentSumPnl.PerformLayout();
            this.PaymentPnl.ResumeLayout(false);
            this.ButtonsPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Panel LastNamePnl;
        private System.Windows.Forms.Panel FirstNamePnl;
        private System.Windows.Forms.Panel MiddleNamePnl;
        private System.Windows.Forms.Panel PaymentTypePnl;
        private System.Windows.Forms.Label PaymentTypeLbl;
        private System.Windows.Forms.Panel PaymentSumPnl;
        private System.Windows.Forms.Label PaymentSumLbl;
        private System.Windows.Forms.Panel PaymentPnl;
        private System.Windows.Forms.Panel ButtonsPnl;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox MiddleNameTextBox;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox PaymentSumTxtBx;
    }
}