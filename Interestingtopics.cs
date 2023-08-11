using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Interestingtopics
    {
       // public delegate long calcprod()
        static async Task Main(string[] args)
        {
            int n;
            VariableTypes varObj = new VariableTypes();
            Console.WriteLine("Before Assigning Values");
            varObj.showVariablesValues();
            VariableTypes varObj1 = new VariableTypes(12);
            Console.WriteLine("After Assigning Values through constructor");
            varObj1.showVariablesValues();
            Console.WriteLine("Intializing instance variable using the instance created");
            varObj1.instance_num = 60;
            varObj1.showVariablesValues();
            Console.WriteLine("Showing Values using the old instance..");
            varObj.showVariablesValues();
            Console.WriteLine("Enter the Value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            // Func<Task> actionDelegate = new Func<Task>(Product);
            Task<int> sumResult = sumOfNum(n);
            Task<int> prodResult = Product(n);
            var sum = await sumResult;
            var prod =await prodResult;
            Console.WriteLine($" Product:{prod}");
            
            Console.WriteLine($"Sum: {sum}");
            tuple tupobj = new tuple();
            tupobj.getEmp();
            tupobj.getEmpcategory();
            
           
            

            //object obj = new object {73 };
           
            //Tuple[] name = new Tuple<int>
            //var traineeDetails = Tuple.Create(emp[0], emp[1]);
            //traineeDetails.(name, age);
            //Console.WriteLine(traineeDetails.Item1);
            //Console.WriteLine(traineeDetails.Item2);
        }

        public async static Task<int> sumOfNum(int n)
        {
            int sum = 0;
            Console.Write("sum started");
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
           // Task.Run();
            await Task.Delay(3000);
            return sum;
            //Console.WriteLine("The sum of natural Numbers..." + sum);
        }

        public async static Task<int> Product(int n)
        {
            Console.Write("prod started");

            int prod = 1;
            for(int i=1; i <= n; i++)
            {
                prod *= i;
            }
           await Task.Delay(300);
            
            return prod ;
        }
    }

    internal class tuple
    {
        public string name;
        public int age;

        public tuple()
        {

        }
        public tuple(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void getEmp()
        {
            string name;
            int age,count;
            List<tuple> empList = new List<tuple>();
            Console.WriteLine("Enter the count of Employees...");
            count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <count; i++)
            {
                Console.WriteLine("Emp name:");
                name = Console.ReadLine();
                Console.WriteLine("Emp Age");
                age = Convert.ToInt32(Console.ReadLine());
                empList.Add(new tuple(name, age));
            }

            foreach (tuple t in empList)
            {
                var emptup = Tuple.Create(t.name, t.age);
                Console.WriteLine("Emp name:" + emptup.Item1);
                Console.WriteLine("Emp age"+emptup.Item2);
            }

        }

        public void getEmpcategory()
        {
            string name, age, type;
            int count;
            List<Company> companyList = new List<Company>();
            Console.WriteLine("Enter the count of Employees...");
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Emp name:");
                name= Console.ReadLine();
                Console.WriteLine("Emp Age");
                age= Console.ReadLine();
                Console.WriteLine("Company");
                type= Console.ReadLine();
                companyList.Add(new Company(name, age,type));
            }
            foreach(Company company in companyList)
            {
                var empTup = Tuple.Create(company.compName, company.empage, company.compName);
                categorizeEmp(empTup);
            }
        }

        public void categorizeEmp(Tuple<string,string,string> emp)
        {
            if (emp.Item3=="CG")
            {
                Console.WriteLine("Employee is from CG");
                Console.WriteLine($"Emp name:{emp.Item1,-10}  EmpAge:{emp.Item2,-15}  EmpSalary{emp.Item3,-15}");
            }
            else if (emp.Item3 =="G2")
            {
                Console.WriteLine("Employee is from G2");
                Console.WriteLine($"Emp name:{emp.Item1,-10}  EmpAge:{emp.Item2,-15}  EmpSalary{emp.Item3,-15}");
            }
        }
    }

    internal class Company
    {
        public string empname;
        public string empage;
        public string compName;

        public Company(string empname, string empage, string compName)
        {
            this.empname = empname;
            this.empage = empage;
            this.compName = compName;
        }
    }

    internal class VariableTypes
    {
        public readonly int readOnly_num;
        public static int static_num;
        public const int const_num = 20;
        public  int instance_num ;
        public VariableTypes()
        {

        }

        public VariableTypes(int val)
        {
            static_num = val;
            readOnly_num = val;
            instance_num = val;
        }

        public void showVariablesValues()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("readOnly_num:" + readOnly_num);
            Console.WriteLine("static_num:" + static_num);
            Console.WriteLine("const_num:" + const_num);
            Console.WriteLine("instance_num:"+instance_num);
            Console.WriteLine("=============================================");
        }


       
    }
}
