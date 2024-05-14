using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о центре фигуры
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// точка x
        /// </summary>
        private int _x;
        /// <summary>
        /// точка y
        /// </summary>
        private int _y;


        /// <summary>
        /// Возвращает и задает точку x. Должна быть не равна 0.
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает точку y. Должна быть не равна 0.
        /// </summary>
        public int Y
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
            get { return _y; }
        }


        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Точка x. Должна быть не равна 0. </param>
        /// <param name="y">Точка y. Должна быть не равна 0.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point2D() { }
    }
}
