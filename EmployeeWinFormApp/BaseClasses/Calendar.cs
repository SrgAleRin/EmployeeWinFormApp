// <copyright file="Calendar.cs" company="LANIT">
// 
//     Copyright (c) LAboratory of New Information Technologies. All rights reserved. 2018
// 
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeWinFormApp.BaseClasses
{
    public class Calendar
    {
        public const int Year = 2018;
        private const int WorkHoursInDay = 8;

        private readonly Dictionary<int, List<DayWithWorkFlag>> _workDaysOfMonth =
            new Dictionary<int, List<DayWithWorkFlag>>();

        public Calendar()
        {
            for (int i = 1; i <= 12; i++)
            {
                this._workDaysOfMonth.Add(i, this.GetAllDaysWithWorkFlag(i));
            }
        }

        public List<DayWithWorkFlag> GetAllDays(int month)
        {
            return this._workDaysOfMonth[month];
        }

        public int GetCountOfWorkDays(int month)
        {
            return this._workDaysOfMonth[month].Count(d => d.IsWorkDay);
        }

        public int GetCountOfWorkHours(int month)
        {
            return this._workDaysOfMonth[month].Count(d => d.IsWorkDay) * WorkHoursInDay;
        }

        public List<int> GetWorkDays(int month)
        {
            return this._workDaysOfMonth[month].Where(d => d.IsWorkDay).Select(d => d.Day).ToList();
        }

        public void ChangeDayFlag(int month, int day)
        {
            List<DayWithWorkFlag> days = this._workDaysOfMonth[month];
            foreach (DayWithWorkFlag dayWithWorkFlag in days.Where(d => d.Day == day))
            {
                dayWithWorkFlag.IsWorkDay = !dayWithWorkFlag.IsWorkDay;
            }
        }

        private List<DayWithWorkFlag> GetAllDaysWithWorkFlag(int month)
        {
            List<DayWithWorkFlag> allDays = new List<DayWithWorkFlag>();
            int daysInMonth = DateTime.DaysInMonth(Year, month);
            DateTime currentDay = new DateTime(Year, month, 1);
            DateTime lastDay = new DateTime(Year, month, daysInMonth);

            while (currentDay <= lastDay)
            {
                DayWithWorkFlag day = new DayWithWorkFlag(currentDay.Day);
                if (currentDay.DayOfWeek != DayOfWeek.Saturday &&
                    currentDay.DayOfWeek != DayOfWeek.Sunday &&
                    !CelebrationDays.IsCelebrateDay(currentDay))
                    day.IsWorkDay = true;
                allDays.Add(day);
                currentDay = currentDay.AddDays(1);
            }

            return allDays;
        }

        private static class CelebrationDays
        {
            private static readonly Dictionary<int, List<int>> celebrations = new Dictionary<int, List<int>>
            {
                { 1, new List<int>{1,2,3,4,5,6,7,8,9} },
                { 2, new List<int>{23} },
                { 3, new List<int>{8} },
                { 5, new List<int>{1,2,9} }
            };

            public static bool IsCelebrateDay(DateTime data)
            {
                if (!celebrations.ContainsKey(data.Month)) return false;
                if (!celebrations[data.Month].Contains(data.Day)) return false;
                return true;
            }
        }
    }

    public class DayWithWorkFlag
    {
        public DayWithWorkFlag(int day, bool flag = false)
        {
            this.Day = day;
            this.IsWorkDay = flag;
        }

        public int Day { get; set; }
        public bool IsWorkDay { get; set; }
    }
}