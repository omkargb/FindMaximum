using FindMaximum;
using NUnit.Framework;

namespace FindMaximumTest
{
    public class Tests
    {
        MaxNumCheck check = new MaxNumCheck();
        [Test]
        //tc 1.1
        public void GivenMaxNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(30, 20, 10);
            Assert.AreEqual(30,result);
        }

        [Test]
        //tc 1.2
        public void GivenMaxNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(10, 30, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 1.3
        public void GivenMaxNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(20, 10, 30);
            Assert.AreEqual(30, result);
        }
    }
}