namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
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
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            AmountHeaderLabel = new Label();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderItemsLabel = new Label();
            SelectedOrderLabel = new Label();
            AddressControl = new Controls.AddressControl();
            SelectedOrderPanel = new Panel();
            ClearOrderButton = new Button();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionLabel = new Label();
            SelectedOrderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(-126, 742);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(764, 32);
            AmountLabel.TabIndex = 14;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(1, 468);
            OrderItemsListBox.Margin = new Padding(4, 5, 4, 5);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.SelectionMode = SelectionMode.MultiExtended;
            OrderItemsListBox.Size = new Size(636, 244);
            OrderItemsListBox.TabIndex = 13;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(88, 134);
            StatusComboBox.Margin = new Padding(4, 5, 4, 5);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(160, 28);
            StatusComboBox.TabIndex = 11;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Enabled = false;
            CreatedTextBox.Location = new Point(88, 88);
            CreatedTextBox.Margin = new Padding(4, 5, 4, 5);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(160, 27);
            CreatedTextBox.TabIndex = 10;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(88, 42);
            IdTextBox.Margin = new Padding(4, 5, 4, 5);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(160, 27);
            IdTextBox.TabIndex = 9;
            // 
            // AmountHeaderLabel
            // 
            AmountHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountHeaderLabel.AutoSize = true;
            AmountHeaderLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            AmountHeaderLabel.Location = new Point(568, 719);
            AmountHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            AmountHeaderLabel.Name = "AmountHeaderLabel";
            AmountHeaderLabel.Size = new Size(67, 17);
            AmountHeaderLabel.TabIndex = 8;
            AmountHeaderLabel.Text = "Amount:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(0, 138);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(0, 92);
            CreatedLabel.Margin = new Padding(4, 0, 4, 0);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 6;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(0, 46);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(31, 20);
            IdLabel.TabIndex = 5;
            IdLabel.Text = "ID: ";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrderItemsLabel.Location = new Point(-3, 443);
            OrderItemsLabel.Margin = new Padding(4, 0, 4, 0);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(87, 20);
            OrderItemsLabel.TabIndex = 3;
            OrderItemsLabel.Text = "Order Items";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedOrderLabel.Location = new Point(0, 0);
            SelectedOrderLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(108, 20);
            SelectedOrderLabel.TabIndex = 2;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // AddressControl

            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(4, 185);
            AddressControl.Margin = new Padding(4, 5, 4, 5);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(633, 253);
            AddressControl.TabIndex = 12;
            // 
            // SelectedOrderPanel
            // 
            SelectedOrderPanel.Controls.Add(ClearOrderButton);
            SelectedOrderPanel.Controls.Add(AddItemButton);
            SelectedOrderPanel.Controls.Add(RemoveItemButton);
            SelectedOrderPanel.Controls.Add(DeliveryTimeComboBox);
            SelectedOrderPanel.Controls.Add(DeliveryTimeLabel);
            SelectedOrderPanel.Controls.Add(PriorityOptionLabel);
            SelectedOrderPanel.Controls.Add(AmountLabel);
            SelectedOrderPanel.Controls.Add(OrderItemsListBox);
            SelectedOrderPanel.Controls.Add(StatusComboBox);
            SelectedOrderPanel.Controls.Add(CreatedTextBox);
            SelectedOrderPanel.Controls.Add(IdTextBox);
            SelectedOrderPanel.Controls.Add(AmountHeaderLabel);
            SelectedOrderPanel.Controls.Add(StatusLabel);
            SelectedOrderPanel.Controls.Add(CreatedLabel);
            SelectedOrderPanel.Controls.Add(IdLabel);
            SelectedOrderPanel.Controls.Add(OrderItemsLabel);
            SelectedOrderPanel.Controls.Add(SelectedOrderLabel);
            SelectedOrderPanel.Controls.Add(AddressControl);
            SelectedOrderPanel.Dock = DockStyle.Fill;
            SelectedOrderPanel.Location = new Point(0, 0);
            SelectedOrderPanel.Margin = new Padding(4, 5, 4, 5);
            SelectedOrderPanel.Name = "SelectedOrderPanel";
            SelectedOrderPanel.Size = new Size(645, 838);
            SelectedOrderPanel.TabIndex = 2;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderButton.Location = new Point(525, 769);
            ClearOrderButton.Margin = new Padding(4, 5, 4, 5);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(110, 30);
            ClearOrderButton.TabIndex = 4;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(4, 769);
            AddItemButton.Margin = new Padding(4, 5, 4, 5);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(110, 30);
            AddItemButton.TabIndex = 2;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(407, 769);
            RemoveItemButton.Margin = new Padding(4, 5, 4, 5);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(110, 30);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeComboBox.Location = new Point(400, 42);
            DeliveryTimeComboBox.Margin = new Padding(4, 5, 4, 5);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(160, 28);
            DeliveryTimeComboBox.TabIndex = 17;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(293, 46);
            DeliveryTimeLabel.Margin = new Padding(4, 0, 4, 0);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(103, 20);
            DeliveryTimeLabel.TabIndex = 16;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionLabel
            // 
            PriorityOptionLabel.AutoSize = true;
            PriorityOptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityOptionLabel.Location = new Point(293, 0);
            PriorityOptionLabel.Margin = new Padding(4, 0, 4, 0);
            PriorityOptionLabel.Name = "PriorityOptionLabel";
            PriorityOptionLabel.Size = new Size(106, 20);
            PriorityOptionLabel.TabIndex = 15;
            PriorityOptionLabel.Text = "Priority Option";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedOrderPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PriorityOrdersTab";
            Size = new Size(645, 838);
            SelectedOrderPanel.ResumeLayout(false);
            SelectedOrderPanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label AmountHeaderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.Panel SelectedOrderPanel;
        private System.Windows.Forms.Label PriorityOptionLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
    }
}