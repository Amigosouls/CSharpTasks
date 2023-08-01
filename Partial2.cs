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
        
        public partial void showhashTable()
        {
            foreach(var item in hashtable.Keys)
            { 
                Console.WriteLine($"Key {item} value:{hashtable[item]}");
            }



        }
        public partial void getHashTable()
        {
            
            hashtable.Add(1, "One");
            hashtable.Add(2, 2);
            hashtable.Add(3, null);
            hashtable.Add(4, 3265.234);
            hashtable.Add(5, "Chennai");
        }

    }
}
