using FindMaximumProbleamGenerics;
namespace FindMaxNumTest
{
    public class FindMaxTestsForNormalClassInt
    {
        FindMax findMax = new FindMax();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMax.IntNumber(26, 17, 1);
            Assert.AreEqual(26, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = findMax.IntNumber(17, 26, 1);
            Assert.AreEqual(26, result);
        }

        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = findMax.IntNumber(17, 1, 26);
            Assert.AreEqual(26, result);
        }
    }
    public class FindMaxTestsForNormalClassFloat
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = findMax.FloatNumber(26.6f, 17.7f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = findMax.FloatNumber(17.7f, 26.6f, 1.1f);
            Assert.AreEqual(26.6f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = findMax.FloatNumber(17.7f, 1.1f, 26.6f);
            Assert.AreEqual(26.6f, result);
        }
    }
    public class FindMaxTestsForNormalClassString
    {
        FindMax findMax = new FindMax();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = findMax.StringValue("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = findMax.StringValue("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = findMax.StringValue("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}