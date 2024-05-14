using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о временм
    /// </summary>
    internal class Time
    {

        /// <summary>
        /// Часы
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает  часы. Должгы быть в промежутке от 0 до 24 
        /// </summary>
        public int Hours
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 24);
                _hours = value;
            }
            get { return _hours; }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть в промежутке от 0 до 60.
        /// </summary>
        public int Minutes
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _minutes = value;
            }
            get { return _minutes; }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть в промежутке от 0 до 60
        /// </summary>
        public int Seconds
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _seconds = value;
            }
            get { return _seconds; }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Должгы быть в промежутке от 0 до 24 </param>
        /// <param name="minutes">Минуты.Должгы быть в промежутке от 0 до 60 </param>
        /// <param name="seconds">Секунды.Должгы быть в промежутке от 0 до 60</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time() { }

    }
}