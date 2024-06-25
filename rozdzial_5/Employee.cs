using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rozdzial_5
{
    class Employee
    // wprowadź do konstruktora pola First i LastName
    {
        public const int StartId = 100;
        public readonly int EmployeeId;
        public string FirstName;
        public string LastName;
        public Employee(int id, string Fname,string LName)
        {
            EmployeeId = id;
            FirstName = Fname;
            LastName = LName;
        }
        // public string GetEmployeeName()
        // {
        //     return $"{FirstName} {LastName}";
        // }
        public string GetEmployeeName() => $"{FirstName} {LastName}";
    }
}