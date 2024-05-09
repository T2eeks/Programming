using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    internal class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }   
        
        public int FlightTimeInMinutes 
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
            get { return _flightTimeInMinutes; }
        
        }

        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
            
        }

        public Flight() { }
    }

}
