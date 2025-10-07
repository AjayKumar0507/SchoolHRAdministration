using HRAdministrationAPI;
using System;

namespace HRAdministration {     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to School HR Administration System");
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