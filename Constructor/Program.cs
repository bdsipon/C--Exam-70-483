using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            //DefConstructor dc = new DefConstructor();
            //dc.DoThis();

            AddConstruction ac = new AddConstruction();
        }
    }

    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run..");
        }
    }

    public class AddConstruction
    {
        public AddConstruction()
        {
            Console.WriteLine("The constructor has been called ...");
            DoThat();
        }
        public void DoThat()
        {
            Console.WriteLine("DoThat has executed");

        }
    }
}
