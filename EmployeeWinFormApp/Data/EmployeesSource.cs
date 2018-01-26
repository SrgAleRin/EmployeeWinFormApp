// <copyright file="EmployeesSource.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EmployeeWinFormApp.BaseClasses;

namespace EmployeeWinFormApp.Data
{
    public class EmployeesSource
    {
        private readonly BindingList<Employee> _employees = new BindingList<Employee>();
        private readonly DataBaseOperations _db = new DataBaseOperations();

        public EmployeesSource()
        {
            this.Source = new BindingSource(this._employees, null);
        }

        public BindingSource Source { get; private set; }

        public Employee GetById(int id)
        {
            return this._employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(string last, string first, string middle, TypeOfPayment payment, int sum)
        {
            Employee result = new Employee();
            result.FirstName = first;
            result.LastName = last;
            result.MiddleName = middle;
            result.PaymentTypeId = payment;
            result.PaymentSum = sum;
            this._employees.Add(result);
            this._db.AddEmployee(result);
        }

        public void Delete(int id)
        {
            var item = this._employees.First(e => e.Id == id);
            this._employees.Remove(item);
            this._db.DeleteEmployee(item);
        }

        public void Refresh()
        {
            this._employees.Clear();
            var items = this._db.GetEmployees();
            foreach (Employee item in items)
            {
                this._employees.Add(item);
            }
        }

        public List<PaymentTypes> Payments
        {
            get
            {
                var payments = this._db.GetPayments();
                return payments.Select(p => new PaymentTypes {Id = p.Key, Description = p.Value}).ToList();
            }
        }

    }
}