using System;
namespace Library
{
    public static class PolygonCalculatorHelper
    {
        public static double CalculateDistance(Position p1, Position p2)
        {
            //TODO: implement
            return 0.0;
        }

        public static bool ValidateModel(Polygon polygon)
        {
            //Compare Position 
            if (polygon.PositionOne.Equals(polygon.PositionTwo))
            {
                return false;
            }
            if (polygon.PositionOne.Equals(polygon.PositionThree))
            {
                return false;
            }
            if (polygon.PositionOne.Equals(polygon.PositionFour))
            {
                return false;
            }
            if (polygon.PositionTwo.Equals(polygon.PositionThree))
            {
                return false;
            }
            if (polygon.PositionTwo.Equals(polygon.PositionFour))
            {
                return false;
            }
            if (polygon.PositionThree.Equals(polygon.PositionFour))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidPosition(Position polygon)
        {
            if(!(polygon.Longitude <= 180 && polygon.Longitude >= -180))
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

