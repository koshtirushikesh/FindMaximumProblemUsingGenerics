using FindMaximumProbleamGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumTest
{
    internal class FindMaxGenricClassTestForInt
    {
        FindMaxGenric<int> findMaxInt = new FindMaxGenric<int>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMaxInt.GenricValue(26, 17, 1);
            Assert.AreEqual(26, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMaxInt.GenricValue(17, 26, 1);
            Assert.AreEqual(26, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMaxInt.GenricValue(17, 26, 1);
            Assert.AreEqual(26, result);
        }
    }
    internal class FindMaxGenricClassTestForFloat
    {
        FindMaxGenric<float> findMaxFloat = new FindMaxGenric<float>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_Float()
        {
            float result = findMaxFloat.GenricValue(26.6f, 17.7f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax_Float()
        {
            float result = findMaxFloat.GenricValue(17.7f, 26.6f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax_Float()
        {
            float result = findMaxFloat.GenricValue(17.7f, 1.1f, 26.6f);
            Assert.AreEqual(26.6f, result);
        }
    }
    internal class FindMaxGenricClassTestForString
    {
        FindMaxGenric<string> findMaxString = new FindMaxGenric<string>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_String()
        {
            string result = findMaxString.GenricValue("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax_String()
        {
            string result = findMaxString.GenricValue("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax_String()
        {
            string result = findMaxString.GenricValue("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}
