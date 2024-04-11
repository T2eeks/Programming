namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Enums = new TabControl();
            Enumss = new TabPage();
            HandleGroupBox = new GroupBox();
            HandleComboBox = new ComboBox();
            HandleButton = new Button();
            label5 = new Label();
            ParsingGroupBox = new GroupBox();
            ParsedTextBox = new TextBox();
            ParseButton = new Button();
            TextBoxForParsing = new TextBox();
            label4 = new Label();
            EnumerationsGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ValuesListBox = new ListBox();
            IntValuesTextBox = new TextBox();
            tabPage1 = new TabPage();
            MovieGroupBox = new GroupBox();
            MoviesButton = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            GenreTextBox = new TextBox();
            RatingTextBox = new TextBox();
            TitleTextBox = new TextBox();
            MoviesListBox = new ListBox();
            checkedListBox1 = new CheckedListBox();
            RectanglesGroupBox = new GroupBox();
            RectangleButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Enums.SuspendLayout();
            Enumss.SuspendLayout();
            HandleGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            tabPage1.SuspendLayout();
            MovieGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(Enumss);
            Enums.Controls.Add(tabPage1);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(928, 485);
            Enums.TabIndex = 0;
            Enums.Tag = "";
            // 
            // Enumss
            // 
            Enumss.Controls.Add(HandleGroupBox);
            Enumss.Controls.Add(ParsingGroupBox);
            Enumss.Controls.Add(EnumerationsGroupBox);
            Enumss.Location = new Point(4, 29);
            Enumss.Name = "Enumss";
            Enumss.Padding = new Padding(3);
            Enumss.Size = new Size(920, 452);
            Enumss.TabIndex = 0;
            Enumss.Text = "Enums";
            Enumss.UseVisualStyleBackColor = true;
            // 
            // HandleGroupBox
            // 
            HandleGroupBox.Controls.Add(HandleComboBox);
            HandleGroupBox.Controls.Add(HandleButton);
            HandleGroupBox.Controls.Add(label5);
            HandleGroupBox.Location = new Point(362, 287);
            HandleGroupBox.Name = "HandleGroupBox";
            HandleGroupBox.Size = new Size(250, 125);
            HandleGroupBox.TabIndex = 8;
            HandleGroupBox.TabStop = false;
            HandleGroupBox.Text = "Season Handle;";
            HandleGroupBox.Enter += HandleGroupBox_Enter;
            // 
            // HandleComboBox
            // 
            HandleComboBox.FormattingEnabled = true;
            HandleComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            HandleComboBox.Location = new Point(0, 46);
            HandleComboBox.Name = "HandleComboBox";
            HandleComboBox.Size = new Size(151, 28);
            HandleComboBox.TabIndex = 3;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(162, 46);
            HandleButton.Name = "HandleButton";
            HandleButton.Size = new Size(71, 32);
            HandleButton.TabIndex = 2;
            HandleButton.Text = "Go";
            HandleButton.UseVisualStyleBackColor = true;
            HandleButton.Click += HandleButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 23);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Choose Season";
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(ParsedTextBox);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(TextBoxForParsing);
            ParsingGroupBox.Controls.Add(label4);
            ParsingGroupBox.Location = new Point(11, 287);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(331, 125);
            ParsingGroupBox.TabIndex = 7;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "Weekday Parsing;";
            // 
            // ParsedTextBox
            // 
            ParsedTextBox.Location = new Point(6, 79);
            ParsedTextBox.Name = "ParsedTextBox";
            ParsedTextBox.ReadOnly = true;
            ParsedTextBox.Size = new Size(219, 27);
            ParsedTextBox.TabIndex = 11;
            ParsedTextBox.TextChanged += ParsedTextBox_TextChanged;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(149, 46);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(76, 27);
            ParseButton.TabIndex = 10;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // TextBoxForParsing
            // 
            TextBoxForParsing.Location = new Point(6, 46);
            TextBoxForParsing.Name = "TextBoxForParsing";
            TextBoxForParsing.Size = new Size(125, 27);
            TextBoxForParsing.TabIndex = 9;
            TextBoxForParsing.TextChanged += TextBoxForParsing_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 8;
            label4.Text = "Type value for parsing";
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Controls.Add(label1);
            EnumerationsGroupBox.Controls.Add(label2);
            EnumerationsGroupBox.Controls.Add(label3);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(IntValuesTextBox);
            EnumerationsGroupBox.Location = new Point(8, 6);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(604, 275);
            EnumerationsGroupBox.TabIndex = 6;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.BackColor = SystemColors.Window;
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufacturies", "Seasons", "Weekday" });
            EnumsListBox.Location = new Point(3, 45);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(150, 224);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 23);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 2;
            label1.Text = "Choose Enumaration;";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 22);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose Value;";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 22);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Int Value;";
            label3.Click += label3_Click;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(184, 45);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 224);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // IntValuesTextBox
            // 
            IntValuesTextBox.Location = new Point(354, 45);
            IntValuesTextBox.Name = "IntValuesTextBox";
            IntValuesTextBox.Size = new Size(125, 27);
            IntValuesTextBox.TabIndex = 4;
            IntValuesTextBox.TextChanged += IntValuesTextBox_TextChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(MovieGroupBox);
            tabPage1.Controls.Add(checkedListBox1);
            tabPage1.Controls.Add(RectanglesGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(920, 452);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            MovieGroupBox.Controls.Add(MoviesButton);
            MovieGroupBox.Controls.Add(label9);
            MovieGroupBox.Controls.Add(label10);
            MovieGroupBox.Controls.Add(label11);
            MovieGroupBox.Controls.Add(GenreTextBox);
            MovieGroupBox.Controls.Add(RatingTextBox);
            MovieGroupBox.Controls.Add(TitleTextBox);
            MovieGroupBox.Controls.Add(MoviesListBox);
            MovieGroupBox.Location = new Point(534, 15);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(378, 271);
            MovieGroupBox.TabIndex = 2;
            MovieGroupBox.TabStop = false;
            MovieGroupBox.Text = "Movies";
            // 
            // MoviesButton
            // 
            MoviesButton.Location = new Point(186, 221);
            MoviesButton.Name = "MoviesButton";
            MoviesButton.Size = new Size(94, 29);
            MoviesButton.TabIndex = 6;
            MoviesButton.Text = "Find";
            MoviesButton.UseVisualStyleBackColor = true;
            MoviesButton.Click += MoviesButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(186, 142);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 5;
            label9.Text = "Genre;";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 86);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 4;
            label10.Text = "Rating";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(186, 26);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 2;
            label11.Text = "Title;";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(186, 165);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 3;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(186, 109);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 2;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(186, 54);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(125, 27);
            TitleTextBox.TabIndex = 1;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3 ", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(6, 26);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(174, 224);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(730, 264);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 1;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(RectangleButton);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(8, 15);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(378, 271);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(186, 221);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(94, 29);
            RectangleButton.TabIndex = 6;
            RectangleButton.Text = "Find";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 142);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 5;
            label8.Text = "Color;";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 86);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 4;
            label7.Text = "Width;";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 26);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 2;
            label6.Text = "Length;";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(186, 165);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 3;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(186, 109);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(186, 54);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 1;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(174, 224);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 485);
            Controls.Add(Enums);
            Name = "MainForm";
            Text = "Form1";
            Enums.ResumeLayout(false);
            Enumss.ResumeLayout(false);
            HandleGroupBox.ResumeLayout(false);
            HandleGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            tabPage1.ResumeLayout(false);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Enums;
        private TabPage Enumss;
        private Label label3;
        private TextBox IntValuesTextBox;
        private Label label2;
        private Label label1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox EnumerationsGroupBox;
        private GroupBox ParsingGroupBox;
        private TextBox TextBoxForParsing;
        private Label label4;
        private GroupBox HandleGroupBox;
        private Button HandleButton;
        private Label label5;
        private Button ParseButton;
        private ComboBox HandleComboBox;
        private TextBox ParsedTextBox;
        private TabPage tabPage1;
        private CheckedListBox checkedListBox1;
        private GroupBox RectanglesGroupBox;
        private ListBox listBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox RectanglesListBox;
        private Button RectangleButton;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox MovieGroupBox;
        private Button MoviesButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox GenreTextBox;
        private TextBox RatingTextBox;
        private TextBox TitleTextBox;
        private ListBox MoviesListBox;
    }
}
