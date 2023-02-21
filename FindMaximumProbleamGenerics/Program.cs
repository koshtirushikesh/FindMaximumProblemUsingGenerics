using System;
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
            Console.WriteLine(findMax.FloatNumber(20.2f,33.3f,44.4f));
            Console.ReadLine();
        }
    }
}
