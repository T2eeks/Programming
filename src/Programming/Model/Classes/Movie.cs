using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Programming;

namespace Programming
{
    /// <summary>
    /// Хранит данные о Фильме.
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает Название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должно быть не равным 0
        /// </summary>
        public int DurationInMinutes
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
            get { return _durationInMinutes; }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма. Должно быть не равным 0
        /// </summary>
        public int ReleaseYear
        {
            set
            {
                Validator.AssertOnPositiveValue(value);
                _releaseYear = value;
            }
            get { return _releaseYear; }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма. Должно принадлежать перечислению
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должно быть от 0 до 10
        /// </summary>
        public double Rating
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 10);
                _rating = value;
            }
            get { return _rating; }
        }

        /// <summary>
        /// Создает новый экземпляр класса Movie <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность фильма в минутах. Должна быть не равна 0</param>
        /// <param name="releaseYear">Год выпуска фильма. Долен быть не равным 0</param>
        /// <param name="genre">Жанр фильма. Должен принадлежать перечислению</param>
        /// <param name="rating">Рейтинг фильма.Должен быть от 0 до 10</param>
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
