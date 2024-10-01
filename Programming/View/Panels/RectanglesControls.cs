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
    public partial class RectanglesControls : UserControl
    {
        private Rectangle[] _rectangle;
        private Rectangle _currentRectangle;


        public RectanglesControls()
        {
            InitializeComponent ();

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

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            int result = FindRectangleWithMaxWidth(_rectangle);
            RectanglesListBox.SelectedIndex = result;
        }

        /// <summary>
        /// Находит прямоугольник с максимальной шириной.
        /// </summary>
        /// <param name="rectangle">Массив прямоугольников.</param>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
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
    }
}
