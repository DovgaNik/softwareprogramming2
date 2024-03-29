using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Circle
    {
        private Point center;
        private int radius;

        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(Point c, int r)
        {
            center = c;
            radius = r;
        }

        public Circle(Circle c)
        {
            center = c.center;
            radius = c.radius;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", center, radius);
        }
    }
}
