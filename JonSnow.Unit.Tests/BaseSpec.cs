using NUnit.Framework;

namespace JonSnow.Unit.Tests
{
    [TestFixture]
    public abstract class BaseSpec
    {
        [SetUp]
        public virtual void BeforeEachSpec()
        {

        }

        [TearDown]
        public virtual void AfterEachSpec()
        {

        }
    }
}
