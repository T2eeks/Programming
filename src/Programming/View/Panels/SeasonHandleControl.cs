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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            HandleComboBox.SelectedIndex = 0;
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
    }
}
