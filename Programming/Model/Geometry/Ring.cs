using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    internal class Ring
    {
        private Point2D _center;
        private double _radiusIn;
        private double _radiusEx;


        public double Area
        {
            get
            {
                return GetCircleArea(_radiusEx) - GetCircleArea(_radiusIn);
            }
        }

        public Point2D Center { get { return _center; } set { _center = value; } }
        public double RadiusInternal
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _radiusEx)
                    throw new ArgumentException(nameof(value));
                _radiusIn = value;
            }
            get { return _radiusIn; }
        }
        public double RadiusExternal
        {
            set
            {
                if (value < _radiusIn)
                    throw new ArgumentException(nameof(value));
                _radiusEx = value;
            }
            get { return _radiusEx; }
        }

        public Ring(Point2D center, int radiusInternal, int radiusExternal)
        {
            Center = center;
            RadiusInternal = radiusInternal;
            RadiusExternal = radiusExternal;
        }

        public Ring() { }

        private double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
