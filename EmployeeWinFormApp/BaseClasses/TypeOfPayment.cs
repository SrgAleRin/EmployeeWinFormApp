// <copyright file="TypeOfPayment.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

namespace EmployeeWinFormApp.BaseClasses
{
    /// <summary>
    /// тип оплаты – почасовая, дневная, месячная
    /// </summary>
    public enum TypeOfPayment
    {
        /// <summary>
        /// почасовая
        /// </summary>
        ByHour = 1,

        /// <summary>
        /// дневная
        /// </summary>
        ByDay = 2,

        /// <summary>
        /// месячная
        /// </summary>
        ByMonth = 3
    }

    public class PaymentTypes
    {
        public TypeOfPayment Id { get; set; }
        public string Description { get; set; }

        #region Overrides of Object

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return this.Description;
        }

        #endregion
    }
}