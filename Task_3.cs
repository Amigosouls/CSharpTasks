using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Task_3
    {
       
        static void Main(string[] args)
        {
            int count = 0;
            
            char type;
            Console.WriteLine("Enter the no of elements");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ArrayType:");
            type=Convert.ToChar( Console.ReadLine());

            if (type == 'i')
            {
                Generics<int,char> obj1 = new Generics<int,char>();
                int[] arr = new int[count];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                obj1.reverseArray(arr);
                char a, b;
                Console.WriteLine("Enter the value for a :");
                a = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the value for b:");
                b = Convert.ToChar(Console.ReadLine());
                obj1.swapNumbers(a, b);


            }
            else
            {
                Generics<char,int> obj2 = new Generics<char,int>();
                char[] arr = new char[count];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToChar(Console.ReadLine());
                }
                obj2.reverseArray(arr);
                int a, b;
                Console.WriteLine("Enter the value for a :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for b:");
                b = Convert.ToInt32(Console.ReadLine());
                obj2.swapNumbers(a, b);
            }
            CombinationGenerics<int, char, string> obj3 = new CombinationGenerics<int, char, string>(2, 'c', "Heyah!!");
            Task3_2 obj4 = new Task3_2();
            obj4.nullOperations();
            obj4 = new Task3_2(10,23,"Srikanth","Male");
            obj4.showTrainees(obj4);
        }
    }
    internal class Generics<T,T1>
    {
        public void reverseArray(T[] array)
        {
            Array.Reverse(array);
            foreach (T item in array)
            {
                Console.Write(item + "\t");
            }
        }
        public void swapNumbers(T1 val1, T1 val2)
        {
            T1 val3;
            val3= val1;
            val1= val2;
            val2 = val3;
            Console.WriteLine("value of A:" + val1);
            Console.WriteLine( "value of B:"+val2);
        }

    }
    internal class CombinationGenerics<T1, T2, T3>
    {
        T1 val1;
        T2 val2;
        T3 val3;
        public CombinationGenerics(T1 val1, T2 val2, T3 val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
            Console.WriteLine($"Type of {val1} is {typeof(T1)}");
            Console.WriteLine($"Type of {val2} is {typeof(T2)}");
            Console.WriteLine($"Type of {val3} is {typeof(T3)}");
        }
      
    }
    internal class Task3_2
    {
        int id;
        int age;
        string name;
        string gender;
        public Task3_2(int id, int age, string name, string gender)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.gender = gender;
        }
        public Task3_2()
        {

        }
        public void showTrainees(Task3_2 trainee)
        {
            Console.WriteLine($"{trainee.name} with ID no {trainee.id} of age{trainee.age} is a {trainee.gender}");
        }
        public void nullOperations()
        {
            ArrayList nullArr = new ArrayList();
            Console.WriteLine("Enter 5 values, press enter to add null");
            for (int i = 0; i < 5; i++)
            {
                var j = Console.ReadLine();
                if(j == "")
                {
                    nullArr.Add(null);
                    continue;
                }
                nullArr.Add(j);

            }
            foreach (object obj in nullArr)
            {
                if(obj == null)
                {
                    Console.WriteLine("i have a value");
                    continue;
                }
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
