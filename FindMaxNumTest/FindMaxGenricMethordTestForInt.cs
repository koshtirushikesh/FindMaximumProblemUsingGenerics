using FindMaximumProbleamGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumTest
{
    internal class FindMaxGenricMethordTestForInt
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMax.GenricValue<int>(26, 17, 1);
            Assert.AreEqual(26, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMax.GenricValue<int>(17, 26, 1);
            Assert.AreEqual(26, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMax.GenricValue<int>(17, 1, 26);
            Assert.AreEqual(26, result);
        }
    }
    internal class FindMaxGenricMethordTestForFloat
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_Flot()
        {
            float result = findMax.GenricValue<float>(26.6f, 17.7f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax_Flot()
        {
            float result = findMax.GenricValue<float>(17f, 26.6f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax_Flot()
        {
            float result = findMax.GenricValue<float>(17f, 1.1f, 26.6f);
            Assert.AreEqual(26.6f, result);
        }
    }

    internal class FindMaxGenricMethordTestForString
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_String()
        {
            string result = findMax.GenricValue<string>("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax_String()
        {
            string result = findMax.GenricValue<string>("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax_String()
        {
            string result = findMax.GenricValue<string>("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}
