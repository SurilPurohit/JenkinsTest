using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        TestDemo t = new TestDemo();

        [Test]
        public void TestMethod1()
        {
            int actual = t.add(3, 5);
            Assert.AreEqual(8, actual);
        }

    }
}
