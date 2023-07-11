namespace Semana6.nUnitTests
{
    public class Tests
    {
        ForTest testVar;
        
        [SetUp]
        public void Setup()
        {
            testVar = new ForTest();
        }

        [Test]
        public void Test1()
        {
            int res = testVar.Soma(4, 5, 6, 7, 8);
            int res2 = testVar.Soma(4, -5, 0, -8);

            Assert.AreEqual(-9, res2);
            Assert.AreEqual(30, res);
        }
    }
}