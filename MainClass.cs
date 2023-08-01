using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal partial class Partialclass
    {
        Hashtable hashtable = new Hashtable();
        public partial void showhashTable();
        public partial void getHashTable();
    }
    internal partial class Partialclass2
    {
        LinkedList<int> links = new LinkedList<int>();
        HashSet<string> hashset = new HashSet<string>(); 
         Queue<string> namequeue = new Queue<string>();
        public partial void getLinkedList();
        public partial void showLinkedList();
        public partial void hashsetFunctions();
        public partial void queueFunctions();
    }
    public partial struct Attendance
    {
        public Attendance() { }
        Hashtable attendanceList = new Hashtable();
        public partial void getAttendanceList();
        public partial void markAttendance();
        public partial void viewAttendance();
        public partial void calcPreAbs();
    }
    internal class Mainclass
    {
        static void Main(string[] args)
        {
            string loop;
            Partialclass partialClasses = new Partialclass();
            Console.WriteLine("HashTable value retrival....");
            partialClasses.getHashTable();
            partialClasses.showhashTable();
            Console.WriteLine("Linked List , HashSet , Queue");
            Partialclass2 partialclass2 = new Partialclass2();
            partialclass2.getLinkedList();
            partialclass2.showLinkedList();
            Console.WriteLine("Hash Set:.........");
            partialclass2.hashsetFunctions();
            Console.WriteLine("Queue Functions....");
            partialclass2.queueFunctions();
            Attendance attendance = new Attendance();
            while (true)
            {   
                Console.Write("Enter 1-> Get Attendance \n2->View Attendance \n 3-> Mark Attendance\n 4->Count of Absent or Present\n q->exit ");
                loop = Console.ReadLine();
                if(loop == "1")
                {
                    attendance.getAttendanceList();
                }
                else if(loop == "2")
                {
                    attendance.viewAttendance();
                }
                else if( loop == "3")
                {
                    attendance.markAttendance();
                }
                else if(loop == "4")
                {
                    attendance.calcPreAbs();
                }
                else
                {
                    break;
                }
            }

        }
    }
}
