using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о пересечении прямоугольников
    /// </summary>
    internal class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник</param>
        /// <returns>Возвращает true, есть пересечение .И false, если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double hfWidth = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double hfHeight = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;


            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            return dX < hfWidth && dY < hfHeight;

        }

        /// <summary>
        /// Проверяет есть ли пересечение между двумя кругами
        /// </summary>
        /// <param name="ring1">Первый круг.</param>
        /// <param name="ring2">Второй круг.</param>
        /// <returns>Возвращает true, если есть , пересечение .И false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double distance = Math.Sqrt(Math.Pow(ring2.Center.X - ring1.Center.X, 2) + Math.Pow(ring2.Center.Y - ring1.Center.Y, 2));

            return distance < ring1.RadiusExternal + ring2.RadiusExternal;
        }
    }
}
