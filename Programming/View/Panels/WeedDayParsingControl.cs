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
    public partial class WeedDayParsingControl : UserControl
    {
        public WeedDayParsingControl()
        {
            InitializeComponent();
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
    }
}
