using NUnit.Framework;

namespace PipeTestProj
{
    public class Tests
    {
        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail();
        }
    }
}