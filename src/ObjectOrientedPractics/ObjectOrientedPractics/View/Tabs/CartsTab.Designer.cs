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
            panel3 = new Panel();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            label3 = new Label();
            CartsListBox = new ListBox();
            panel5 = new Panel();
            DiscountLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            DiscountAmountHeaderLabel = new Label();
            TotalLabel = new Label();
            discountAmountLabel = new Label();
            totalAmountLabel = new Label();
            panel4 = new Panel();
            amountValueLabel = new Label();
            label4 = new Label();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            RemoveCartButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(293, 510);
            panel1.TabIndex = 0;
            // 
            // AddCartButton
            // 
            AddCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCartButton.Location = new Point(3, 398);
            AddCartButton.Name = "AddCartButton";
            AddCartButton.Size = new Size(106, 36);
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
            ItemsListBox.Size = new Size(274, 304);
            ItemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(334, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 514);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(CustomerComboBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(CartsListBox);
            panel3.Location = new Point(7, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 178);
            panel3.TabIndex = 24;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(78, -3);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(98, 28);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 37);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Cart:";
            // 
            // CartsListBox
            // 
            CartsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartsListBox.FormattingEnabled = true;
            CartsListBox.ItemHeight = 20;
            CartsListBox.Location = new Point(0, 60);
            CartsListBox.Name = "CartsListBox";
            CartsListBox.Size = new Size(475, 84);
            CartsListBox.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(DiscountLabel);
            panel5.Controls.Add(DiscountsCheckedListBox);
            panel5.Controls.Add(DiscountAmountHeaderLabel);
            panel5.Controls.Add(TotalLabel);
            panel5.Controls.Add(discountAmountLabel);
            panel5.Controls.Add(totalAmountLabel);
            panel5.Location = new Point(3, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(507, 207);
            panel5.TabIndex = 23;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountLabel.Location = new Point(1, 18);
            DiscountLabel.Margin = new Padding(4, 0, 4, 0);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(76, 20);
            DiscountLabel.TabIndex = 15;
            DiscountLabel.Text = "Discounts:";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountsCheckedListBox.BackColor = SystemColors.Control;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.CheckOnClick = true;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(0, 49);
            DiscountsCheckedListBox.Margin = new Padding(4);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(366, 154);
            DiscountsCheckedListBox.TabIndex = 17;
            // 
            // DiscountAmountHeaderLabel
            // 
            DiscountAmountHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountHeaderLabel.Location = new Point(341, 18);
            DiscountAmountHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            DiscountAmountHeaderLabel.Name = "DiscountAmountHeaderLabel";
            DiscountAmountHeaderLabel.Size = new Size(166, 23);
            DiscountAmountHeaderLabel.TabIndex = 16;
            DiscountAmountHeaderLabel.Text = "Discount Amount:";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(382, 142);
            TotalLabel.Margin = new Padding(4, 0, 4, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.RightToLeft = RightToLeft.No;
            TotalLabel.Size = new Size(121, 25);
            TotalLabel.TabIndex = 20;
            TotalLabel.Text = "Total";
            TotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            discountAmountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            discountAmountLabel.Location = new Point(449, 41);
            discountAmountLabel.Margin = new Padding(4, 0, 4, 0);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.RightToLeft = RightToLeft.No;
            discountAmountLabel.Size = new Size(49, 25);
            discountAmountLabel.TabIndex = 18;
            discountAmountLabel.Text = "0";
            discountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmountLabel.Location = new Point(476, 167);
            totalAmountLabel.Margin = new Padding(4, 0, 4, 0);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(22, 25);
            totalAmountLabel.TabIndex = 19;
            totalAmountLabel.Text = "0";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(amountValueLabel);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(CreateOrderButton);
            panel4.Controls.Add(RemoveItemButton);
            panel4.Controls.Add(RemoveCartButton);
            panel4.Location = new Point(4, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(506, 95);
            panel4.TabIndex = 22;
            // 
            // amountValueLabel
            // 
            amountValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountValueLabel.AutoSize = true;
            amountValueLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amountValueLabel.Location = new Point(477, 21);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(20, 23);
            amountValueLabel.TabIndex = 5;
            amountValueLabel.Text = "0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(421, -4);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 4;
            label4.Text = "Amount";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(3, 56);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(106, 36);
            CreateOrderButton.TabIndex = 10;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(284, 56);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(106, 36);
            RemoveItemButton.TabIndex = 11;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // RemoveCartButton
            // 
            RemoveCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveCartButton.Location = new Point(396, 56);
            RemoveCartButton.Name = "RemoveCartButton";
            RemoveCartButton.Size = new Size(106, 36);
            RemoveCartButton.TabIndex = 12;
            RemoveCartButton.Text = "Clear Cart";
            RemoveCartButton.UseVisualStyleBackColor = true;
            RemoveCartButton.Click += RemoveCartButton_Click;
            // 
            // CartsTab
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(868, 598);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private CheckedListBox DiscountsCheckedListBox;
        private Label DiscountAmountHeaderLabel;
        private Label DiscountLabel;
        private Label discountAmountLabel;
        private Label TotalLabel;
        private Label totalAmountLabel;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
    }
}
