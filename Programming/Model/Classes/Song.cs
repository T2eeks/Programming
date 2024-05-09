using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    internal class Song
    {
        private string _title;
        private string _artist;
        private int _duration;
        private string _genre;

        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
            get { return _duration; }
        }
        public string Genre { get; set; }

        public Song(string title, string artist, int duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        } 
        public Song () { }
    }
}
