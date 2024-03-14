using System.Drawing.Text;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            HandleComboBox.SelectedIndex = 0;


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
            EnumerationsGroupBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            ParsingGroupBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            HandleGroupBox.BackColor = System.Drawing.Color.FromArgb(a, b, c);

        }

        private void HandleGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
