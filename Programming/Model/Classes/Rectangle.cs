using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private Point2D _point;

        public double Length
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
            get { return _length; }
        }
        public double Width
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
            get { return _width; }
        }
        public string Color
        {
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Color>(value, out var color))
                    throw new ArgumentException();
                _color = value;
            }
            get { return _color; }
        }

        public Point2D Center {get; set;}

        public Rectangle(double lenght, double width, string color, Point2D center)
        {
            Length = lenght;
            Width = width;
            Color = color;
            Center = center;
        }
        public Rectangle() { }

    }
}
