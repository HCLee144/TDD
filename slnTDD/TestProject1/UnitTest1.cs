using prjTDD;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition1()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(1, 2);
            fc.setFraction2(1, 3);
            Assert.That(fc.add() == "5/6");
        }
        [Test]
        public void TestAdditionWithNegative()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(1, 2);
            fc.setFraction2(-1, 3);
            Assert.That(fc.add() == "1/6");
        }
        [Test]
        public void TestAdditionWithNegative2()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(1, -2);
            fc.setFraction2(-1, 3);
            Assert.That(fc.add() == "-5/6");
        }
        [Test]
        public void TestDenomIsZero()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(1, 4);
            fc.setFraction2(1, 0);
            Assert.That(fc.add() == "Invalid");
        }
        [Test]
        public void TestNumIsZero()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(0, 4);
            fc.setFraction2(0, 3);
            Assert.That(fc.add() == "0");
        }
        [Test]
        public void TestAdditionWithReduction()
        {
            CFractionCalculator fc = new CFractionCalculator();
            fc.setFraction1(1, 4);
            fc.setFraction2(1, 4);
            Assert.That(fc.add() == "1/2");
        }
        

    }
}