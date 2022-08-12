using NUnit.Framework;
using Library;

namespace Library.NUnit
{
    internal sealed class PositionFixture
    {
        private Position pOne = new Position(120, 60, 5);
        private Position pTwo = new Position(130, 70, 5);
        private Position pThree = new Position(150, 89, 5);
        private Position pFour = new Position(140, 45, 5);

        [Test]
        public void CalculatinDistance()
        {
            var distance = PolygonCalculatorHelper.CalculateDistance(pOne, pTwo);
            Assert.AreEqual(11876156.017462872d, distance);
        }

    }
}