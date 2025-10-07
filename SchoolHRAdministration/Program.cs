using HRAdministrationAPI;
using System;

namespace HRAdministration {     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void seedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Marley",
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Thomas",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Joesph",
                LastName = "Stalin",
                Salary = 100000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Harey",
                LastName = "Styles",
                Salary = 50000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Taylor",
                LastName = "Swift",
                Salary = 200000
            };
            employees.Add(headMaster);
        }
    }

    public class Teacher: EmployeeBase
    {

    }

    public class HeadOfDepartment : EmployeeBase
    {

    }

    public class DeputyHeadMaster: EmployeeBase
    {

    }

    public class HeadMaster: EmployeeBase
    {

    }

}