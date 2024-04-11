using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;


        public int Hours
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 24);
                _hours = value;
            }
            get { return _hours; }
        }
        public int Minutes
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _minutes = value;
            }
            get { return _minutes; }
        }
        public int Seconds
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 60);
                _seconds = value;
            }
            get { return _seconds; }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time() { }

    }
}