using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Выполняает проверку данных 
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет, что значение болжительное и не более максимального значения
        /// </summary>
        /// <param name="value"> Проверяемое значение</param>
        /// <param name="maxLength">Максимальное значение </param>
        /// <param name="propertyName">Название значения</param>
        /// <exception cref="ArgumentException">Когда значение больше максимального</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{nameof(propertyName)} должен быть не больше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет, что строка не содержит более масимального колличества символов
        /// </summary>
        /// <param name="value"> Проверяемое значение</param>
        /// <param name="maxLength">Максимальное значение </param>
        /// <param name="propertyName">Название значения</param>
        /// <exception cref="ArgumentException">Когда значение больше максимального</exception>
        public static void AssertOnPositiveValue(double value, double maxValue, string propertyName)
        {
            if (value <= 0 || value > maxValue)
                throw new ArgumentException($"{nameof(propertyName)} должен быть не меньше 0 и не больше {maxValue} символов.");
        }
    }
}
