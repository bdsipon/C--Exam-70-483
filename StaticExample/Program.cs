using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Math.Round(35.3);
            Console.WriteLine(r);
            Car.Accelerate();
          
        }
    }
    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }

    }
}
