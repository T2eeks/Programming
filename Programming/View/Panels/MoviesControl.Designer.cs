namespace Programming.View.Panels
{
    partial class MoviesControl
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
            MovieGroupBox.SuspendLayout();
            SuspendLayout();
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
            MovieGroupBox.Location = new Point(3, 3);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(378, 271);
            MovieGroupBox.TabIndex = 4;
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
            MoviesButton.Click += MoviesButton_Click_1;
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
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(186, 109);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(186, 54);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(125, 27);
            TitleTextBox.TabIndex = 1;
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
            checkedListBox1.Location = new Point(199, 252);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 3;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MovieGroupBox);
            Controls.Add(checkedListBox1);
            Name = "MoviesControl";
            Size = new Size(394, 289);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MovieGroupBox;
        private Button MoviesButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox GenreTextBox;
        private TextBox RatingTextBox;
        private TextBox TitleTextBox;
        private ListBox MoviesListBox;
        private CheckedListBox checkedListBox1;
    }
}
