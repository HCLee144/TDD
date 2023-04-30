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
            Assert.That(fc.add()=="5/6");
            
        }
    }
}