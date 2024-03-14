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
            Enums.SuspendLayout();
            Enumss.SuspendLayout();
            HandleGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(Enumss);
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
            HandleButton.Size = new Size(71, 24);
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
            label4.Size = new Size(153, 20);
            label4.TabIndex = 8;
            label4.Text = "Tipe value for parsing";
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
    }
}
