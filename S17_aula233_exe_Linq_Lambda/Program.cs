using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace S17_aula233_exe_Linq_Lambda
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            try {
                using (StreamReader sr = File.OpenText(filePath)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee { Name = name, Email = email, Salary = salary });
                    }
                }
                Console.WriteLine("Email of people whose salary is more than 2000.00:");
                var result = employees.Where(x => x.Salary > 2000.0).OrderBy(x => x.Email).Select(x => x.Email);
                foreach (var employee in result) {
                    Console.WriteLine(employee);
                }
                var sum = employees.Where(x => x.Name.StartsWith("M"))
                    .Select(x => x.Salary)
                    .Aggregate(0.0, (x, y) => x + y);
                Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e) {
                Console.WriteLine("Error: " + e.Message); ;
            }
        }
    }
}
