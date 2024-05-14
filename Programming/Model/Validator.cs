using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Выполянет проверку данных
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что значение положительное
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <exception cref="ArgumentException">Когда значение отрицательно</exception>
        public static void AssertOnPositiveValue(int value)
        { 
          if (value <=0)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет, что значение положительное
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <exception cref="ArgumentException">Когда значение отрицательно</exception>
        public static void AssertOnPositiveValue(double value)
        {
            if(value <=0)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет, что значение находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <exception cref="ArgumentException">Если значение находится вне указанного диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет, что значение находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <exception cref="ArgumentException">Если значение находится вне указанного диапазона.</exception>
        public static void AssertValueInRange(double value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
    }
}
