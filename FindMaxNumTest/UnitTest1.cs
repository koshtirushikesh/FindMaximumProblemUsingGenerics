using FindMaximumProbleamGenerics;
namespace FindMaxNumTest
{
    public class FindMaxTestsForNormalIntClass
    {
        FindMax findMaxInt = new FindMax();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = findMaxInt.IntNumber(26, 17, 1);
            Assert.AreEqual(26, result);
        }
    }
}