using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    internal class Movie
    {
        private string _title;
        private int _durationInMinutes;
        private int _releaseYear;
        private string _genre;
        private double _rating;

        public string Title { get; set; }

        public int DurationInMinutes
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
            get { return _durationInMinutes; }
        }

        public int ReleaseYear
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _releaseYear = value;
            }
            get { return _releaseYear; }
        }
        public string Genre
        {
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Genre>(value, out var genre))
                    throw new ArgumentException();
                _genre = value;
            }
            get { return _genre; }
        }
        public double Rating
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 10);
                _rating = value;
            }
            get { return _rating; }
        }

        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
           
        }
        public Movie() { }
    }
}
