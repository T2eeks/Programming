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
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 34);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(390, 544);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.Click += ItemsListBox_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 601);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(134, 75);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(143, 601);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(134, 75);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(487, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(161, 27);
            IdTextBox.TabIndex = 3;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(487, 79);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(161, 27);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(487, 135);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(514, 149);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(487, 328);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(514, 149);
            DescriptionTextBox.TabIndex = 6;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(417, 34);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 7;
            ID.Text = "ID:";
            ID.Click += ID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 79);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 8;
            label1.Text = "Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 138);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 305);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 11;
            label4.Text = "Items";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 11);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 12;
            label5.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(CostTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemsListBox);
            Name = "ItemsTab";
            Size = new Size(1014, 711);
            Click += ItemsTab_Click;
            ResumeLayout(false);
            PerformLayout();
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
    }
}
