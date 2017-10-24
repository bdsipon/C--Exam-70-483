using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 20;
            Console.WriteLine("Age:" + p.Age);
            
    }
    }
    public class Person
    {
    

        private int age;

        public int Age
        {
            get { return age; }
            set {
                if((value>0) && (value<65))
                {
                    age = value;
                }

                else
                {
                    throw new Exception("age can not be over 65");
                }

            }
        }

    }
}
