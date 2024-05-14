using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Penis
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        
        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {

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

       
        /// <summary>
        /// Находит пересечения фигур. И окрашивает их в красный цвет
        /// </summary>
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

        /// <summary>
        /// Обновляет информацию о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник для обновления информации.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IdRectanglesTextBox.Text = rectangle.Id.ToString();
            PointXTextBox.Text = rectangle.Center.X.ToString();
            PointYTextBox.Text = rectangle.Center.Y.ToString();
            WidthRectanglesTextBox.Text = rectangle.Width.ToString();
            HeightRectanglesTextBox.Text = rectangle.Length.ToString();

        }
        
        /// <summary>
        /// Очищает информацию о прямоугольнике. 
        /// </summary>
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
