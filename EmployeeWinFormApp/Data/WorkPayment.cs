// <copyright file="WorkPayment.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System.Collections.Generic;
using EmployeeWinFormApp.BaseClasses;

namespace EmployeeWinFormApp.Data
{
    public class WorkPayment
    {
        private readonly EmployeesSource _employeesSource;

        public WorkPayment(EmployeesSource source)
        {
            this._employeesSource = source;
        }

        public Dictionary<Employee, int> EmployeesWorkPayment(int month)
        {
            Dictionary<Employee, int> result = new Dictionary<Employee, int>();
            foreach (var item in this._employeesSource.Source)
            {
                var employee = item as Employee;
                if (employee == null) continue;

                result.Add(employee, employee.WorkPayment(month));
            }

            return result;
        }

    }
}