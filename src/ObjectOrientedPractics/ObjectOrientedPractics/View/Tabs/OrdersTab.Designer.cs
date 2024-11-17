namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Model.Address address3 = new Model.Address();
            panel1 = new Panel();
            label2 = new Label();
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerFullName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2 = new Panel();
            OrderItemsListBox = new ListBox();
            label6 = new Label();
            addressControl1 = new Controls.AddressControl();
            label5 = new Label();
            OrderCreatedStatusTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            OrderId = new TextBox();
            StatusComboBox = new ComboBox();
            amountValueLabel = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OrdersDataGridView);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 672);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, DeliveryAddress, Price, Created, OrderStatus, CustomerFullName });
            OrdersDataGridView.Location = new Point(3, 23);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 29;
            OrdersDataGridView.Size = new Size(802, 646);
            OrdersDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.MinimumWidth = 6;
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "OrderStatus";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.Width = 125;
            // 
            // CustomerFullName
            // 
            CustomerFullName.HeaderText = "Customer Full Name";
            CustomerFullName.MinimumWidth = 6;
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Selected Order";
            // 
            // panel2
            // 
            panel2.Controls.Add(amountValueLabel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(StatusComboBox);
            panel2.Controls.Add(OrderItemsListBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addressControl1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(OrderCreatedStatusTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(OrderId);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(817, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 666);
            panel2.TabIndex = 2;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(11, 419);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(500, 144);
            OrderItemsListBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 396);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 9;
            label6.Text = "Order Items:";
            // 
            // addressControl1
            // 
            address3.Apartment = null;
            address3.Building = null;
            address3.City = null;
            address3.Country = null;
            address3.Index = 0;
            address3.Street = null;
            addressControl1.Address = address3;
            addressControl1.Location = new Point(3, 154);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(508, 239);
            addressControl1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 131);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Status:";
            // 
            // OrderCreatedStatusTextBox
            // 
            OrderCreatedStatusTextBox.Location = new Point(81, 80);
            OrderCreatedStatusTextBox.Name = "OrderCreatedStatusTextBox";
            OrderCreatedStatusTextBox.Size = new Size(155, 27);
            OrderCreatedStatusTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(11, 84);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 11;
            label4.Text = "Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 45);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // OrderId
            // 
            OrderId.Location = new Point(81, 38);
            OrderId.Name = "OrderId";
            OrderId.Size = new Size(155, 27);
            OrderId.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(81, 123);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(155, 28);
            StatusComboBox.TabIndex = 12;
            // 
            // amountValueLabel
            // 
            amountValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            amountValueLabel.AutoSize = true;
            amountValueLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amountValueLabel.Location = new Point(430, 603);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(35, 23);
            amountValueLabel.TabIndex = 14;
            amountValueLabel.Text = "0,0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(430, 578);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 13;
            label7.Text = "Amount";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrdersTab";
            Size = new Size(1342, 678);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView OrdersDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerFullName;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox OrderId;
        private Label label4;
        private Label label3;
        private Controls.AddressControl addressControl1;
        private Label label5;
        private TextBox OrderCreatedStatusTextBox;
        private ListBox OrderItemsListBox;
        private Label label6;
        private ComboBox StatusComboBox;
        private Label amountValueLabel;
        private Label label7;
    }
}
