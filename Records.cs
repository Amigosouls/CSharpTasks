using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public record Cars
    {
        public string companyName {get;set;}
        public string yearEst { get;set;}
    } 

    public record Alto : Cars
    {
        public string kerbWeight { get; set; }
        public int cylinderNo { get;set;}
        public int mileage { get;set;}
        public int pricce { get;set;}
    }
    public record Fronx : Cars
    {
        public string kerbWeight { get; set; }
        public int cylinderNo { get; set; }
        public int mileage { get; set; }
        public int pricce { get; set; }
    }
    public record struct EmpRecords
    {
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string department { get; set; }
        public int EmpSalary{ get; set; }
    }
    public class RecordsMain
    {
        public static void Main(string[] args)
        {
            var stu1 = new EmpRecords
            {
                EmpName = "Srikanth",
                EmpAge = 10,
                department = "Computer Science",
                EmpSalary = 4000
            };
            var updatedEmp = updateRecord(stu1);
            Console.WriteLine(updatedEmp);

            var car1 = new Alto
            {
                companyName = "Maruti",
                yearEst = "1996",
                cylinderNo = 3,
                kerbWeight = "860kg",
                mileage = 16,
                pricce = 249000
            };

            Console.WriteLine("Hierarchichal inheritance...............");
            Console.WriteLine("The Car details are....");
            Console.WriteLine($"Company name:{car1.companyName} \n Year Est:{car1.yearEst} \n Kerb Weight:{car1.kerbWeight} \n Cylinders:{car1.cylinderNo} \n Mileage:{car1.mileage} \n Price:{car1.pricce}");

        }

        public static EmpRecords updateRecord(EmpRecords records)
        {
            int bonus = 0;
            if(records.EmpSalary < 1000 && records.EmpSalary > 0)
            {
                bonus = 200;
            }
            else if (records.EmpSalary< 3000 && records.EmpSalary > 1000)
            {
                bonus = 400;
            }
            else if (records.EmpSalary < 5000 && records.EmpSalary > 3000)
            {
                bonus = 600;
            }
            else if (records.EmpSalary < 7000 && records.EmpSalary >5000)
            {
                bonus = 800;
            }
            else if (records.EmpSalary < 10000 && records.EmpSalary > 7000)
            {
                bonus = 1000;
            }

            var newRecord = records with { EmpSalary = records.EmpSalary+bonus };

            return newRecord;
        }
    }
}
