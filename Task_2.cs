using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Task_2
    {
        
        static void Main(string[] args)
        {
            int row, col, trineeCount=2;
            string traineeName;
            int traineeAge;
            int traineeNo;
            string traineeAddress;
            int bonus;

            int[,] createdArr;
            Console.WriteLine("Enter The number of Rows:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Columns:");
            col = Convert.ToInt32(Console.ReadLine());
            Task2_1 twoDArray = new Task2_1(row,col);
            createdArr = twoDArray.getArrayValues();
            Console.WriteLine("The Array is................");
            twoDArray.showArray(createdArr);
            twoDArray.convertArray(createdArr);
            twoDArray.jaggedArray();

            //for (int i = 0; i < 5; i++)
            //{
            //    twoDArray.calculateBonus(out traineeName, out traineeAge, out traineeNo, out traineeAddress,out bonus);
            //    Console.WriteLine("Emp Name:" + traineeName);
            //    Console.WriteLine("Emp Age:" + traineeAge);
            //    Console.WriteLine("Emp No:" + traineeNo);
            //    Console.WriteLine("Emp Address:" + traineeAddress);
            //    Console.WriteLine("Emp Bonus:" + bonus);
            //}
            twoDArray.getEmployee();
            
        }
    }
    public class Task2_1
    {
        public int arrrow;
        public int arrcol;

        public Task2_1(int row, int col)
        {
            arrrow = row;
            arrcol = col;
        }
        public int[,] getArrayValues()
        {
            int[,] userArr = new int[arrrow, arrcol];
            for (int i = 0; i < arrrow; i++)
            {
                for (int j = 0; j < arrcol; j++)
                {
                    Console.Write($"Enter the {i} \t {j} th value");
                    userArr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return userArr;
        }
        public void showArray(int[,] arr)
        {
            for (int i = 0; i < arrrow; i++)
            {
                for (int j = 0; j < arrcol; j++)
                {
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
        public void convertArray(int[,] inpArr)
        {
            int count = arrcol * arrrow;
            int[] oneDArray = new int[count];
            int iterator = 0;
            for (int i = 0; i < arrrow; i++)
            {
                for (int j = 0; j < arrcol; j++)
                {
                    oneDArray[iterator] = inpArr[i, j];
                    iterator++;
                }
            }
            Console.WriteLine("Converted Array is......");
            for (int i = 0; i < oneDArray.Length; i++)
            {
                Console.Write(oneDArray[i] + "\t");
            }
        }
        public void jaggedArray()
        {
            string[][,] names = new string[3][,]
            {
                new string[,]{{"hello","Hola" },{"hi","bye" } },
                new string[,]{ {"darshan","vicky" },{"hemanth","sharon" } },
                new string[,] {{"C#","Angular" },{".NET","React" } }

            };
            Console.WriteLine("Jagged Array.......");
            for(int i=0; i < names.Length; i++)
            {
                int x = 0;
                //Console.WriteLine(names[i].Length);
                for(int j=0; j < names[i].GetLength(x); j++)
                {
                    for (int k = 0; k < names[j].Rank; k++)
                    {
                        Console.Write(names[i][j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }

        public void showTrainees(params object[] trainee)
        {
            Console.WriteLine("Trainee details...");
            Console.WriteLine(trainee.Length);
            foreach (object obj in trainee)
            {
                Console.WriteLine($"{obj.ToString()}");
            }
        }
        public void calculateBonus(out string EmpName, out int empAge, out int empNo, out string empAddress,out int bonus )
        {
            string name;
            int age;
            int salary;
            string address;
            Console.WriteLine("Emp Name:");
            name = Console.ReadLine();
            Console.WriteLine("Emp Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Address");
            address = Console.ReadLine();
            EmpName = name;
            empAge = age;
            empNo = (salary % 10) + salary;
            empAddress = address;
            bonus = salary % 10;
          

        }
        


        public void getEmployee()
        {
            int traineeCount = 2;
            string traineeName;
            int traineeAge;
            string traineeAddress;

            object []traineeDetails;
            for (int i = 0; i < traineeCount; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Trainee Name:");
                    traineeName = Console.ReadLine();
                    Console.WriteLine("Trainee Age");
                    traineeAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Trainee Address");
                    traineeAddress = Console.ReadLine();
                    //Object trainee  = new Object( { traineeName, traineeAge, traineeAddress });
                    //traineeDetails+=trainee;
                }


               
            }

            //showTrainees(traineeDetails);


        }
        public void showTrainees(params object[][,] trainee)
        {
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0;j < 1; j++)
                {
                    Console.WriteLine(trainee[i]);
                }
               
            }
        }
     }
 }

