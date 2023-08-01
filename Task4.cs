# define BUBBLESORT
# undef QUICK_SORT
# define WARNING
# undef ERROR
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpTasks
{
    public class Toys
    {
        public virtual void toyColor()
        {
            Console.WriteLine("The toy color is black");
        }
    }

    public class Toys1 : Toys { 
        sealed  override public void toyColor() {
            Console.WriteLine("The toy color is blue");
            
        }
       
    }

   //sealed public class Toys2 : Toys1
   // {
   //     public override void toyColor()
   //     {
   //         Console.WriteLine("Toy color is green");
   //     }
   // }

   // public class Toys3 : Toys2
   // {

   // }



    public abstract class Tax
    {
        protected string empName;
        protected int empAge;
        protected int empSalary;
        public double tax;
        public string Name
        {
            get { return empName; }
            set { empName = value; }
        }

        public int age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public int salary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }

        public abstract void calculateTax(int salary);
        public abstract void displayTax();
    }
    public class HighTax : Tax
    {
        public override void calculateTax(int salary)
        {
            this.tax = (15 * salary) / 100.0;

        }
        public override void displayTax()
        {
            Console.WriteLine($"The Employee with Name:{empName} and age:{empAge} has tax of {this.tax}");
        }
    }
    public class MediumTax : Tax
    {
        public override void calculateTax(int salary)
        {
            this.tax = (10 * salary) / 100.0;
        }
        public override void displayTax()
        {
            Console.WriteLine($"The Employee with Name:{empName} and age:{empAge} has tax of {this.tax}");
        }
    }

    public class LowTax : Tax
    {
        public override void calculateTax(int salary)
        {

            this.tax = (5 * salary) / 100.0;
        }
        public override void displayTax()
        {
            Console.WriteLine($"The Employee with Name:{empName} and age:{empAge} has tax of {this.tax}");
        }
    }

    enum Shapes { circle, rectangle, square }

    static class Keys
    {

    }
    internal class Task4
    {

        public void calculateArea()
        {
            decimal length;
            decimal radius;
            decimal breadth;
            foreach (int i in Enum.GetValues(typeof(Shapes)))
            {
                if (Enum.GetName(typeof(Shapes), i) == "circle")
                {
                    Console.WriteLine("Enter the radius:");
                    radius = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Circle is {3.14m * radius * radius} mts");
                }
                else if (Enum.GetName(typeof(Shapes), i) == "rectangle")
                {
                    Console.WriteLine("Enter the Length:");
                    length = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the breadth");
                    breadth = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Rectangle is {length * breadth} mts");
                }
                else
                {
                    Console.WriteLine("Enter the Side:");
                    length = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Square is {length * length} mts");
                }

            }
        }
        public void enumObject(Shapes shapes)
        {
            decimal length;
            decimal radius;
            decimal breadth;
            switch (shapes)
            {
                case Shapes.circle:

                    Console.WriteLine("Enter the radius:");
                    radius = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Circle is {3.14m * radius * radius} mts");
                    break;
                case Shapes.rectangle:
                    Console.WriteLine("Enter the Length:");
                    length = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the breadth");
                    breadth = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Rectangle is {length * breadth} mts");
                    break;
                case Shapes.square:
                    Console.WriteLine("Enter the Side:");
                    length = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Area of Square is {length * length} mts");
                    break;
                default:
                    Console.WriteLine("This shape is not available");
                    break;
            }
        }


        static void Main(string[] args)
        {
            #region BUBBLESORT
#if BUBBLESORT
            int[] arr = new int[] { 23, 5, 11, 29, 1, 28 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The array elements are....");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


#elif QUICK_SORT
            Console.WriteLine("Quick sort is not implemented");

#endif
            #endregion
#if WARNING
#warning "You have a warning on line 114 and warning is defined"
#endif

#line 20 "Task4.cs"
#warning "This warning is intiated from line 119"
#if ERROR
#error "Error is defined"
#endif
#if WARNING
#pragma warning disable
#warning "You have a warning on line 114 and warning is defined"
#endif
            #region RESTRICTION
            Console.WriteLine("This is a  restricted Region");



            #endregion
            string name;
            int age;
            int salary;
            Shapes shape = new Shapes();
            Console.WriteLine("Enter the person name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the person Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the person salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            if (salary < 600000)
            {
                Tax lowTax = new LowTax();
                lowTax.Name = name;
                lowTax.age = age;
                lowTax.salary = salary;
                lowTax.calculateTax(salary);
                lowTax.displayTax();
            }
            else if (salary >= 600000 && salary <= 900000)
            {
                Tax lowTax = new MediumTax();
                lowTax.Name = name;
                lowTax.age = age;
                lowTax.salary = salary;
                lowTax.calculateTax(salary);
                lowTax.displayTax();
            }
            else
            {
                Tax lowTax = new LowTax();
                lowTax.Name = name;
                lowTax.age = age;
                lowTax.salary = salary;
                lowTax.calculateTax(salary);
                lowTax.displayTax();
            }
            string[] arr2 = new string[]
            {
                "circle","rectangle","square"
            };
            Console.WriteLine("Iterating through enum ");
            Task4 task4 = new Task4();
            task4.calculateArea();
            Console.WriteLine("Passing enum as parameter");
            task4.enumObject(Shapes.circle);
            task4.enumObject(Shapes.rectangle);
            task4.enumObject(Shapes.square);
        }
    }
}
