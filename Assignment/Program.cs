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

            #region Q2 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];
            //people[0] = new Person("Ahmed" , 25);
            //people[1] = new Person("Mahmoud", 33);
            //people[2] = new Person("Adel", 56);

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i].ToString());
            //}
            #endregion Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array. 



        }
    }

    #region Q1
    public enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion

    #region Q2
    public struct Person
    {
        private string Name;
        private int Age;

        public Person(string str, int Num)
        {
            Name = str;
            Age = Num;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
    #endregion




}

