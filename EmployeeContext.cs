using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstMigrationPOC
{
    public class EmployeeContext :  DbContext  
    {  
        public DbSet<Employee> Employees { get; set; }
    }

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmpName { get; set; }
    public string Role { get; set; }
    }  
}  

   