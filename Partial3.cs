using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal partial class Partialclass2
    {
        public partial void getLinkedList()
        {
            links.AddFirst(1);
            links.AddFirst(2);
            links.AddFirst(3);
            links.AddLast(4);
            links.AddLast(5);
            links.AddFirst(10);
            var node = links.AddFirst(15);
            Console.WriteLine($"Adding value 5 after node {node.Value}");
            links.AddAfter(node,5);
        }

        public partial void showLinkedList()
        {
            Console.Write("Linked List:\t");
            foreach (var link in links)
            {
                Console.Write(link+"\t");
            }
        }

        public partial void hashsetFunctions()
        {
            Console.WriteLine($"Adding value Hello {hashset.Add("hello")}");
            Console.WriteLine($"checking if Hello exits in hashset:{hashset.Contains("hello")}");
            Console.WriteLine($"Removing hello from hashset:{hashset.Remove("hello")}");
            Console.WriteLine($"Adding charaters of string hello to hashset:");
            foreach(char str in "hello")
            {
                hashset.Add(Convert.ToString( str));
            }
            Console.WriteLine($"Checking value in index 2 hashset:{hashset.ElementAt(2)}");
            Console.WriteLine("Values of hashset.....");
            foreach(string str in hashset)
            {
                Console.Write(str+"\t");
            }
        }
        public partial void queueFunctions()
        {
            Console.WriteLine($"Enqueue: Adding vignesh");
            namequeue.Enqueue("Vignesh");
            Console.WriteLine($"Enqueue: Adding Srikanth");
            namequeue.Enqueue("Srikanth");
            Console.WriteLine($"Enqueue: Adding yamini");
            namequeue.Enqueue("Yamini");
            var returnVal= namequeue.Dequeue();
            Console.WriteLine($"Dequeue: {returnVal}");
            Console.WriteLine($"Contains(vignesh):{namequeue.Contains("vignesh")}");
            Console.WriteLine($"Element at 1:{namequeue.ElementAt(1)}");
            Console.WriteLine($"Count:{namequeue.Count}");
            namequeue.Clear();
            Console.WriteLine($"Clear():{(namequeue.Count==0 ? "name queue is empty": "name queue is has value")}");
            
        }

    }

}
