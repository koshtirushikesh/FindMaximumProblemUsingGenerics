using FindMaximumProbleamGenerics;
namespace FindMaxNumTest
{
    public class FindMaxTestsForNormalIntClass
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
    }
}