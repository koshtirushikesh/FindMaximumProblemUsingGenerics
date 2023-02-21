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

        
    }
}