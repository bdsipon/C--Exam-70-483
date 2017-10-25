using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);
            //list1.Add("Hello");
            Console.WriteLine("Non-generic List Results....");
            foreach(int x in list1)
            {
                Console.WriteLine(x);
            }

           
          

        }
    }
}
