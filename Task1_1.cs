using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Task1_1
    {
        static void Main(string[] args)
        {
            StringBuilder trainees = new StringBuilder();
            trainees.AppendLine("Srikanth");
            trainees.AppendLine("Darshan");
            trainees.AppendLine("Yamini");
            trainees.AppendLine("Hemanth");
            trainees.AppendLine("Haritha");
            trainees.AppendLine("Sharon");
            trainees.AppendLine("Arun");
            trainees.AppendLine("Vignesh");
            Console.WriteLine(trainees.ToString());
        }

        public void sayMessage()
        {
            Console.WriteLine("I'm in Task 1");
        }

    }
}
