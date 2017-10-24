﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is an example of ";
            s1 = s1 + "string concategnation";
            Console.WriteLine(s1);

            StringBuilder sb2 = new StringBuilder("This is an example of");
            sb2.Append("string concatenation");
            Console.WriteLine(sb2);

     
            sb2.Append("using StringBuilder...");
            Console.WriteLine(sb2);
            sb2.Replace("StringBuilder", "the StringBuilder class...");
            Console.WriteLine(sb2);
        }
    }
}