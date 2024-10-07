using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{nameof(propertyName)} должен быть не больше {maxLength} символов.");
            }
        }

        public static void AssertOnPositiveValue(double value, double maxValue, string propertyName)
        {
            if (value <= 0 || value > maxValue)
                throw new ArgumentException($"{nameof(propertyName)} должен быть не меньше 0 и не больше {maxValue} символов.");
        }
    }
}
