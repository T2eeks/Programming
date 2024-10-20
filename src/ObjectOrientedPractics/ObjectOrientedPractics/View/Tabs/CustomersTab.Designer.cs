namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ID = new Label();
            AddressTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 3);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 25;
            label5.Text = "Selected Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 24;
            label4.Text = "Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 127);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 22;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 74);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 21;
            label1.Text = "Full Name:";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(366, 26);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 20;
            ID.Text = "ID:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(366, 159);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(355, 123);
            AddressTextBox.TabIndex = 18;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(450, 71);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(271, 27);
            FullNameTextBox.TabIndex = 17;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(450, 26);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(161, 27);
            IdTextBox.TabIndex = 16;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(105, 496);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(96, 49);
            RemoveButton.TabIndex = 15;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 496);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(96, 49);
            AddButton.TabIndex = 14;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(3, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(340, 464);
            CustomersListBox.TabIndex = 13;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(AddressTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(CustomersListBox);
            Name = "CustomersTab";
            Size = new Size(1232, 585);
            Click += CustomersTab_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label ID;
        private TextBox AddressTextBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
    }
}
