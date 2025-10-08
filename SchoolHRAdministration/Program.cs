using HRAdministrationAPI;
using System;
using System.Linq;


namespace HRAdministration {     

    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster
    }

    public static class EmployeeFactory
    {
        public static IEmployee? GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary )
        {
            IEmployee? employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPatter<IEmployee, Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPatter<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPatter<IEmployee, DeputyHeadMaster>.GetInstance();
                    break;
                case EmployeeType.HeadMaster:
                    employee = FactoryPatter<IEmployee, HeadMaster>.GetInstance();
                    break;
                default:
                    break;
            }

            if(employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }

            return employee;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();

            seedData(employees);

            // decimal totalSalaries = 0;

            // foreach(IEmployee employee in employees)
            // {
            //     totalSalaries += employee.Salary;
            // }
            // Console.WriteLine(totalSalaries);

            Console.WriteLine(employees.Sum(e => e.Salary));

             Console.ReadKey();
        }

        public static void seedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob","Marley",40000);
            employees.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Thomas", 40000);
            employees.Add(teacher2);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Joesph", "Stalin", 100000);
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Harry", "Styles", 50000);
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Taylor","Swift", 200000);
            employees.Add(headMaster);
        }
    }

    public class Teacher: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }

    }

    public class DeputyHeadMaster: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }

    }

    public class HeadMaster: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

    }

}