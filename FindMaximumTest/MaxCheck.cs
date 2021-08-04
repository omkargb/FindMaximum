using FindMaximum;
using NUnit.Framework;

namespace FindMaximumTest
{
    public class Tests
    {
        MaxNumCheck check = new MaxNumCheck();

        [Test]
        //tc 1.1
        public void GivenMaxIntNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(30, 20, 10);
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 1.2
        public void GivenMaxIntNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(10, 30, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 1.3
        public void GivenMaxIntNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int result = check.IntMax(20, 10, 30);
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 2.1
        public void GivenMaxFloatNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.123f, 10.123f, 30.123f);
            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 2.2
        public void GivenMaxFloatNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.123f, 30.123f, 10.123f);
            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 2.3
        public void GivenMaxFloatNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float result = check.FloatMax(20.123f, 10.123f, 30.123f);
            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 3.1
        public void GivenMaxStringFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string result = check.StringMax("Pear", "Banana", "Apple");
            Assert.AreEqual("Pear", result);
        }

        [Test]
        //tc 3.2
        public void GivenMaxStringSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string result = check.StringMax("Apple", "Pear", "Banana");
            Assert.AreEqual("Pear", result);
        }

        [Test]
        //tc 3.3
        public void GivenMaxStringThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string result = check.StringMax("Apple", "Banana", "Pear");
            Assert.AreEqual("Pear", result);
        }

    }
}