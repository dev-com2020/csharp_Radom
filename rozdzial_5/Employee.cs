using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rozdzial_5
{
    class Employee
    {
        public const int StartId = 100;
        public readonly int EmployeeId;
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get {return FirstName;}
            set { firstName = value;}
        }
                public string LastName
        {
            get {return LastName;}
            set { lastName = value;}
        }


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