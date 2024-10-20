namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CityTextBox);
            panel1.Controls.Add(ApartmentTextBox);
            panel1.Controls.Add(BuildingTextBox);
            panel1.Controls.Add(StreetTextBox);
            panel1.Controls.Add(CountryTextBox);
            panel1.Controls.Add(PostIndexTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 249);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 97);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 13;
            label8.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 203);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 12;
            label7.Text = "Apartment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 203);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 11;
            label6.Text = "Building";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 145);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Street";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 49);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Post Index";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(367, 93);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 7;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(367, 200);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(125, 27);
            ApartmentTextBox.TabIndex = 6;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(90, 196);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(125, 27);
            BuildingTextBox.TabIndex = 5;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(90, 141);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(402, 27);
            StreetTextBox.TabIndex = 4;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(90, 89);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(205, 27);
            CountryTextBox.TabIndex = 3;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(90, 46);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(125, 27);
            PostIndexTextBox.TabIndex = 2;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddressControl";
            Size = new Size(528, 261);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
    }
}
