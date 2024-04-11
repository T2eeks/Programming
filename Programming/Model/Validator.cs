using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        { 
          if (value <=0)
                throw new ArgumentException(nameof(value));
        }

        public static void AssertOnPositiveValue(double value)
        {
            if(value <=0)
                throw new ArgumentException(nameof(value));
        }
        public static void AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
        public static void AssertValueInRange(double value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
    }
}
