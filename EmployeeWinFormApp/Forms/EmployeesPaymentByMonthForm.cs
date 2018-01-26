// <copyright file="EmployeesPaymentByMonthForm.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeWinFormApp.BaseClasses;
using EmployeeWinFormApp.Data;

namespace EmployeeWinFormApp.Forms
{
    public partial class EmployeesPaymentByMonthForm : Form
    {
        private WorkPayment _workPayment;

        public EmployeesPaymentByMonthForm()
        {
            this.InitializeComponent();
        }

        public EmployeesSource Source { get; set; }

        public WorkPayment WorkPayment
        {
            get
            {
                if (this._workPayment != null) return this._workPayment;
                this._workPayment = new WorkPayment(this.Source);
                return this._workPayment;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1) return;
            this.listView1.Items.Clear();

            foreach (KeyValuePair<Employee, int> pair in 
                this.WorkPayment.EmployeesWorkPayment(this.comboBox1.SelectedIndex+1))
            {
                var item = new ListViewItem();
                item.Text = pair.Key.LastName;
                //item.SubItems.Add(pair.Key.LastName);
                item.SubItems.Add(pair.Value.ToString());
                this.listView1.Items.Add(item);
            }
        }
    }
}
