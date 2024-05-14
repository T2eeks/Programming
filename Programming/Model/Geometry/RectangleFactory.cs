using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о фигуре.
    /// </summary>
    internal class RectangleFactory
    {
        static Random random = new Random();

        /// <summary>
        /// Генерирует новый объект типа Rectangle.
        /// </summary>
        /// <returns>Новый сгенерированный  объект типа Rectangle.</returns>
        static public Rectangle Randomize()
        {

            return new Rectangle(random.Next(1, 101), random.Next(1, 101), "Red", random.Next(1, 609), random.Next(1, 447));
        }
    }
}
