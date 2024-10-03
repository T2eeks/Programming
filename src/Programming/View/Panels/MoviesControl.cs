using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {

        private Movie[] _movie;
        private Movie _currentMovie;

        public MoviesControl()
        {
            InitializeComponent();

            Random random = new Random();

            _movie = new Movie[5];
            for (int i = 0; i < _movie.Length; i++)
            {

                double rating = random.Next(1, 11);
                _movie[i] = new Movie("Фильм", 1, 1999, "Comedy", rating);
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _currentMovie = _movie[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movie[MoviesListBox.SelectedIndex].Title = TitleTextBox.Text;
                TitleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                TitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movie[MoviesListBox.SelectedIndex].Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movie[MoviesListBox.SelectedIndex].Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Находит фильм с максимальным рейтигом.
        /// </summary>
        /// <param name="rectangle">Массив фильмов.</param>
        /// <returns>Индекс филльма с максимальным рейтингом.</returns>
        private int FindMovieWithMaxRating(Movie[] movie)
        {
            int maxIndex = 0;
            double maxRating = 0;

            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Rating > maxRating)
                {
                    maxRating = movie[i].Rating;
                    maxIndex = i;
                }


            }
            return maxIndex;
        }
        private void MoviesButton_Click_1(object sender, EventArgs e)
        {

            int result = FindMovieWithMaxRating(_movie);
            MoviesListBox.SelectedIndex = result;
        }
    }
}
