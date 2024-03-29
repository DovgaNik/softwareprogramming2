using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Rectangle : ISP
    {
        private Point upperLeft, lowerRight;

        public Point UpperLeft
        {
            get { return upperLeft; }
            set { upperLeft = value; }
        }

        public Point LowerRight
        {
            get { return lowerRight; }
            set { lowerRight = value; }
        }

        public Rectangle(Point ul, Point lr)
        {
            upperLeft = ul;
            lowerRight = lr;
        }

        public Rectangle(Rectangle r)
        {
            upperLeft = r.upperLeft;
            lowerRight = r.lowerRight;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", upperLeft, lowerRight);
        }

        public double S()
        {

        }

        public double P()
        {
            throw new NotImplementedException();
        }
    }
}
