using Data;
using System;
using System.Collections.Generic;

namespace DebugSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GatherEmployeeData();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }

        public static void GatherEmployeeData()
        {
            try
            {

                var employeeData = new Data.Data().EmployeeData;

                foreach (var employee in employeeData)
                {
                    var employeeDetail = new Employee()
                    {
                        Name = employee.Name.ToUpper(),
                        Surname = employee.Surname.ToUpper(),
                        DOB = employee.DOB,
                        Address = employee.Address.Trim(),
                        Department = employee.Department.ToUpper(),
                        Education = employee.Education.Trim(),
                        YearsOfExperience = employee.YearsOfExperience
                    };
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw ex;
            }
        }
    }
}
