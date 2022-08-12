using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Library
{
    public static class PolygonCalculatorHelper
    {
        public static double CalculateDistance(Position pOne, Position pTwo)
        {
            //convert into Vector
            var xOne = (Math.Cos(pOne.Latitude)) * (Math.Cos(pOne.Longitude));
            var yOne = (Math.Cos(pOne.Latitude)) * (Math.Sin(pOne.Longitude));
            var zOne = (Math.Sin(pOne.Latitude));

            var xTwo = (Math.Cos(pTwo.Latitude)) * (Math.Cos(pTwo.Longitude));
            var yTwo = (Math.Cos(pTwo.Latitude)) * (Math.Sin(pTwo.Longitude));
            var zTwo = (Math.Sin(pTwo.Latitude));

            //MeanRadius * Acos(xa * xb + ya * yb + za * zb);
            var meanRadius = 6.371 * Math.Pow(10, 6); //MeanRadius Earth
            return meanRadius * Math.Acos(xOne * xTwo + yOne * yTwo + zOne * zTwo);
        }
    }
}

