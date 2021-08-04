using FindMaximum;
using NUnit.Framework;

namespace FindMaximumTest
{
    public class Tests
    {
        [Test]
        //tc 1.1
        public void GivenMaxIntNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<int> check = new MaxNumCheck<int>(30, 20, 10);
            int result = check.MaximumOf();
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 1.2
        public void GivenMaxIntNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<int> check = new MaxNumCheck<int>(20, 30, 10);
            int result = check.MaximumOf();
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 1.3
        public void GivenMaxIntNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<int> check = new MaxNumCheck<int>(20, 30, 10);
            int result = check.MaximumOf();
            Assert.AreEqual(30, result);
        }

        [Test]
        //tc 2.1
        public void GivenMaxFloatNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<float> check = new MaxNumCheck<float>(30.123f, 20.123f, 10.123f);
            float result = check.MaximumOf();
            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 2.2
        public void GivenMaxFloatNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<float> check = new MaxNumCheck<float>(20.123f, 30.123f, 10.123f);
            float result = check.MaximumOf();
            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 2.3
        public void GivenMaxFloatNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<float> check = new MaxNumCheck<float>(20.123f, 10.123f, 30.123f);
            float result = check.MaximumOf();

            Assert.AreEqual(30.123f, result);
        }

        [Test]
        //tc 3.1
        public void GivenMaxStringFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<string> check = new MaxNumCheck<string>("Pear", "Banana", "Apple");
            string result = check.MaximumOf();
            Assert.AreEqual("Pear", result);
        }

        [Test]
        //tc 3.2
        public void GivenMaxStringSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<string> check = new MaxNumCheck<string>("Apple", "Pear", "Banana");
            string result = check.MaximumOf();
            Assert.AreEqual("Pear", result);
        }

        [Test]
        //tc 3.3
        public void GivenMaxStringThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            MaxNumCheck<string> check = new MaxNumCheck<string>("Apple", "Banana", "Pear");
            string result = check.MaximumOf();
            Assert.AreEqual("Pear", result);
        }

    }
}