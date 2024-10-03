using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    /// <summary>
    /// Выполняает проверку данных 
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что строка не содержит более 100 символов
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <exception cref="ArgumentException">Когда строка содержит более 100 символов </exception>

        public static void AssertStringInRange(string value)
        {
            
            if(value.Length > 100 || value.Length <= 0)
            {
                throw new ArgumentException(nameof(value));
            }
        }

        /// <summary>
        /// Проверяет, что значение положительное
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <exception cref="ArgumentException">Когда значение отрицательно</exception>
        public static void AssertOnPositiveValue(int value)
        {
            if (value <= 0)
                throw new ArgumentException(nameof(value));

        }

    }
}
