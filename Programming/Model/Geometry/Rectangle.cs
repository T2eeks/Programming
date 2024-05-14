using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming 
{ 
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Точка, определяющая положение прямоугольника.
        /// </summary>
        private Point2D _point;

        /// <summary>
        /// Общее количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private int _id;



        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть не равна 0
        /// </summary>
        public double Length
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
            get { return _length; }
        }

        /// <summary>
        /// Возвращает и задает Ширину. Должна быть не равна 0
        /// </summary>
        public double Width
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
            get { return _width; }
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника. Должен быть из перечисления.
        /// </summary>
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

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает точка, определяющую положение прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>

        /// <summary>
        /// Возвращает общее количество созданных прямоугольников.
        /// </summary>
        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть не равна 0</param>
        /// <param name="width">Ширина прямоугольника. Должна быть не равна 0.</param>
        /// <param name="color">Цвет прямоугольника. Должен быть из перечисления</param>
        /// <param name="X">Координата X центра прямоугольника. Должна быть не равна 0</param>
        /// <param name="Y">Координата Y центра прямоугольника. Должна быть не равна 0</param>
        public Rectangle(double lenght, double width, string color, int X, int Y)
        {
            Length = lenght;
            Width = width;
            Color = color;
            Center = new Point2D(X, Y);
            _id = _allRectanglesCount++;
        }
        public Rectangle() { }

        /// <summary>
        /// Возвращает строковое представление объекта прямоугольника.
        /// </summary>
        /// <returns>Строковое представление объекта прямоугольника.</returns>
        public override string ToString()
        {
            return $" ID; {Id}; X; {Center.X}; Y; {Center.Y}; H; {_length}; W;{_width}; ";
        }

    }
}
