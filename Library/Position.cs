namespace Library
{
    public sealed class Position
    {
        public Position(double latitude, double longitude, double height)
        {
            Latitude = latitude;
            Longitude = longitude;
            Height = height;
        }

        /// <summary>
        /// Latitude in decimal degrees
        /// </summary>
        public double Latitude
        {
            get;
        }

        /// <summary>
        /// Longitude in decimal degrees
        /// </summary>
        public double Longitude
        {
            get;
        }

        /// <summary>
        /// Height in metres
        /// </summary>
        public double Height
        {
            get;
        }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Position))
            {
                return false;
            }
            return (this.Longitude == ((Position)obj).Longitude)
                && (this.Latitude == ((Position)obj).Latitude);
        }

    }
}
