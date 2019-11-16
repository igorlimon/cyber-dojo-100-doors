using NUnit.Framework;

namespace Tests
{
    using cyber_dojo_100_doors;
    using NUnit.Framework;

    [TestFixture]
    public class HikerTest
    {
        private Hiker _hiker;

        [SetUp]
        public void Setup()
        {
            _hiker = new Hiker();
        }
        /*
         * 
         */
        [Test]
        public void life_the_universe_and_everything()
        {
            // a simple example to start you off
            Assert.AreEqual(42, _hiker.Answer);
        }
    }
}