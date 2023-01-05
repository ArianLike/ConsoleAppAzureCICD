using ConsoleAppAzureCICD;
namespace ConsoleAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(5, calculator.Add(2, 3));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(12, calculator.Multiply(4, 3));
        }

        [TestMethod]
        public void TestSubstract()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(6, calculator.Substract(11, 5));
        }

        [TestMethod]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(12, calculator.Divide(24, 2));
        }

    }
}