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
            Model.Address address1 = new Model.Address();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            ID = new Label();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomersListBox = new ListBox();
            AddressControl = new Controls.AddressControl();
            AddButton = new Button();
            RemoveButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 25;
            label5.Text = "Selected Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 12);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 24;
            label4.Text = "Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 71);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 21;
            label1.Text = "Full Name:";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(4, 23);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 20;
            ID.Text = "ID:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(88, 68);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(271, 27);
            FullNameTextBox.TabIndex = 17;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(88, 23);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(161, 27);
            IdTextBox.TabIndex = 16;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(10, 35);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(274, 404);
            CustomersListBox.TabIndex = 13;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddressControl
            // 
            //address1.Apartment = null;
            //address1.Building = null;
            //address1.City = null;
            //address1.Country = null;
            //address1.Index = null;
            //address1.Street = null;
            AddressControl.Address = address1;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(4, 117);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(515, 396);
            AddressControl.TabIndex = 27;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(3, 463);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(97, 73);
            AddButton.TabIndex = 14;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(113, 463);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 73);
            RemoveButton.TabIndex = 15;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(CustomersListBox);
            panel1.Controls.Add(RemoveButton);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 564);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(AddressControl);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(FullNameTextBox);
            panel2.Controls.Add(ID);
            panel2.Location = new Point(325, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 564);
            panel2.TabIndex = 30;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(868, 585);
            Click += CustomersTab_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label1;
        private Label ID;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private ListBox CustomersListBox;
        private Controls.AddressControl AddressControl;
        private Button RemoveButton;
        private Button AddButton;
        private Panel panel1;
        private Panel panel2;
    }
}
