namespace Tests
{
    using cyber_dojo_100_doors;
    using NUnit.Framework;

    [TestFixture]
    public class HikerTest
    {
        private Hiker _hiker;
        private int _numberOfDoors;

        [SetUp]
        public void Setup()
        {
            _numberOfDoors = 100;
            _hiker = new Hiker(_numberOfDoors);
        }

        [TestCase(1, 100, 0)]
        [TestCase(2, 50, 50)]
        [TestCase(3, 49, 51)]
        [TestCase(4, 58, 42)]
        [TestCase(4, 58, 42)]
        [TestCase(5, 52, 48)]
        [TestCase(6, 54, 46)]
        [TestCase(7, 52, 48)]
        [TestCase(8, 46, 54)]
        [TestCase(9, 49, 51)]
        [TestCase(10, 49, 51)]
        [TestCase(11, 52, 48)]
        [TestCase(12, 54, 46)]
        [TestCase(13, 57, 43)]
        [TestCase(14, 52, 48)]
        [TestCase(15, 52, 48)]
        [TestCase(16, 54, 46)]
        [TestCase(17, 55, 45)]
        [TestCase(100, 10, 90)]

        public void SixIteration_49DoorsAreOpened(int numberOfIterations, int expectedNumberOfOpenedDoors, int expectedNumberOfClosedDoors)
        {
            // arrange
            // act
            DoorsState actual = _hiker.Answer(numberOfIterations);

            // arrange
            Assert.AreEqual(expectedNumberOfOpenedDoors, actual.Opened);
            Assert.AreEqual(expectedNumberOfClosedDoors, actual.Closed);
        }
    }
}