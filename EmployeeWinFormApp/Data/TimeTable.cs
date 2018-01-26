// <copyright file="TimeTable.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System.Collections.Generic;
using EmployeeWinFormApp.BaseClasses;

namespace EmployeeWinFormApp.Data
{
    public class TimeTable
    {
        private readonly Employee _employee;
        private readonly int _month;

        public TimeTable(Employee employee, int month)
        {
            this._employee = employee;
            this._month = month;
        }

        public string Name
        {
            get
            {
                return string.Format("{0} {1} {2}", this._employee.LastName, this._employee.FirstName,
                    this._employee.MiddleName);
            }
        }

        public int PaymentSum
        {
            get { return this._employee.WorkPayment(this._month); }
        }

        public List<DayWithWorkFlag> DaysOfMonth
        {
            get { return this._employee.EmployeeCalendar.GetAllDays(this._month); }
        }
    }
}