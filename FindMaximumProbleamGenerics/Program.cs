﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProbleamGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            Console.WriteLine(findMax.IntNumber(50, 40, 30));
            Console.WriteLine(findMax.FloatNumber(55.5f,33.4f,22.3f));
            Console.WriteLine(findMax.StringValue("Apple", "Peach", "Banana"));    

            Console.ReadLine();
        }
    }
}
