﻿using System;

namespace rozdzial_5
{
class Program {
    static void Main(string[] args) 
    {
       Employee obj1 = new Employee(1,"Jan","Kowalski");
       Console.WriteLine(obj1.FirstName);
       string fullName = obj1.GetEmployeeName();
       Console.WriteLine($"Imię i nazwisko: {fullName} ");
       Console.WriteLine("ID pracownika obj1: {0}", obj1.EmployeeId);
    }
}
}