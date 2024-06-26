using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rozdzial_5
{
    class Employee
    {
        public const int StartId = 100;
        private int employeeId;
        private string firstName;
        private string lastName;
        public string stanowisko {get;set;} = "pracownik";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("ID musi być większe od 1");
                employeeId = value;
            }
        }


        public Employee(int id, string Fname, string LName)
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
         public string GetEmployeeComplete() => $"{FirstName} {LastName} - {stanowisko}";
    }
}