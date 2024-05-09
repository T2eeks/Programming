using System.Drawing.Text;
using Programming;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangle;
        private Rectangle _currentRectangle;

        private Movie[] _movie;
        private Movie _currentMovie;

        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangles;

        private List<Panel> _rectanglePanels = new List<Panel>();


        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            HandleComboBox.SelectedIndex = 0;


        }

        private void Classes_Enter(object sender, EventArgs e)
        {
            Random random = new Random();
            _rectangle = new Rectangle[5];

            for (int i = 0; i < _rectangle.Length; i++)
            {
                double length = random.Next(1, 101);
                double width = random.Next(1, 101);
                int X = random.Next(1, 50);
                int Y = random.Next(1, 50);


                _rectangle[i] = new Rectangle(width, length, "Red", X, Y);
            }

            RectanglesListBox.SelectedIndex = 0;

            _movie = new Movie[5];
            for (int i = 0; i < _movie.Length; i++)
            {

                double rating = random.Next(1, 11);
                _movie[i] = new Movie("Фильм", 1, 1999, "Comedy", rating);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectEnums = EnumsListBox.SelectedItem.ToString();
            switch (selectEnums)
            {
                case "Color":

                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                        break;
                    }
                case "Seasons":

                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray());
                        break;
                    }
                case "EducationForm":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducatioForm)).Cast<object>().ToArray());
                        break;
                    }
                case "Genre":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                        break;
                    }
                case "Manufacturies":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufacturies)).Cast<object>().ToArray());
                        break;
                    }
                case "Weekday":
                    {
                        ValuesListBox.Items.Clear();
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void IntValuesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxForParsing_TextChanged(object sender, EventArgs e)
        {



        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string InputWeek = TextBoxForParsing.Text;

            if (Enum.TryParse<Weekday>(InputWeek, out Weekday weekday) && !(int.TryParse(InputWeek, out var result)))
            {
                ParsedTextBox.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                ParsedTextBox.Text = "Нет такого дня недели";
            }

        }

        private void HandleButton_Click(object sender, EventArgs e)
        {
            switch (HandleComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    {
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    }
                case "Spring":
                    {
                        ChangeColor(85, 156, 69);
                        break;
                    }
                case "Summer":
                    {
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    }
                case "Autumn":
                    {
                        ChangeColor(255, 156, 69);
                        break;
                    }
            }

        }
        private void ChangeColor(int a, int b, int c)
        {
            BackColor = System.Drawing.Color.FromArgb(a, b, c);


        }

        private void HandleGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParsedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangle[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void NewRectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                _currentRectangle = _rectangles[NewRectangleListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }


        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[RectanglesListBox.SelectedIndex].Length = Convert.ToInt32(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[RectanglesListBox.SelectedIndex].Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangle[RectanglesListBox.SelectedIndex].Color = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(Rectangle[] rectangle)
        {
            int maxIndex = 0;
            double maxWidth = 0;

            for (int i = 0; i < rectangle.Length; i++)
            {
                if (rectangle[i].Width > maxWidth)
                {
                    maxWidth = rectangle[i].Width;
                    maxIndex = i;
                }


            }
            return maxIndex;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            int result = FindRectangleWithMaxWidth(_rectangle);
            RectanglesListBox.SelectedIndex = result;
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

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            int result = FindMovieWithMaxRating(_movie);
            MoviesListBox.SelectedIndex = result;
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangle[RectanglesListBox.SelectedIndex];
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRectabgleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize();
            _rectangles.Add(newRectangle);
            NewRectangleListBox.Items.Add(newRectangle);
            NewRectangleListBox.SelectedIndex = 0;

            Panel newPanel = new Panel();

            newPanel.Location = new Point(newRectangle.Center.X - (int)newRectangle.Width / 2, newRectangle.Center.Y - (int)newRectangle.Length / 2);

            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Length;

            newPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(newPanel);

            PanelRectangles.Controls.Add(newPanel);



            FindCollisions();
        }



        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            NewRectangleListBox.SelectedIndex = 0;
            int selectedIndex = NewRectangleListBox.SelectedIndex;

            _rectangles.RemoveAt(selectedIndex);
            _rectanglePanels.RemoveAt(selectedIndex);

            NewRectangleListBox.Items.RemoveAt(selectedIndex);

            PanelRectangles.Controls.RemoveAt(selectedIndex);

            FindCollisions();
        }

        private void PointYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[NewRectangleListBox.SelectedIndex].Center.Y = Convert.ToInt32(PointYTextBox.Text);

                PointYTextBox.BackColor = System.Drawing.Color.White;
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _rectangles[NewRectangleListBox.SelectedIndex];
            }
            catch
            {
                PointYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[NewRectangleListBox.SelectedIndex].Width = Convert.ToDouble(WidthRectanglesTextBox.Text);

                WidthRectanglesTextBox.BackColor = System.Drawing.Color.White;
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _rectangles[NewRectangleListBox.SelectedIndex];
            }
            catch
            {
                WidthRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[NewRectangleListBox.SelectedIndex].Length = Convert.ToDouble(HeightRectanglesTextBox.Text);

                HeightRectanglesTextBox.BackColor = System.Drawing.Color.White;
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _rectangles[NewRectangleListBox.SelectedIndex];
            }
            catch
            {
                HeightRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void PointXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[NewRectangleListBox.SelectedIndex].Center.X = Convert.ToInt32(PointXTextBox.Text);

                PointXTextBox.BackColor = System.Drawing.Color.White;
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _rectangles[NewRectangleListBox.SelectedIndex];
            }
            catch
            {
                PointXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void HandleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);
                PanelRectangles.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 0);

            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if ((i != j) && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        PanelRectangles.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                        PanelRectangles.Controls[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 0);
                    }
                }
            }
        }

        private void PointXTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[NewRectangleListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Width / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                PanelRectangles.Controls[NewRectangleListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Width / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void PointYTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[NewRectangleListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Width / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                PanelRectangles.Controls[NewRectangleListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_currentRectangle.Center.X) - (int)_currentRectangle.Width / 2, Convert.ToInt32(_currentRectangle.Center.Y) - (int)_currentRectangle.Length / 2);
                FindCollisions();
            }
            catch { }
        }

        private void WidthRectanglesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[NewRectangleListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                NewRectangleListBox.Controls[NewRectangleListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                FindCollisions();
            }
            catch { }
        }

        private void HeightRectanglesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                NewRectangleListBox.Items[NewRectangleListBox.SelectedIndex] = _currentRectangle;
                _rectanglePanels[NewRectangleListBox.SelectedIndex].Height = (int)_currentRectangle.Length;
                NewRectangleListBox.Controls[NewRectangleListBox.SelectedIndex].Height = (int)_currentRectangle.Length;
                FindCollisions();
            }
            catch { }
        }
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IdRectanglesTextBox.Text = rectangle.Id.ToString();
            PointXTextBox.Text = rectangle.Center.X.ToString();
            PointYTextBox.Text = rectangle.Center.Y.ToString();
            WidthRectanglesTextBox.Text = rectangle.Width.ToString();
            HeightRectanglesTextBox.Text = rectangle.Length.ToString();

        }
        private void ClearRectangleInfo()
        {
            IdRectanglesTextBox.Clear();
            PointXTextBox.Clear();
            PointYTextBox.Clear();
            WidthRectanglesTextBox.Clear();
            HeightRectanglesTextBox.Clear();

        }
    }






}
