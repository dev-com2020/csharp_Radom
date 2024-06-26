using System;

namespace rozdzial_5
{
class Program {
    static void Main(string[] args) 
    {
       Employee obj1 = new Employee(1,"Jan","Kowalski");
       obj1.FirstName = "Tomek";
       string fullName = obj1.GetEmployeeName();
       string fullData = obj1.GetEmployeeComplete();
       Console.WriteLine($"Imię i nazwisko: {fullName} ");
       Console.WriteLine($"Dane osoby: {fullData} ");
       Console.WriteLine("ID pracownika obj1: {0}", obj1.EmployeeId);
    }
}
}