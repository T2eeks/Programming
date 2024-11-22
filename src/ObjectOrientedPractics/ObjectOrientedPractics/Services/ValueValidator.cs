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
            if (value.Length >= maxLength)
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
        public static void AssertOnPositiveValue(double value,double minValue, double maxValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
                throw new ArgumentException($"{propertyName} должен быть не меньше {minValue} и не больше {maxValue} символов.");
        }

        public static void AssertOnPositiveFloatValue(float value, float minValue, float maxValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
                throw new ArgumentException($"{propertyName} должен быть не меньше {minValue} и не больше {maxValue} символов.");
        }


        /// <summary>
        ///  Проверяет, что значение находится в заданом диапозоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxValue"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, int minValue, int maxValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"{propertyName} должен быть не меньше {minValue} и не больше {maxValue}. Текущее значение: {value}");
            }
        }

        /// <summary>
        /// Проверка, входит ли целочисленное значение в заданный нижний предел.
        /// </summary>
        /// <param name="value">Входное значение.</param>
        /// <param name="minimum">Минимальное число (нижняя граница).</param>
        /// <param name="propertyName">Имя свойства класса.</param>
        public static void AssertIntOnLowerLimit(int value, int minimum, string propertyName)
        {
            if (value < minimum)
            {
                throw new
                    ArgumentException(
                    $"{propertyName} должно быть больше {minimum}.");
            }
        }


    }
}
