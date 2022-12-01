namespace Module16.Tests
{
    [TestFixture]
    public class Tests
    {
        public class CalculatorTests
        {
            [Test]
            public void AdditionalTest()
            {
                var calculator = new Practices.Calculator();
                Assert.True(calculator.Additional(30, 2) == 32);
            }
            [Test]
            public void SubtractionTest()
            {
                var calculator = new Practices.Calculator();
                Assert.True(calculator.Subtraction(30, 2) == 28);
            }
            [Test]
            public void MiltiplicationTest()
            {
                var calculator = new Practices.Calculator();
                Assert.True(calculator.Miltiplication(30, 2) == 60);
            }
            [Test]
            public void DivisionTest()
            {
                var calculator = new Practices.Calculator();
                Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
                Assert.True(calculator.Division(30, 2) == 15);
            }
        }
    }
}