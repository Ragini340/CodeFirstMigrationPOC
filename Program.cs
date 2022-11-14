using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMigrationPOC
{
    class Program
    {
        static void Main(string[] args) { 
        using (var context = new EmployeeContext())  
            {  
                //Insert values in database  
context.Employees.Add(new Employee { EmployeeID = 1, EmpName = "Ragini" });
context.Employees.Add(new Employee { EmployeeID = 2, EmpName = "R Singh" });
context.SaveChanges();

//Get all values from database  
foreach (var emp in context.Employees)
{
    Console.WriteLine("Employee ID : " + emp.EmployeeID);
    Console.WriteLine("Employee Name : " + emp.EmpName);
}  
}  
  
Console.WriteLine("Press Any key to exit....");
Console.ReadKey();  
        }  
    }  
} 