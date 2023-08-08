using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Threading;

namespace CSharpTasks
{
    internal class EmployeeReport
    {
        //public string empName;
        //public int empId;
        //public int empAge;
        //public int empSalary;
        public string? empName {get; set;}
        public int? empId { get; set; }
        public int? empAge { get; set; }
        public int? empSalary { get; set; }

        //public EmployeeReport(string empName, int empAge, int empId, int empSalary)
        //{
        //    this.empName = empName;
        //    this.empId = empId;
        //    this.empAge = empAge;
        //    this.empSalary = empSalary;

        //}
        static public void WriteCSVReport()
        {
            string empName;
            int empId;
            int empAge;
            int empSalary;
            //    EmployeeReport[] employees = {
            //    new EmployeeReport("Srikanth",22,01,22000),
            //    new EmployeeReport("Arun",23,03,22000),

            //};
            List<EmployeeReport> empReports=new List<EmployeeReport>();
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Enter the emp Details...");
                Console.WriteLine("Emp Name:");
                empName = Console.ReadLine();
                Console.WriteLine("Emp ID");
                empId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emp Age:");
                empAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emp Salary");
                empSalary = Convert.ToInt32(Console.ReadLine());
                empReports.Add(new EmployeeReport { empName = empName, empAge = empAge, empId = empId, empSalary = empSalary });
                  
               
            }
            string fileName = @"D:\Tasks\emp.csv";
            StringBuilder sb = new StringBuilder();
            string separator = ",";
            String[] heading = { "empName", "empAge", "empId", "empSalary" };
            sb.AppendLine(string.Join(separator, heading));
            foreach (EmployeeReport emp in empReports)
            {
                string line = string.Format("{0},{1},{2},{3}", emp.empName, emp.empAge, emp.empId, emp.empSalary);
                sb.AppendLine(string.Join(separator, line));
            }

            try
            {
                File.AppendAllText(fileName, sb.ToString());
                Console.WriteLine("File Written Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
#nullable enable
        static float calcBonus (int? sal)
        {
            if (sal > 1000 && sal < 5000)
            {
                return 500;
            }
            else if (sal >= 5000 && sal <= 10000)
            {
                return 1000;
            }
            else if (sal >= 10000 && sal <= 15000)
            {
                return 1500;
            }
            else
            {
                return 2000;
            }
            // return 0;
        }
        static public void ReadCsvReport()
        {
            using var contents = new StreamReader(@"D:\Tasks\emp.csv");
            using var csv = new CsvReader(contents,CultureInfo.InvariantCulture);
            var records = csv.GetRecords<EmployeeReport>();

            foreach (var emp in records)
            {
                float bonus = calcBonus(emp.empSalary);
                Console.WriteLine($"{emp.empName,-15}{emp.empAge,-10} {emp.empId,-10} {emp.empSalary} {bonus,-10}");
            }
        }
       
        static void Main(string[] args)
        {
            EmployeeReport.WriteCSVReport();
            Thread.Sleep(2000);
            EmployeeReport.ReadCsvReport();
        }
    }
}
