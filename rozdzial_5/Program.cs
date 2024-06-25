using System;

namespace rozdzial_5
{
class Program {
    static void Main(string[] args) 
    {
       Employee obj1 = new Employee();
       obj1.EmployeeId = 1;
       obj1.FirstName = "Jan";
       obj1.LastName = "Kowalski";
       Console.WriteLine(obj1.FirstName);
    }
}
}