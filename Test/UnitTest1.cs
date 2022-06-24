
namespace Test
{
    public class Tests
    {
        private Solver Solver;
        
        [SetUp]
        public void Setup()
        {
            Solver = new Solver();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(4,Solver.RomanToInt("IV"));
        }
    }
}