using NUnit.Framework;

namespace JonSnow.Unit.Tests
{
    [TestFixture]
    public abstract class BaseSpec
    {
        [SetUp]
        public void BeforeEachSpec()
        {

        }

        [TearDown]
        public void AfterEachSpec()
        {

        }
    }
}
