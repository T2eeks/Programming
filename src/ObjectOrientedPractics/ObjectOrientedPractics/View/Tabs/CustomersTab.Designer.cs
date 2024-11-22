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
            panel3 = new Panel();
            DiscountsTableLayoutPanel = new TableLayoutPanel();
            AddDiscountButton = new Button();
            RemoveDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            DiscountsLabel = new Label();
            IsPriorityCheckBox = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            DiscountsTableLayoutPanel.SuspendLayout();
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
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(10, 35);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(278, 404);
            CustomersListBox.TabIndex = 13;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddressControl
            // 

            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(3, 148);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(515, 250);
            AddressControl.TabIndex = 27;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(13, 476);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 63);
            AddButton.TabIndex = 14;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(177, 476);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 63);
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
            panel1.Size = new Size(297, 564);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(IsPriorityCheckBox);
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(DiscountsTableLayoutPanel);
            panel3.Controls.Add(DiscountsListBox);
            panel3.Controls.Add(DiscountsLabel);
            panel3.Location = new Point(4, 404);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 160);
            panel3.TabIndex = 29;
            // 
            // DiscountsTableLayoutPanel
            // 
            DiscountsTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountsTableLayoutPanel.ColumnCount = 1;
            DiscountsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DiscountsTableLayoutPanel.Controls.Add(AddDiscountButton, 0, 0);
            DiscountsTableLayoutPanel.Controls.Add(RemoveDiscountButton, 0, 1);
            DiscountsTableLayoutPanel.Location = new Point(331, 24);
            DiscountsTableLayoutPanel.Margin = new Padding(4);
            DiscountsTableLayoutPanel.Name = "DiscountsTableLayoutPanel";
            DiscountsTableLayoutPanel.RowCount = 2;
            DiscountsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DiscountsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DiscountsTableLayoutPanel.Size = new Size(137, 111);
            DiscountsTableLayoutPanel.TabIndex = 17;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(4, 4);
            AddDiscountButton.Margin = new Padding(4);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(129, 47);
            AddDiscountButton.TabIndex = 16;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Location = new Point(4, 59);
            RemoveDiscountButton.Margin = new Padding(4);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(129, 48);
            RemoveDiscountButton.TabIndex = 17;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsListBox.Enabled = false;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 20;
            DiscountsListBox.Location = new Point(7, 24);
            DiscountsListBox.Margin = new Padding(4);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(316, 104);
            DiscountsListBox.TabIndex = 16;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountsLabel.Location = new Point(6, 0);
            DiscountsLabel.Margin = new Padding(4, 0, 4, 0);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(73, 20);
            DiscountsLabel.TabIndex = 14;
            DiscountsLabel.Text = "Discounts";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(88, 111);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(92, 24);
            IsPriorityCheckBox.TabIndex = 28;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(868, 585);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            DiscountsTableLayoutPanel.ResumeLayout(false);
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
        private CheckBox IsPriorityCheckBox;
        private Panel panel3;
        private Label DiscountsLabel;
        private TableLayoutPanel DiscountsTableLayoutPanel;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
        private ListBox DiscountsListBox;
    }
}
