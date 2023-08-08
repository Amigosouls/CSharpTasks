using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpTasks
{

    internal class CustomeException : Exception
    {
        public CustomeException(string message): base(message) { }
    }
    internal class Task6
    {
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee();
            string tname;
            int m1, m2;
            Console.WriteLine("Password validator");
            var passwords = new List<string>() { "Amig4o@123", "Sharo21@22", "32567253", "picot6@12" };
            passwords.ForEach(x => Console.WriteLine($"Value:{x} is {(Regex.IsMatch(x, @"(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])") ? "valid" : "invalid")}"));

            Console.WriteLine("Phone number validator");
            var phno = new List<string>() { "213-3223-232", "23223-2132-2133", "332-453-3113", "343-6764-323","467565-64654" };
            phno.ForEach(x => Console.WriteLine($"Value:{x} is {(Regex.IsMatch(x, @"[0-9]{3}?[-]+[0-9]{4}?[-]+[0-9]{3}?") ? "valid" : "invalid")}"));

            Console.WriteLine("Phone number that doesn't accept 0 or 9");
            var phno2 = new List<string>() { "6378784209", "756347273", "327363746" };
            phno2.ForEach(x => Console.WriteLine($"Value:{x} is {(Regex.IsMatch(x, @"[0-9]{9}?(?=.[09]/d)") ? "valid" : "invalid")}"));
            try
            {
                Console.WriteLine("Enter the name:");

                tname = Console.ReadLine();
                if (Regex.IsMatch(tname, "^[0-9.@#$%]?"))
                {
                    throw new CustomeException("Name cannot accept numbers, valid :[character and _]");
                }
                else
                {
                    trainee.name = tname;
                }
               
               
                
            }
            catch (CustomeException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine("Enter three marks");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());

            trainee.cSharpScore = m1;
            trainee.UIScore = m2;
            trainee.calculateAverage();
            PointersDemo pointersDemo = new PointersDemo();
            //pointersDemo.pointersTask();
            pointersDemo.SwapNumbers();
        }

    }

    internal class Trainee
    {
        public string name;
        public int cSharpScore;
        public int UIScore;
        public int averageScore;
        public void calculateAverage()
        {
            averageScore = cSharpScore+UIScore+averageScore/2;
            try
            {
                if (averageScore < 70)
                {
                    throw new CustomeException("Average score cannot be less than 70");
                }
                else
                {
                    Console.Write(averageScore);
                }
            }
            catch(CustomeException e) 
            {
                Console.WriteLine(e.Message);
            }


        }
    }
    internal class PointersDemo
    {
        public unsafe void pointersTask()
        {
            string tname;
            int age;
            string designation;
            string* ptname = &tname;
            int* page = &age;
            Console.WriteLine("Enter name, age and designation");
            tname = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            designation = Console.ReadLine();
            string* pdesignation = &designation;
            Console.WriteLine($"The value of pointer *ptname:{(string)*ptname} and address is {(int)ptname}");
            Console.WriteLine($"The value of pointer *page:{(int)*page} and address is {(int)page}");
            Console.WriteLine($"The value of pointer *ptname:{(string)*pdesignation} and address is {(int)pdesignation}");
        }
        public unsafe void SwapNumbers()
        {
            int a = 5;
            int b = 9;
            int* pa = &a;
            int* pb = &b;
            Console.WriteLine($"before swapping value of a:{a} and b:{b}");
            *pa = *pa + *pb;
            *pb = *pa - *pb;
            *pa = *pa - *pb;
           
            Console.WriteLine($"After Swapping value of a:{a} and b:{b}");

        }
        public unsafe void matrixAddition()
        {
            int row = 2, col = 2;
            int[,] arr1 = new int[,] { { 3, 7 },{2,8 }};
            int[,] arr2 = new int[,] { { 6, 1 }, { 9, 1 } };
            fixed (int* ptr1 = arr1)  
            fixed (int* ptr2 = arr2) ;
            fixed (int* ptr3 = new int[2, 2]) ;
           
            int num;
            for(int i=0;i < row ;i++)
            {
                for(int j=0;j<col; j++)
                {
                    
                }
            }



        }
    }

}
