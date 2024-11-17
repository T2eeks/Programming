namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            panel1 = new Panel();
            AddCartButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            RemoveCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            CartsListBox = new ListBox();
            amountValueLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            CustomerComboBox = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(AddCartButton);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 564);
            panel1.TabIndex = 0;
            // 
            // AddCartButton
            // 
            AddCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCartButton.Location = new Point(3, 452);
            AddCartButton.Name = "AddCartButton";
            AddCartButton.Size = new Size(108, 63);
            AddCartButton.TabIndex = 2;
            AddCartButton.Text = "Add To Cart";
            AddCartButton.UseVisualStyleBackColor = true;
            AddCartButton.Click += AddCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(3, 33);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(274, 404);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Items";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(RemoveCartButton);
            panel2.Controls.Add(RemoveItemButton);
            panel2.Controls.Add(CreateOrderButton);
            panel2.Controls.Add(CartsListBox);
            panel2.Controls.Add(amountValueLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CustomerComboBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(334, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 564);
            panel2.TabIndex = 1;
            // 
            // RemoveCartButton
            // 
            RemoveCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveCartButton.Location = new Point(392, 306);
            RemoveCartButton.Name = "RemoveCartButton";
            RemoveCartButton.Size = new Size(106, 36);
            RemoveCartButton.TabIndex = 12;
            RemoveCartButton.Text = "Clear Cart";
            RemoveCartButton.UseVisualStyleBackColor = true;
            RemoveCartButton.Click += RemoveCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(263, 306);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(106, 36);
            RemoveItemButton.TabIndex = 11;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(0, 306);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(106, 36);
            CreateOrderButton.TabIndex = 10;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // CartsListBox
            // 
            CartsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartsListBox.FormattingEnabled = true;
            CartsListBox.ItemHeight = 20;
            CartsListBox.Location = new Point(3, 70);
            CartsListBox.Name = "CartsListBox";
            CartsListBox.Size = new Size(503, 164);
            CartsListBox.TabIndex = 9;
            CartsListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // amountValueLabel
            // 
            amountValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountValueLabel.AutoSize = true;
            amountValueLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amountValueLabel.Location = new Point(425, 266);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(35, 23);
            amountValueLabel.TabIndex = 5;
            amountValueLabel.Text = "0,0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 241);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 4;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(81, 7);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(167, 28);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer";
            // 
            // CartsTab
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(868, 585);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListBox ItemsListBox;
        private Button AddCartButton;
        private ComboBox CustomerComboBox;
        private Label label2;
        private Label label3;
        private Label amountValueLabel;
        private Label label4;
        private ListBox CartsListBox;
        private Button RemoveCartButton;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
    }
}
