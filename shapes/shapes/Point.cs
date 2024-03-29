using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Point
    {

        private int pX, pY;

        public int PX 
        {             
            get { return pX; }
            set { pX = value; }
        }

        public int PY
        {
            get { return pY; }
            set { pY = value; }
        }

        public Point(int x, int y)
        {
            pX = x;
            pY = y;
        }

        public Point(Point p)
        {
            pX = p.pX;
            pY = p.pY;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", pX, pY);
        }

    }
}
