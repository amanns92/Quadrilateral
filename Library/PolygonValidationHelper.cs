using System;
namespace Library
{
    public static class PolygonValidationHelper
    {
        public static bool ValidateModel(Polygon polygon)
        {
            //check if Position have valid values
            if (!IsValidPosition(polygon.PositionOne)
               || !IsValidPosition(polygon.PositionTwo)
               || !IsValidPosition(polygon.PositionThree)
               || !IsValidPosition(polygon.PositionFour))
            {
                return false;
            }

            //Compare Position 
            if (polygon.PositionOne.Equals(polygon.PositionTwo)
                || polygon.PositionOne.Equals(polygon.PositionThree)
                || polygon.PositionOne.Equals(polygon.PositionFour)
                || polygon.PositionTwo.Equals(polygon.PositionThree)
                || polygon.PositionTwo.Equals(polygon.PositionFour)
                || polygon.PositionThree.Equals(polygon.PositionFour))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidPosition(Position polygon)
        {
            if (!(polygon.Longitude <= 180 && polygon.Longitude >= -180))
            {
                //Longitude is not correct
                return false;
            }
            if (!(polygon.Latitude <= 180 && polygon.Latitude >= -180))
            {
                //Latitude is not correct
                return false;
            }
            return true;
        }
    }
}

