﻿using System.ComponentModel;

namespace AssignmentOOP01
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            //1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday) 
           //as its members.Then, write a C# program that prints out all the days of the week using this enum.
            
                foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                {
                Console.WriteLine(day);
                }


            #endregion
        }
    }
}
