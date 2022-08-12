using System;
namespace Library
{
    public class Polygon
    {
        public Polygon(Position p1, Position p2, Position p3, Position p4)
        {
            this.PositionOne = p1;
            this.PositionTwo = p2;
            this.PositionThree = p3;
            this.PositionFour = p4;
        }

        public Position PositionOne
        {
            get;
        }

        public Position PositionTwo
        {
            get;
        }

        public Position PositionThree
        {
            get;
        }

        public Position PositionFour
        {
            get;
        }
    }
}

