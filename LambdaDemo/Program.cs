using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample employee data
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John", Department = "HR", Salary = 40000 },
                new Employee { Id = 2, Name = "Jane", Department = "IT", Salary = 60000 },
                new Employee { Id = 3, Name = "Steve", Department = "Finance", Salary = 45000 },
                new Employee { Id = 4, Name = "Anna", Department = "IT", Salary = 70000 },
                new Employee { Id = 5, Name = "Mike", Department = "HR", Salary = 38000 }
            };

            // Using lambda to filter and select employees from IT department
            var itEmployees = employees
                .Where(emp => emp.Department == "IT")
                .Select(emp => new { emp.Name, emp.Salary });

            // Display the result
            Console.WriteLine("IT Department Employees:");
            foreach (var emp in itEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }

            // Calculate total salary of IT department using lambda
            double totalItSalary = employees
                .Where(emp => emp.Department == "IT")
                .Sum(emp => emp.Salary);

            Console.WriteLine($"\nTotal IT Department Salary: {totalItSalary}");

            // Sorting employees by salary using lambda
            var sortedEmployees = employees
                .OrderBy(emp => emp.Salary)
                .ToList();

            Console.WriteLine("\nEmployees sorted by Salary:");
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}
