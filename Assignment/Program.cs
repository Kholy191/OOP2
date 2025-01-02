using System.Security;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
            //WeekDays Day = WeekDays.Monday;

            //for (int i = 0; i < 7; i++)
            //{
            //    Day = (WeekDays)i;
            //    Console.WriteLine(Day);
            //}
            #endregion


        }
    }

    #region Q1
    public enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion




}

