// <copyright file="DataBaseOperations.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using EmployeeWinFormApp.BaseClasses;

namespace EmployeeWinFormApp.Data
{
    public class DataBaseOperations
    {
        private string _connectionString;

        private string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(this._connectionString))
                {
                    var connectionSettings = ConfigurationManager.ConnectionStrings["EmployeeWinFormApp.Properties.Settings.TestDataBaseConnectionString"];
                    if (connectionSettings != null)
                    {
                        this._connectionString = connectionSettings.ConnectionString;
                    }
                }

                return this._connectionString;
            }
        }

        public Dictionary<TypeOfPayment, string> GetPayments()
        {
            Dictionary<TypeOfPayment, string> result = new Dictionary<TypeOfPayment, string>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("select [Id], [Name] from PaymentType;", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add((TypeOfPayment)reader.GetInt32(0), reader[1].ToString());
                        }
                    }
                }
            }

            return result;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("select [LastName], [FirstName], [MiddleName], [PaymentSum], [PaymentTypeId], [Id] from Employees;", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Employee();
                            item.LastName = reader[0].ToString();
                            item.FirstName = reader[1].ToString();
                            item.MiddleName = reader[2].ToString();
                            item.PaymentSum = reader.GetInt32(3);
                            item.PaymentTypeId = (TypeOfPayment)reader.GetInt32(4);
                            item.Id = reader.GetInt32(5);
                            result.Add(item);
                        }
                    }
                }
            }

            return result;
        }

        public void AddEmployee(Employee item)
        {
            item.Id = this.DoIntCommand(string.Format("insert into Employees ([LastName], [FirstName], [MiddleName], [PaymentSum], [PaymentTypeId]) values (N'{0}', N'{1}', N'{2}', {3}, {4});" +
                                                      " select max(id) from Employees;",
                item.LastName, item.FirstName, item.MiddleName, item.PaymentSum, (int)item.PaymentTypeId));
        }

        public void UpdateEmployee(Employee item)
        {
            this.DoIntCommand("");
        }

        public void DeleteEmployee(Employee item)
        {
            this.DoIntCommand(string.Format("delete from Employees where Id = {0}", item.Id));
        }

        private int DoIntCommand(string text)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(text, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null) return (int) result;
                    return 0;
                }
            }
        }
    }
}