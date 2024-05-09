using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        public int Y
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
            get { return _y; }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point2D() { }
    }
}
