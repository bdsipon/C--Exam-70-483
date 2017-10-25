using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            double y = 12.6;
            x = Convert.ToInt32(y);
            Console.WriteLine(x);

            string str = "123";
            int r;
            r = Convert.ToInt32(str);
            Console.WriteLine(r);
        }
    }
}
