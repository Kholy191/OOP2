﻿using System.Security;
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

            #region Q3 Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Season season1 = Season.Autumn;
            //Boolean Flag = Enum.TryParse<Season>(Console.ReadLine(), true, out season1);
            //if (Flag == true)
            //{
            //    switch ((int)season1)
            //    {
            //        case 0:
            //            Console.WriteLine("spring march to may");
            //            break;
            //        case 1:
            //            Console.WriteLine(" summer june to august");
            //            break;
            //        case 2:
            //            Console.WriteLine("autumn September to November");
            //            break;
            //        case 3:
            //            Console.WriteLine("winter December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}
            #endregion


            #region Q4 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permissions_ MyPremission = Permissions_.None;
            ///*For Adding*/
            //MyPremission |= Permissions_.Execute;
            //Console.WriteLine(MyPremission);
            ///*For Removing*/
            //MyPremission &= ~Permissions_.Read;
            ///* is existed */
            //bool isExisted = (MyPremission & Permissions_.Execute) == Permissions_.Execute;
            //Console.WriteLine(isExisted);
            #endregion


            #region Q5 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //PrimaryColors Colur1 = PrimaryColors.None;
            //Boolean Flag = Enum.TryParse<PrimaryColors>(Console.ReadLine(), true, out Colur1);
            //if (Flag == true)
            //{
            //    Console.WriteLine("Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary Color");
            //}
            #endregion

            #region Q6 Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p1 = new Point(1,3);
            //Point p2 = new Point(5,3);
            //double distance = p1.GetDistance(p2);
            //Console.WriteLine(distance);
            #endregion

            #region Q7 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //PersonQ7[] pesrsons = new PersonQ7[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter Age of person");
            //    int.TryParse(Console.ReadLine(), out int Num);
            //    Console.WriteLine("Enter Name of person");
            //    pesrsons[i] = new PersonQ7(Console.ReadLine() ?? "", Num);
            //}
            //pesrsons[0].OldestPerson(pesrsons[1], pesrsons[2]);
            #endregion

            #region Q1 part 2 Design and implement a Class for the employees in a company:
            //Employee.Hiring_Date hireDate1 = new Employee.Hiring_Date(12, 5, 2015);
            //Employee.Hiring_Date hireDate2 = new Employee.Hiring_Date(2, 3, 2018);
            //Employee.Hiring_Date hireDate3 = new Employee.Hiring_Date(10, 8, 2020);

            //// Creating Employee objects
            //Employee emp1 = new Employee(1, "Ahmed", Employee.Gender.M, 55000, hireDate1, Employee.Security.DBA);
            //Employee emp2 = new Employee(2, "Mahmoud", Employee.Gender.M, 40000, hireDate2, Employee.Security.Guest);
            //Employee emp3 = new Employee(3, "Ali", Employee.Gender.M, 70000, hireDate3, Employee.Security.SecurityOfficer);

            //// Array of Employees
            //Employee[] EmpArr = new Employee[] { emp1, emp2, emp3 };

            //// Displaying all employees in the array
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp.ToString());
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

    #region Q3
    public enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    #endregion

    #region Q4 Q4
    //[Flags]
    //public enum Permissions_
    //{
    //    None, Read, write, Delete, Execute
    //}
    #endregion


    #region Q5 
    public enum PrimaryColors
    {
        None, Red, Green, Blue
    }
    #endregion

    #region Q6 
    public struct Point
    {
        private double X;
        private double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetDistance(Point p)
        {
            double dx = p.X - X;
            double dy = p.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    #endregion

    #region Q7
    public struct PersonQ7
    {
        private string Name;
        private int Age;

        public PersonQ7(string str, int Num)
        {
            Name = str;
            Age = Num;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
        public void OldestPerson(PersonQ7 P1, PersonQ7 P2)
        {
            PersonQ7 oldest = this;

            if (P1.Age > oldest.Age)
            {
                oldest = P1;
            }

            if (P2.Age > oldest.Age)
            {
                oldest = P2;
            }

            Console.WriteLine($"Oldest Person: {oldest}");
        }
    }
    #endregion

    #region Q1 part 2
    public class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private Security Securitylevel { get; set; }
        private int Salary { get; set; }
        private Hiring_Date HireDate { get; set; }
        private Gender gender { get; set; }

        public Employee(int id, string name, Gender gend, int salary, Hiring_Date hiredate, Security secure)
        {
            Id = id;
            Name = name;
            Securitylevel = secure;
            Salary = salary;
            HireDate = hiredate;
            gender = gend;

        }

        #region  Q2 Develop a Class to represent the Hiring Date Data:
        public class Hiring_Date
        {
            int Day { get; set; }
            int Month { get; set; }
            int Year { get; set; }
            public Hiring_Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"day {Day} , month : {Month} , year :{Year}";
            }
        }
        #endregion

        #region Q3 We need to restrict the Gender field to be only M or F [Male or Female] 
        public enum Gender
        {
            M, F
        }
        #endregion

        #region Q4 Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        public enum Security
        {
            Guest, Developer, secretary, DBA, SecurityOfficer
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {gender}, Salary: {String.Format("{0:C}", Salary)} Hire Date: {HireDate.ToString()}, Security Level: {Securitylevel}";
        }
        #endregion
    }
    #endregion





}

