using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model
{
    internal class Point2D
    {
        private readonly int _x;
        private readonly int _y;

        public int X
        {
            get { return _x; }
            private set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }

        public int Y
        {
             private set
            {
                Validator.AssertOnPositiveValue(value);
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
