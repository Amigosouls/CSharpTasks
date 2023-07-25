using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDemo;

namespace CSharpTasks
{
    internal class Task1_3
    {
        static void Main(string[] args)
        {
            PublicAccess publicAccess = new PublicAccess();
            publicAccess.sayHello(); // class with public Access specifier used across another assembly

            Task1_1 task1 = new Task1_1(); // class with internal access specifier used within same assembly
            task1.sayMessage();

        }
    }
}
