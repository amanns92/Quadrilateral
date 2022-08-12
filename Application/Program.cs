using System;
using Library;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Poyligon!");

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
                if(Console.ReadKey().ToString().ToUpper().Equals('Y'))
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
                if (Console.ReadKey().ToString().ToUpper().Equals('Y'))
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
                if (Console.ReadKey().ToString().ToUpper().Equals('Y'))
                {
                    return readPosition();
                }
                return null;
            }
            return new Position(latitude, longitude, height);
        }
    }
}
