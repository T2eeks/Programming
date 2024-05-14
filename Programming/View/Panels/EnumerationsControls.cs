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

namespace Programming.View.Panels
{
    public partial class EnumerationsControls : UserControl
    {
        public EnumerationsControls()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
           
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
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
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
                        ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufacturers)).Cast<object>().ToArray());
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
