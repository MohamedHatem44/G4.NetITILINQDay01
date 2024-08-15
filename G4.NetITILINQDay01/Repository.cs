using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITILINQDay01
{
    public class Repository
    {
        /*----------------------------------------------------------------------------------*/
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id = 1, Name = "Mohamed", Age = 22, Salary = 1234, DeptId = 1 },
                new Employee{Id = 2, Name = "Ahmed", Age = 32, Salary = 2234, DeptId = 2 },
                new Employee{Id = 3, Name = "Ali", Age = 42, Salary = 3234, DeptId = 3 },
                new Employee{Id = 4, Name = "Omar", Age = 52, Salary = 4234, DeptId = 1 },
                new Employee{Id = 5, Name = "Mostafa", Age = 28, Salary = 5234, DeptId = 2 },
                new Employee{Id = 6, Name = "Mai", Age = 38, Salary = 6234, DeptId = 3 },
                new Employee{Id = 7, Name = "Sara", Age = 48, Salary = 7234, DeptId = 1 },
                new Employee{Id = 8, Name = "Osama", Age = 26, Salary = 8234, DeptId = 2 },
                new Employee{Id = 9, Name = "Ramy", Age = 36, Salary = 9234, DeptId = 3 },
                new Employee{Id = 10, Name = "Nour", Age = 46, Salary = 10234, DeptId = 1 }
            };
        }
        /*----------------------------------------------------------------------------------*/
        public static List<Department> GetDepartments()
        {
            return new List<Department>()
            {
                new Department{DeptId = 1, DeptName = "HR" },
                new Department{DeptId = 2, DeptName = "PR" },
                new Department{DeptId = 3, DeptName = "Social Media" },
                new Department{DeptId = 4, DeptName = "Finance" },
            };
        }
        /*----------------------------------------------------------------------------------*/
    }
}
