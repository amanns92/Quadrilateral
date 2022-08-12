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

        [Test]
        public void ValidateValidPosition()
        {
            Assert.IsTrue(PolygonValidationHelper.IsValidPosition(new Position(180, 180, 50)));
        }

        [Test]
        public void ValidateToLonwLatitude()
        {
            Assert.IsFalse(PolygonValidationHelper.IsValidPosition(new Position(-181, 140, 50)));
        }

        [Test]
        public void ValidateToHighLatitude()
        {
            Assert.IsFalse(PolygonValidationHelper.IsValidPosition(new Position(181, 140, 50)));
        }

        [Test]
        public void ValidateToLonwLongitude()
        {
            Assert.IsFalse(PolygonValidationHelper.IsValidPosition(new Position(120, -181, 50)));
        }

        [Test]
        public void ValidateToHighLongitude()
        {
            Assert.IsFalse(PolygonValidationHelper.IsValidPosition(new Position(120, 181, 50)));
        }

        [Test]
        public void ValidateValidPoyligon()
        {
            Assert.IsTrue(PolygonValidationHelper.ValidateModel(new Polygon(pOne, pTwo, pThree, pFour)));
        }

        [Test]
        public void ValidatePolygonTwoPositionsAreEqual()
        {
            Assert.IsFalse(PolygonValidationHelper.ValidateModel(new Polygon(pOne, pOne, pThree, pFour)));
        }

        [Test]
        public void ValidatePolygonPositionInvalidDegree()
        {
            Assert.IsFalse(PolygonValidationHelper.ValidateModel(new Polygon(pOne, new Position(-181, 140, 50), pThree, pFour)));
        }

    }
}