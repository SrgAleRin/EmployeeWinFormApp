// <copyright file="MainForm.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System;
using System.Windows.Forms;
using EmployeeWinFormApp.BaseClasses;
using EmployeeWinFormApp.Data;

namespace EmployeeWinFormApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly EmployeesSource _employees;

        public MainForm()
        {
            this.InitializeComponent();
            this._employees = new EmployeesSource();
            this._employees.Refresh();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = this._employees.Source;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (NewEmployeeForm frm = new NewEmployeeForm())
            {
                frm.comboBox1.DataSource = this._employees.Payments;
                frm.comboBox1.SelectedIndex = 0;
                var result = frm.ShowDialog();
                if (result != DialogResult.OK) return;

                this._employees.Add(frm.LastNameTextBox.Text, frm.FirstNameTextBox.Text, frm.MiddleNameTextBox.Text,
                    ((PaymentTypes) frm.comboBox1.SelectedItem).Id, Int32.Parse(frm.PaymentSumTxtBx.Text));
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView1.CurrentRow;
            if (row == null) return;
            var cellData = this.dataGridView1["Id", row.Index];
            int item = (int)cellData.Value;
            this._employees.Delete(item);
        }

        private void MonthPaymentSum_Click(object sender, EventArgs e)
        {
            using (EmployeesPaymentByMonthForm frm = new EmployeesPaymentByMonthForm())
            {
                frm.Source = this._employees;
                frm.comboBox1.SelectedIndex = 0;
                frm.ShowDialog();
            }
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView1.CurrentRow;
            if (row == null) return;
            var cellData = this.dataGridView1["Id", row.Index];
            int item = (int)cellData.Value;
            var current = this._employees.GetById(item);
            if (current == null) return;

            using (TimeTableForm frm = new TimeTableForm())
            {
                frm.CurrentEmployee = current;
                frm.comboBox1.SelectedIndex = 0;
                frm.ShowDialog();
            }
        }
    }
}
