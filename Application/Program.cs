using System;
using System.Reflection;
using Library;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Poyligon! Example input 1.5");

            Console.WriteLine("Enter Values for Position One!");
            var positionOne = readPosition();
            if(positionOne == null)
            {
                Console.WriteLine("User Exit.");
                return;
            }

            Console.WriteLine("Enter Values for Position Two!");
            var positionTwo = readPosition();
            if (positionTwo == null)
            {
                Console.WriteLine("User Exit.");
                return;
            }

            Console.WriteLine("Enter Values for Position Three!");
            var positionThree = readPosition();
            if (positionThree == null)
            {
                Console.WriteLine("User Exit.");
                return;
            }

            Console.WriteLine("Enter Values for Position Four!");
            var positionFour = readPosition();
            if (positionFour == null)
            {
                Console.WriteLine("User Exit.");
                return;
            }

            ValidatePolygonAndPrintDistance(new Polygon(positionOne, positionTwo, positionThree, positionFour));
        }

        public static Position readPosition()
        {
            Console.WriteLine("Enter Longitude for Position");
            var latitudeString = Console.ReadLine();
            double latitude = 0.0;
            if (!Double.TryParse(latitudeString, out latitude))
            {
                Console.WriteLine("Could not read the Longitude.");
                Console.WriteLine("You want to try to enter this Position again? y/n");
                Console.WriteLine("No valid input will asume no.");
                var yesOrNo = Console.ReadKey().Key.ToString().ToUpper();
                Console.WriteLine();
                if (yesOrNo.Equals("Y"))
                {
                    return readPosition();
                }

                return null;
            }

            Console.WriteLine("Enter Latitude for Position");
            var longitudeString = Console.ReadLine();
            double longitude = 0.0;
            if (!Double.TryParse(longitudeString, out longitude))
            {
                Console.WriteLine("Could not read the Longitude.");
                Console.WriteLine("You want to try to enter this Position again? y/n");
                Console.WriteLine("No valid input will asume no.");
                var yesOrNo = Console.ReadKey().Key.ToString().ToUpper();
                Console.WriteLine();
                if (yesOrNo.Equals("Y"))
                {
                    return readPosition();
                }
                return null;
            }

            Console.WriteLine("Enter Height for Position");
            var heigthString = Console.ReadLine();
            double height = 0.0;
            if (!Double.TryParse(heigthString, out height))
            {
                Console.WriteLine("Could not read the Height.");
                Console.WriteLine("You want to try to enter this Position again? y/n");
                Console.WriteLine("No valid input will asume no.");
                var yesOrNo = Console.ReadKey().Key.ToString().ToUpper();
                Console.WriteLine();
                if (yesOrNo.Equals("Y"))
                {
                    return readPosition();
                }
                return null;
            }
            return new Position(latitude, longitude, height);
        }

        public static void ValidatePolygonAndPrintDistance(Polygon polygon)
        {
            if (!PolygonValidationHelper.ValidateModel(polygon))
            {
                Console.WriteLine("The Model is not Valid");
            }

            Console.WriteLine("Distance from Position one to Position two: " + PolygonCalculatorHelper.CalculateDistance(polygon.PositionOne, polygon.PositionTwo));
            Console.WriteLine("Distance from Position two to Position three: " + PolygonCalculatorHelper.CalculateDistance(polygon.PositionTwo, polygon.PositionThree));
            Console.WriteLine("Distance from Position three to Position four: " + PolygonCalculatorHelper.CalculateDistance(polygon.PositionThree, polygon.PositionFour));
            Console.WriteLine("Distance from Position four to Position one: " + PolygonCalculatorHelper.CalculateDistance(polygon.PositionFour, polygon.PositionOne));
        }
    }
}
