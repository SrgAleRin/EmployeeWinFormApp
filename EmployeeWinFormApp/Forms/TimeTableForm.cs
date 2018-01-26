// <copyright file="TimeTableForm.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeWinFormApp.BaseClasses;
using EmployeeWinFormApp.Data;

namespace EmployeeWinFormApp.Forms
{
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            this.InitializeComponent();
        }

        public Employee CurrentEmployee { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1) return;
            this.DoRefresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0) return;
            foreach (var item in this.listView1.SelectedItems)
            {
                int value;
                if (int.TryParse(((ListViewItem)item).Text, out value))
                    this.CurrentEmployee.EmployeeCalendar.ChangeDayFlag(this.comboBox1.SelectedIndex + 1, value);
            }
            this.DoRefresh();
        }

        private void DoRefresh()
        {
            this.listView1.Items.Clear();
            this.listView1.ShowItemToolTips = true;

            TimeTable tt = new TimeTable(this.CurrentEmployee, this.comboBox1.SelectedIndex + 1);

            foreach (DayWithWorkFlag day in tt.DaysOfMonth)
            {
                var item = new ListViewItem();
                item.Text = day.Day.ToString();
                if (!day.IsWorkDay)
                    item.BackColor = Color.Red;
                this.listView1.Items.Add(item);
            }

            var lastItem = new ListViewItem();
            lastItem.Text = string.Format("Всего за месяц заработано {0}", tt.PaymentSum);
            this.listView1.Items.Add(lastItem);
        }
    }
}
