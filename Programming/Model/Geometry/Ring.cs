using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о кольце
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Ценрт Кольца
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Внутренний радмус кольца
        /// </summary>
        private double _radiusIn;

        /// <summary>
        /// Внешний радиус кольца
        /// </summary>
        private double _radiusEx;

        /// <summary>
        /// Возвращает площать кольца
        /// </summary>
        public double Area
        {
            get
            {
                return GetCircleArea(_radiusEx) - GetCircleArea(_radiusIn);
            }
        }

        public Point2D Center { get { return _center; } set { _center = value; } }

        /// <summary>
        /// Возращает и задает внутренний радиус кольца. Должен быть не равен 0
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает внешний радус кольца. Должен быть не равен 0
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>
        /// </summary>
        /// <param name="center">Ценрт кольца. </param>
        /// <param name="radiusInternal">Внутренний радус. Должен быть не равен</param>
        /// <param name="radiusExternal">Внешний радус. Должен быть не равен</param>
        public Ring(Point2D center, int radiusInternal, int radiusExternal)
        {
            Center = center;
            RadiusInternal = radiusInternal;
            RadiusExternal = radiusExternal;
        }

        public Ring() { }


        /// <summary>
        /// Возвращает площадь кольца
        /// </summary>
        /// <param name="radius">Радиус кольца</param>
        /// <returns>Площадь кольца</returns>
        private double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
