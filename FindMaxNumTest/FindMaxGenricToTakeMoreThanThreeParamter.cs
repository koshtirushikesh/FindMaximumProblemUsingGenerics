using FindMaximumProbleamGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumTest
{
    internal class FindMaxGenricToTakeMoreThanThreeParamter
    {
        int[] intArray = { 10, 40, 20, 30, 100, 70, 50 };
        float[] floatArray = { 10.1f, 40.1f, 20.1f, 30.1f, 100.1f, 70.1f, 50.1f };
        string[] stringArray = { "Rushi", "Koshti", "Rutik", "Koshti" };


        FindMaxGenric<int> findMaxGenric = new FindMaxGenric<int>();
        FindMaxGenric<float> findMaxGenricFloat = new FindMaxGenric<float>();
        FindMaxGenric<string> findMaxGenricString = new FindMaxGenric<string>();
        [Test]
        public void GivenMaxNum_WhenAnalysed_ShouldReturnMax()
        {
            Assert.AreEqual(100, findMaxGenric.GenricValue(intArray));
        }

        [Test]
        public void GivenMaxfloatNum_WhenAnalysed_ShouldReturnMaxfloat()
        {
            Assert.AreEqual(100.1f, findMaxGenricFloat.GenricValue(floatArray));
        }

        [Test]
        public void GivenMaxString_WhenAnalysed_ShouldReturnMaxString()
        {
            Assert.AreEqual("Rutik", findMaxGenricString.GenricValue(stringArray));
        }

    }
}
