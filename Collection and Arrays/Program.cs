using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a collection that is a list of strings

            var dogs = new List<string>();
            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Retriever");

            // foreach to move through the list
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + "");
            }
        }
    }
}
