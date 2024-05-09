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
            Classes = new TabPage();
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
            IdTextBox = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            YTextBox = new TextBox();
            label12 = new Label();
            XTextBox = new TextBox();
            RectangleButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            Rectangles = new TabPage();
            HeightRectanglesTextBox = new TextBox();
            WidthRectanglesTextBox = new TextBox();
            PointYTextBox = new TextBox();
            PointXTextBox = new TextBox();
            PanelRectangles = new Panel();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            IdRectanglesTextBox = new TextBox();
            label16 = new Label();
            AddRectabgleButton = new Button();
            DeleteRectangleButton = new Button();
            NewRectangleListBox = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Enums.SuspendLayout();
            Enumss.SuspendLayout();
            HandleGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            Classes.SuspendLayout();
            MovieGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(Enumss);
            Enums.Controls.Add(Classes);
            Enums.Controls.Add(Rectangles);
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
            HandleComboBox.SelectedIndexChanged += HandleComboBox_SelectedIndexChanged;
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
            // Classes
            // 
            Classes.Controls.Add(MovieGroupBox);
            Classes.Controls.Add(checkedListBox1);
            Classes.Controls.Add(RectanglesGroupBox);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(920, 452);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            Classes.Enter += Classes_Enter;
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
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(label15);
            RectanglesGroupBox.Controls.Add(label14);
            RectanglesGroupBox.Controls.Add(label13);
            RectanglesGroupBox.Controls.Add(YTextBox);
            RectanglesGroupBox.Controls.Add(label12);
            RectanglesGroupBox.Controls.Add(XTextBox);
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
            RectanglesGroupBox.Size = new Size(520, 310);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(329, 54);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 9;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(329, 26);
            label15.Name = "label15";
            label15.Size = new Size(25, 20);
            label15.TabIndex = 8;
            label15.Text = "Id;";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(249, 219);
            label14.Name = "label14";
            label14.Size = new Size(20, 20);
            label14.TabIndex = 3;
            label14.Text = "Y;";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(186, 219);
            label13.Name = "label13";
            label13.Size = new Size(21, 20);
            label13.TabIndex = 3;
            label13.Text = "X;";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(271, 216);
            YTextBox.Name = "YTextBox";
            YTextBox.ReadOnly = true;
            YTextBox.Size = new Size(40, 27);
            YTextBox.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(186, 193);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 7;
            label12.Text = "Center;";
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(207, 216);
            XTextBox.Name = "XTextBox";
            XTextBox.ReadOnly = true;
            XTextBox.Size = new Size(36, 27);
            XTextBox.TabIndex = 3;
            XTextBox.TextChanged += XTextBox_TextChanged;
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(186, 249);
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
            RectanglesListBox.Size = new Size(174, 264);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(HeightRectanglesTextBox);
            Rectangles.Controls.Add(WidthRectanglesTextBox);
            Rectangles.Controls.Add(PointYTextBox);
            Rectangles.Controls.Add(PointXTextBox);
            Rectangles.Controls.Add(PanelRectangles);
            Rectangles.Controls.Add(label22);
            Rectangles.Controls.Add(label21);
            Rectangles.Controls.Add(label20);
            Rectangles.Controls.Add(label19);
            Rectangles.Controls.Add(label18);
            Rectangles.Controls.Add(label17);
            Rectangles.Controls.Add(IdRectanglesTextBox);
            Rectangles.Controls.Add(label16);
            Rectangles.Controls.Add(AddRectabgleButton);
            Rectangles.Controls.Add(DeleteRectangleButton);
            Rectangles.Controls.Add(NewRectangleListBox);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(920, 452);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // HeightRectanglesTextBox
            // 
            HeightRectanglesTextBox.Location = new Point(86, 409);
            HeightRectanglesTextBox.Name = "HeightRectanglesTextBox";
            HeightRectanglesTextBox.Size = new Size(125, 27);
            HeightRectanglesTextBox.TabIndex = 20;
            HeightRectanglesTextBox.TextChanged += HeightRectanglesTextBox_TextChanged;
            HeightRectanglesTextBox.Leave += HeightRectanglesTextBox_Leave;
            // 
            // WidthRectanglesTextBox
            // 
            WidthRectanglesTextBox.Location = new Point(86, 370);
            WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            WidthRectanglesTextBox.Size = new Size(125, 27);
            WidthRectanglesTextBox.TabIndex = 19;
            WidthRectanglesTextBox.TextChanged += WidthRectanglesTextBox_TextChanged;
            WidthRectanglesTextBox.Leave += WidthRectanglesTextBox_Leave;
            // 
            // PointYTextBox
            // 
            PointYTextBox.Location = new Point(86, 328);
            PointYTextBox.Name = "PointYTextBox";
            PointYTextBox.Size = new Size(125, 27);
            PointYTextBox.TabIndex = 18;
            PointYTextBox.TextChanged += PointYTextBox_TextChanged;
            PointYTextBox.Leave += PointYTextBox_Leave;
            // 
            // PointXTextBox
            // 
            PointXTextBox.Location = new Point(86, 290);
            PointXTextBox.Name = "PointXTextBox";
            PointXTextBox.Size = new Size(125, 27);
            PointXTextBox.TabIndex = 17;
            PointXTextBox.TextChanged += PointXTextBox_TextChanged;
            PointXTextBox.Leave += PointXTextBox_Leave;
            // 
            // PanelRectangles
            // 
            PanelRectangles.BorderStyle = BorderStyle.FixedSingle;
            PanelRectangles.Dock = DockStyle.Right;
            PanelRectangles.Location = new Point(309, 3);
            PanelRectangles.Name = "PanelRectangles";
            PanelRectangles.Size = new Size(608, 446);
            PanelRectangles.TabIndex = 16;
            PanelRectangles.Paint += panel1_Paint;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 11);
            label22.Name = "label22";
            label22.Size = new Size(84, 20);
            label22.TabIndex = 15;
            label22.Text = "Rectangles;";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(11, 373);
            label21.Name = "label21";
            label21.Size = new Size(52, 20);
            label21.TabIndex = 10;
            label21.Text = "Width;";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 412);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 9;
            label20.Text = "Height;";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 335);
            label19.Name = "label19";
            label19.Size = new Size(20, 20);
            label19.TabIndex = 8;
            label19.Text = "Y;";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 297);
            label18.Name = "label18";
            label18.Size = new Size(21, 20);
            label18.TabIndex = 7;
            label18.Text = "X;";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 257);
            label17.Name = "label17";
            label17.Size = new Size(25, 20);
            label17.TabIndex = 6;
            label17.Text = "id;";
            // 
            // IdRectanglesTextBox
            // 
            IdRectanglesTextBox.Location = new Point(86, 257);
            IdRectanglesTextBox.Name = "IdRectanglesTextBox";
            IdRectanglesTextBox.ReadOnly = true;
            IdRectanglesTextBox.Size = new Size(125, 27);
            IdRectanglesTextBox.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 227);
            label16.Name = "label16";
            label16.Size = new Size(139, 20);
            label16.TabIndex = 4;
            label16.Text = "Selected Rectangle;";
            // 
            // AddRectabgleButton
            // 
            AddRectabgleButton.FlatStyle = FlatStyle.Flat;
            AddRectabgleButton.Location = new Point(11, 194);
            AddRectabgleButton.Name = "AddRectabgleButton";
            AddRectabgleButton.Size = new Size(85, 29);
            AddRectabgleButton.TabIndex = 3;
            AddRectabgleButton.Text = "ADD";
            AddRectabgleButton.UseVisualStyleBackColor = true;
            AddRectabgleButton.Click += AddRectabgleButton_Click;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(126, 195);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(85, 29);
            DeleteRectangleButton.TabIndex = 2;
            DeleteRectangleButton.Text = "DELETE";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // NewRectangleListBox
            // 
            NewRectangleListBox.FormattingEnabled = true;
            NewRectangleListBox.Location = new Point(8, 34);
            NewRectangleListBox.Name = "NewRectangleListBox";
            NewRectangleListBox.Size = new Size(262, 144);
            NewRectangleListBox.TabIndex = 0;
            NewRectangleListBox.SelectedIndexChanged += NewRectangleListBox_SelectedIndexChanged;
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
            Classes.ResumeLayout(false);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
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
        private TabPage Classes;
        private CheckedListBox checkedListBox1;
        private GroupBox RectanglesGroupBox;
        private ListBox NewRectangleListBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox PointyRectangles;
        private TextBox PointxRectangles;
        private TextBox YTextBox;
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
        private Label label12;
        private TextBox XTextBox;
        private Label label14;
        private Label label13;
        private TextBox IdTextBox;
        private Label label15;
        private TabPage Rectangles;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox IdRectanglesTextBox;
        private Label label16;
        private Button AddRectabgleButton;
        private Button DeleteRectangleButton;
        private ListBox listBox2;
        private TextBox textBox5;
        private TextBox RectanglesWidthTextBox;
        private Panel PanelRectangles;
        private Label label22;
        private TextBox PointXTextBox;
        private TextBox WidthRectanglesTextBox;
        private TextBox PointYTextBox;
        private TextBox HeightRectanglesTextBox;
    }
}
