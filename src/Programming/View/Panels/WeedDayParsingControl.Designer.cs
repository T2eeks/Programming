namespace Programming.View.Panels
{
    partial class WeedDayParsingControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ParsingGroupBox = new GroupBox();
            ParsedTextBox = new TextBox();
            ParseButton = new Button();
            TextBoxForParsing = new TextBox();
            label4 = new Label();
            ParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(ParsedTextBox);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(TextBoxForParsing);
            ParsingGroupBox.Controls.Add(label4);
            ParsingGroupBox.Location = new Point(3, 19);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(331, 125);
            ParsingGroupBox.TabIndex = 8;
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
            // WeedDayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParsingGroupBox);
            Name = "WeedDayParsingControl";
            Size = new Size(341, 149);
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ParsingGroupBox;
        private TextBox ParsedTextBox;
        private Button ParseButton;
        private TextBox TextBoxForParsing;
        private Label label4;
    }
}
