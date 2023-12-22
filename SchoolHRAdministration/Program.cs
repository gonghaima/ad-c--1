using System;
using HRAdministrationAPI;
namespace SchoolHRAdministration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher { Id = 1, FirstName = "Bob", LastName = "Fisher", Salary = 4000 };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher { Id = 2, FirstName = "Jenny", LastName = "Thomas", Salary = 40000 };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment { Id = 3, FirstName = "Brenda", LastName = "Mullins", Salary = 50000 };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster { Id = 4, FirstName = "Devlin", LastName = "Brown", Salary = 60000 };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster { Id = 5, FirstName = "Damien", LastName = "Jones", Salary = 80000 };
            employees.Add(headMaster);
        }

    }
    public class Teacher : EmployeeBase
    {


    }

    public class HeadOfDepartment : EmployeeBase
    {

    }

    public class DeputyHeadMaster : EmployeeBase
    {

    }

    public class HeadMaster : EmployeeBase
    {

    }
}
