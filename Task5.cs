using AccessDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Product
    {
        public string productName;
        public int productCode;
        public string productDescription;

    }
    internal class Task5
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
        {
           new Product{productName="Watch", productCode=001,productDescription="Good smart Watch" },
           new Product{productName="Mobile", productCode=002,productDescription="Smart Phone"},
           new Product{productName="Zike",productCode=003, productDescription="New model bike"}
        };
            Console.WriteLine($"Iterating in descending order.....");
            var sortedProducts = products.OrderByDescending(name => name.productName);
            // var sortedProducts = from s in products orderby s.productName descending select s;
            foreach (var val in sortedProducts)
            {
                Console.WriteLine(val.productName);

            }

            Console.WriteLine("Retrieving any two properties from list");

            var firstChar = products.Select(x => new { x.productName, x.productCode });
            foreach (var val in products)
            {
                Console.WriteLine(val.productName + "\t" + val.productCode);
            }
            Console.WriteLine("Retrieving First Character from products");
            var firstchar = products.Select(s => s.productName[0]);
            foreach (var val in firstchar)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Simple Interest Calculation...........");
            var simpleInterest = (int amount, decimal interest, int years) =>
            {
                return amount * interest * years / 100;
            };
            int pamount, years;
            decimal interest;
            Console.WriteLine("Enter the Principle Amount:");
            pamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Interest:");
            interest = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the No of years:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The simple interest Is:{simpleInterest(pamount, interest, years)}");
            Console.WriteLine("Virtual vs New");
            Console.WriteLine("calling methods with base reference HR");
            HR hr = new HR();
            hr.empname = "Srikanth";
            hr.empid = 1;
            hr.salary = 7327233;
            hr.showSalary();
            Console.WriteLine("For Emp Reference");
            Employee emp = hr;
            emp.showSalary();
            Console.WriteLine("Interfaces");
            ICircle circle = new CalculateArea() { radius = 23465 };
            IRectangle rectangle = new CalculateArea() { length = 635, width = 737 };
            circle.Area();
            rectangle.Area();
        }
    }

    internal class Employee
    {
        public string empname;
        public int empid;
        public decimal salary;
        // public virtual string showSalary() =>$"empName:{empname} empId:{empid} empSalary:{salary}";
        //public virtual void showSalary()
        //{
        //    Console.WriteLine($"The employee with id:{this.empid}, name:{this.empname} and salary:{salary}");
        //}
        public void showSalary()
        {
            Console.WriteLine($"The employee with id:{this.empid}, name:{this.empname} and salary:{salary}");
        }

    }

    internal class HR : Employee
    {
        public decimal bonus;
        // public override string showSalary() => $"empName:{empname} empId:{empid} empSalary:{salary} empBonus:{(decimal)10/100*salary}";
        //public override void showSalary()

        //{
        //    Console.WriteLine($"The employee with id:{this.empid}, name:{this.empname} , salary:{salary} and bonus {(decimal)10 / 100 * salary}");
        //}
        public new void showSalary()
        {
            bonus = (decimal)10 / 100 * salary;
            Console.WriteLine($"The employee with id:{this.empid}, name:{this.empname} , salary:{salary} and bonus {bonus}");
        }
    }

    interface ICircle
    {
        public decimal radius { get; set; }

        public void Area();
    }
    interface IRectangle
    {
        public decimal width { get; set; }
        public decimal length { get; set; }
        public void Area();
    }
    public class CalculateArea : ICircle, IRectangle
    {
        public decimal radius { get; set; }
        public decimal width { get; set; }
        public decimal length { get; set; }
        void ICircle.Area()
        {
            Console.WriteLine($"The area of the circle is {3.14m * radius * radius}");
        }
        void IRectangle.Area()
        {
            Console.WriteLine($"The area of the rectangle is {width * length}");
        }
    }
}
