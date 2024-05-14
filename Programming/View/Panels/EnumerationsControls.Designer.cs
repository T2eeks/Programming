namespace Programming.View.Panels
{
    partial class EnumerationsControls
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
            EnumerationsGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ValuesListBox = new ListBox();
            IntValuesTextBox = new TextBox();
            EnumerationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Controls.Add(label1);
            EnumerationsGroupBox.Controls.Add(label2);
            EnumerationsGroupBox.Controls.Add(label3);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(IntValuesTextBox);
            EnumerationsGroupBox.Location = new Point(3, 16);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(604, 275);
            EnumerationsGroupBox.TabIndex = 7;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 22);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose Value;";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 22);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Int Value;";
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
            // 
            // EnumerationsControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsGroupBox);
            Name = "EnumerationsControls";
            Size = new Size(616, 303);
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsGroupBox;
        private ListBox EnumsListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox ValuesListBox;
        private TextBox IntValuesTextBox;
    }
}
