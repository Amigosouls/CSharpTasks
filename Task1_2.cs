using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Task1_2
    {
        static void Main(string[] args)
        {
            string userInp;
            Console.WriteLine("Enter the input:");
            userInp = Console.ReadLine();
            StringBuilder sb = new StringBuilder(userInp);
            sb.Append(".NET Trainee!");
            Console.WriteLine($"Using Append: {sb.ToString()}");
            sb.AppendLine("Welcome to You");
            Console.WriteLine($"Using AppendLine: {sb.ToString()}");
            sb.Remove(8, 20);
            Console.WriteLine($"After Remove:{sb.ToString()}");
            sb.Insert(0, "Sharon");
            Console.WriteLine(($"After Insert:{sb.ToString()}"));
            sb.Replace('!', '?');
            Console.WriteLine($"After Replace:{sb.ToString()}");
        }
    }
}
