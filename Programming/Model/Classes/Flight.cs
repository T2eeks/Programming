using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
     /// <summary>
     /// Хранит данные о полете.
     /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Пункт отправления рейса.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Пункт назначения рейса.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Получает и задает пункт отправления рейса.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Получает и задает пункт назначения рейса.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает вреия полета в минутах. Должно быть не равно нулю
        /// </summary>
        public int FlightTimeInMinutes 
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
            get { return _flightTimeInMinutes; }
        
        }

        /// <summary>
        /// Создает экземпряр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт отправления рейса.</param>
        /// <param name="destination">Пункт назначения рейса.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах, не равное 0</param>
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
            
        }

        public Flight() { }
    }

}
