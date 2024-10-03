namespace Programming.View.Panels
{
    partial class RectanglesControls
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
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
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
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(520, 310);
            RectanglesGroupBox.TabIndex = 1;
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
            // RectanglesControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesControls";
            Size = new Size(529, 318);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private TextBox IdTextBox;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox YTextBox;
        private Label label12;
        private TextBox XTextBox;
        private Button RectangleButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private ListBox RectanglesListBox;
    }
}
