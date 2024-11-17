namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
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
            ItemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            ID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            CategoryComboBox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(375, 384);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.Click += ItemsListBox_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(13, 464);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 63);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(158, 464);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 63);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(80, 26);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(47, 27);
            IdTextBox.TabIndex = 3;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(80, 68);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(205, 27);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(7, 189);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(407, 79);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(7, 367);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(407, 79);
            DescriptionTextBox.TabIndex = 6;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(7, 26);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 7;
            ID.Text = "ID:";
            ID.Click += ID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 68);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 8;
            label1.Text = "Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 168);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 335);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 11;
            label4.Text = "Items";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 3);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 12;
            label5.Text = "Selected Item";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(RemoveButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 582);
            panel1.TabIndex = 13;
            panel1.Click += panel2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(CategoryComboBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ID);
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CostTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(398, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 582);
            panel2.TabIndex = 14;
            panel2.Click += panel2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 121);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 14;
            label6.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Electronics,", "Clothes,", "Foodstuffs,", "Cosmetics,", "Furniture,", "Books,", "Decorations" });
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(80, 118);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 13;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemsTab";
            Size = new Size(868, 585);
            Click += ItemsTab_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private Label ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private ComboBox CategoryComboBox;
    }
}
