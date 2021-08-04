using FindMaximum;
using NUnit.Framework;

namespace FindMaximumTest
{
    public class Tests
    {
        MaxNumCheck check = new MaxNumCheck();

        [Test]
        //tc 2.1
        public void GivenMaxNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.20f, 10.10f, 30.30f);
            Assert.AreEqual(30.30, result);
        }

        [Test]
        //tc 2.2
        public void GivenMaxNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.20f, 30.30f, 10.10f);
            Assert.AreEqual(30.30, result);
        }

        [Test]
        //tc 2.3
        public void GivenMaxNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.20f, 10.10f, 30.30f);
            Assert.AreEqual(30.30, result);
        }
    }
}