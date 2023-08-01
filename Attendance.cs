using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public partial  struct Attendance
    {
        public partial void getAttendanceList()
        {
            int count,status;
            string name;
            Console.WriteLine("Enter the number of person to enter attendnace:");
            count = Convert.ToInt32( Console.ReadLine());
            

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter Trainee name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter 1 for present 0 for Absent:");
                status = Convert.ToInt32( Console.ReadLine());
                attendanceList.Add(name,status);
            }
            Console.WriteLine("Attendance list created successfully");
        }
        public partial void viewAttendance()
        {
            Console.Write($"\t\tName\t\t ");
            Console.Write($"Present/Absent\n");
            foreach (var item in attendanceList.Keys) 
            {

                Console.WriteLine($"\t\t{item}\t\t{(attendanceList[item].ToString()=="1" ? "present":"absent")}");
            }
            
        }
        public partial void calcPreAbs()
        {
            var present=0;
            var absent = 0;
            foreach (var item in attendanceList.Keys)
            {
                if (Convert.ToInt32(attendanceList[item]) == 1)
                {
                    present += 1;
                }
                else
                {
                    absent += 1;
                }
            }
            Console.WriteLine($"Total Number of Present:{present}\t Number of Absent {absent} ");
        }
        public partial void markAttendance()
        {
            string user ;
            int status;
            Console.WriteLine("Enter the name of the trainee to mark attendnce");
            user=Console.ReadLine();
            Console.WriteLine("Enter 1 for present 0 for Absent:");
            status = Convert.ToInt32(Console.ReadLine());
           
            if (attendanceList.ContainsKey(user))
            {
                attendanceList[user] = status;
            }
            else
            {
                Console.WriteLine($"No user found with the name{user}");
            }
            Console.WriteLine("Status update successfully");
        }
        
    }
}
