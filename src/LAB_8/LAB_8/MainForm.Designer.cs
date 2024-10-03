namespace LAB_8
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
            ProductListBox = new ListBox();
            CreateButton = new Button();
            ChangeButton = new Button();
            DeleteButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameTextBox = new TextBox();
            ManufacturerTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            QuantityTextBox = new TextBox();
            SuspendLayout();
            // 
            // ProductListBox
            // 
            ProductListBox.FormattingEnabled = true;
            ProductListBox.ItemHeight = 20;
            ProductListBox.Location = new Point(12, 23);
            ProductListBox.Name = "ProductListBox";
            ProductListBox.Size = new Size(357, 384);
            ProductListBox.TabIndex = 0;
            ProductListBox.SelectedIndexChanged += ProductListBox_SelectedIndexChanged;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(12, 413);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(73, 29);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(91, 413);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(73, 29);
            ChangeButton.TabIndex = 2;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(170, 413);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(73, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Name;";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 65);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Manufacturer; ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 110);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Сategory;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 156);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "Quantity;";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(483, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(246, 27);
            NameTextBox.TabIndex = 8;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // ManufacturerTextBox
            // 
            ManufacturerTextBox.Location = new Point(483, 65);
            ManufacturerTextBox.Name = "ManufacturerTextBox";
            ManufacturerTextBox.Size = new Size(151, 27);
            ManufacturerTextBox.TabIndex = 9;
            ManufacturerTextBox.TextChanged += ManufacturerTextBox_TextChanged;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Electronics", "Clothes", "Foodstuffs", "Cosmetics", "Furniture", "Books" });
            CategoryComboBox.Location = new Point(483, 107);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 10;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(483, 156);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(56, 27);
            QuantityTextBox.TabIndex = 11;
            QuantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QuantityTextBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(ManufacturerTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(ChangeButton);
            Controls.Add(CreateButton);
            Controls.Add(ProductListBox);
            Name = "MainForm";
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ProductListBox;
        private Button CreateButton;
        private Button ChangeButton;
        private Button DeleteButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTextBox;
        private TextBox ManufacturerTextBox;
        private ComboBox CategoryComboBox;
        private TextBox QuantityTextBox;
    }
}
