using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProbleamGenerics
{
    // Icomparible is used to provid a Default sort order for your obj(object).
    public class FindMaxGenric<T> where T : IComparable
    {
        public T GenricValue(T firstNum, T secondNum, T thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
                return secondNum;
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
                return thirdNum;

            return firstNum;
        }
    }
}
