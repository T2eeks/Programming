namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdeersTab
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
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderFullName = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            PriorityPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionLabel = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IdTexBox = new TextBox();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            amountValueLabel = new Label();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label5 = new Label();
            addressControl1 = new Controls.AddressControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            panel2.SuspendLayout();
            PriorityPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(OrdersDataGridView);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 610);
            panel1.TabIndex = 0;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderFullName, DeliveryAddress, Price, Total, Status });
            OrdersDataGridView.Location = new Point(0, 0);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 29;
            OrdersDataGridView.Size = new Size(651, 610);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.ReadOnly = true;
            // 
            // OrderFullName
            // 
            OrderFullName.HeaderText = "Order Full Name";
            OrderFullName.MinimumWidth = 6;
            OrderFullName.Name = "OrderFullName";
            OrderFullName.ReadOnly = true;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.MinimumWidth = 6;
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(PriorityPanel);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(amountValueLabel);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(OrderItemsListBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addressControl1);
            panel2.Location = new Point(660, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 607);
            panel2.TabIndex = 1;
            // 
            // PriorityPanel
            // 
            PriorityPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriorityPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityPanel.Controls.Add(DeliveryTimeLabel);
            PriorityPanel.Controls.Add(PriorityOptionLabel);
            PriorityPanel.Location = new Point(252, 3);
            PriorityPanel.Name = "PriorityPanel";
            PriorityPanel.Size = new Size(264, 110);
            PriorityPanel.TabIndex = 13;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeComboBox.Location = new Point(111, 42);
            DeliveryTimeComboBox.Margin = new Padding(4, 5, 4, 5);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(98, 28);
            DeliveryTimeComboBox.TabIndex = 20;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(4, 46);
            DeliveryTimeLabel.Margin = new Padding(4, 0, 4, 0);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(103, 20);
            DeliveryTimeLabel.TabIndex = 19;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionLabel
            // 
            PriorityOptionLabel.AutoSize = true;
            PriorityOptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityOptionLabel.Location = new Point(4, 0);
            PriorityOptionLabel.Margin = new Padding(4, 0, 4, 0);
            PriorityOptionLabel.Name = "PriorityOptionLabel";
            PriorityOptionLabel.Size = new Size(106, 20);
            PriorityOptionLabel.TabIndex = 18;
            PriorityOptionLabel.Text = "Priority Option";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(IdTexBox);
            panel3.Controls.Add(StatusComboBox);
            panel3.Controls.Add(CreatedTextBox);
            panel3.Location = new Point(15, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 165);
            panel3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 138);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Created";
            // 
            // IdTexBox
            // 
            IdTexBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTexBox.Location = new Point(68, 33);
            IdTexBox.Name = "IdTexBox";
            IdTexBox.Size = new Size(127, 27);
            IdTexBox.TabIndex = 5;
            IdTexBox.TextChanged += IdTexBox_TextChanged;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(68, 130);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 7;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreatedTextBox.Location = new Point(68, 83);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(127, 27);
            CreatedTextBox.TabIndex = 6;
            // 
            // amountValueLabel
            // 
            amountValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountValueLabel.AutoSize = true;
            amountValueLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amountValueLabel.Location = new Point(419, 573);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(20, 23);
            amountValueLabel.TabIndex = 11;
            amountValueLabel.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(419, 548);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 10;
            label6.Text = "Amount";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(15, 443);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(485, 104);
            OrderItemsListBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 418);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Order Items";
            // 
            // addressControl1
            // 
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Location = new Point(3, 161);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(510, 236);
            addressControl1.TabIndex = 0;
            // 
            // OrdeersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrdeersTab";
            Size = new Size(1181, 623);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PriorityPanel.ResumeLayout(false);
            PriorityPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView OrdersDataGridView;
        private Panel panel2;
        private Controls.AddressControl addressControl1;
        private TextBox IdTexBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private ListBox OrderItemsListBox;
        private Label label5;
        private Label amountValueLabel;
        private Label label6;
        private Panel panel3;
        private Panel PriorityPanel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionLabel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderFullName;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Status;
    }
}
