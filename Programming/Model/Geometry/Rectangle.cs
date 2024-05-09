using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming 
{ 
    internal class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private Point2D _point;
        private static int _allRectanglesCount = 0;
        private int _id;

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
        public int Id
        {
            get { return _id; }
        }

        public Point2D Center { get; set; }

        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        public Rectangle(double lenght, double width, string color, int X, int Y)
        {
            Length = lenght;
            Width = width;
            Color = color;
            Center = new Point2D(X, Y);
            _id = _allRectanglesCount++;
        }
        public Rectangle() { }

        public override string ToString()
        {
            return $" ID; {Id}; X; {Center.X}; Y; {Center.Y}; H; {_length}; W;{_width}; ";
        }

    }
}
