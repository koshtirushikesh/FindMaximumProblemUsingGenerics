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
            Console.WriteLine(findMax.FloatNumber(55.5f, 33.4f, 22.3f));
            Console.WriteLine(findMax.StringValue("Apple", "Peach", "Banana"));

            FindMaxGenric<int> findMaxGenric = new FindMaxGenric<int>();
            FindMaxGenric<float> findMaxGenricFloat = new FindMaxGenric<float>();
            FindMaxGenric<string> findMaxGenricString = new FindMaxGenric<string>();

            int[] intArray = { 10, 40, 200, 30, 100 };
            float[] floatArray = { 10.1f, 40.1f, 20.1f, 30.1f, 100.1f, 70.1f, 50.1f };
            string[] stringArray = { "Rushi", "Koshti", "Rutik", "Koshti"};
            Console.WriteLine(findMaxGenric.GenricValue(intArray));
            Console.WriteLine(findMaxGenricFloat.GenricValue(floatArray));
            Console.WriteLine(findMaxGenricString.GenricValue(stringArray));

            Console.ReadLine();
        }
    }
}
