using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о Песне.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Название пенси
        /// </summary>
        private string _title;

        /// <summary>
        /// Исполнитель песни.
        /// </summary>
        private string _artist;

        /// <summary>
        /// Длительность песни в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Жанр песни.
        /// </summary>
        private string _genre;


        /// <summary>
        /// Возвращает и задает название песни
        /// </summary>
        public string Title { get; set; }
       
        /// <summary>
        /// Возвращает и задает исполнителя песни
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность пенси. Должна быть не равна 0
        /// </summary>
        public int Duration
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
            get { return _duration; }
        }

        /// <summary>
        /// Возращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="artist">Исполнитель песни.</param>
        /// <param name="duration">Длительность песни. Должна быть не равна 0.</param>
        /// <param name="genre">Жанр песни.</param>
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
