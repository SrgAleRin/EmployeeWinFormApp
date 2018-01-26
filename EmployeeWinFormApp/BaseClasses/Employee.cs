using System;
using EmployeeWinFormApp.Data;

namespace EmployeeWinFormApp.BaseClasses
{
    /// <summary>
    /// класс работник
    /// </summary>
    public class Employee
    {
        public Employee()
        {
            this.EmployeeCalendar = new Calendar();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// отчество
        /// </summary>
        public string MiddleName { get; set; }

        public TypeOfPayment PaymentTypeId { get; set; }

        /// <summary>
        /// тип оплаты
        /// </summary>
        public string PaymentType {
            get
            {
                switch (this.PaymentTypeId)
                {
                    case TypeOfPayment.ByHour:
                        return "Почасовая";
                        break;
                    case TypeOfPayment.ByDay:
                        return "Дневная";
                        break;
                    case TypeOfPayment.ByMonth:
                        return "Месячная";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// сумма оплаты
        /// </summary>
        public int PaymentSum { get; set; }

        public Calendar EmployeeCalendar { get; private set; }

        public int WorkPayment(int month)
        {
            int workPayment = 0;

            switch (this.PaymentTypeId)
            {
                case TypeOfPayment.ByHour:
                    workPayment = this.EmployeeCalendar.GetCountOfWorkHours(month) * this.PaymentSum;
                    break;
                case TypeOfPayment.ByDay:
                    workPayment = this.EmployeeCalendar.GetCountOfWorkDays(month) * this.PaymentSum;
                    break;
                case TypeOfPayment.ByMonth:
                    workPayment = this.PaymentSum;
                    break;
            }

            return workPayment;
        }
    }
}