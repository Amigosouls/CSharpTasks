using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Events : EventArgs
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }
        public string EmpDesig { get; set; }
        public float EmpSalary { get; set; }
    }
        public class EmployeeSubscriber
        {
            public event EventHandler<Events> EmployeeCreated;
            public void ShowEmployee(string empName, int empId, string empDesig, float empSalary)
            {
                if (EmployeeCreated != null)
                {
                    Console.WriteLine($"Hi {empName} from {empDesig} team");
                }
                EmployeeCreated(this, new Events { EmpName = empName, EmpId = empId, EmpDesig = empDesig, EmpSalary = empSalary });
            }
        }

    
    public class Bonus
    {
        public static void giveBonus(object sender, Events e)
        {
            int bonus;
            if (e.EmpSalary > 1000 && e.EmpSalary < 5000)
            {
                bonus = 500;
            }
            else if (e.EmpSalary >= 5000 && e.EmpSalary <= 10000)
            {
                bonus= 1000;
            }
            else if (e.EmpSalary >= 10000 && e.EmpSalary <= 15000)
            {
                bonus = 1500;
            }
            else
            {
                bonus = 2000;
            }
            Console.WriteLine($"You have been Given Bonus of {bonus}");
        }
    }

    public class EventsMain
    {
        static void Main(string[] args)
        {
            var count=2;
            string name, desig;
            int id;
            float sal;
            var notify = new EmployeeSubscriber();
            notify.EmployeeCreated += Bonus.giveBonus;
            Console.WriteLine("Ente rthe number of Employees");
            count = Convert.ToInt32( Console.ReadLine() );
            List<Events> emp = new List<Events> { };
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter name:");
                name =Console.ReadLine();
                Console.WriteLine("Enter ID");
                id = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine("Enter Designation");
                desig = Console.ReadLine();
                Console.WriteLine("Salary");
                sal = Convert.ToInt32(Console.ReadLine());
                emp.Add( new Events{ EmpName = name, EmpId = id, EmpDesig = desig, EmpSalary = sal });
            }
            foreach(var employee in emp)
            {
                notify.ShowEmployee(employee.EmpName,employee.EmpId,employee.EmpDesig, employee.EmpSalary);
            }
            //
        }
    }
}
