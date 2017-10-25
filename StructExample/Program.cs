using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sipon s = new Sipon(6, 7);
            s.DoThis();
        }
    }

    public struct Sipon
    {
        public int x;
        public int y;

        public Sipon(int a, int b)
        {
            x = a;
            y = b;

        }

        public void DoThis()
        {
            Console.WriteLine(x + y);
        }
    }
}
