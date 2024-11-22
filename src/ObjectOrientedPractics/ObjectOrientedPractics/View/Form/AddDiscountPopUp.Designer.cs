namespace ObjectOrientedPractics.View.Pop_ups
{
    partial class AddDiscountPopUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PercentDiscountLabel.Location = new Point(16, 14);
            PercentDiscountLabel.Margin = new Padding(4, 0, 4, 0);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(126, 18);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(16, 60);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(93, 55);
            CategoryComboBox.Margin = new Padding(4, 5, 4, 5);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(300, 28);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // OkButton
            // 
            OkButton.Enabled = false;
            OkButton.Location = new Point(171, 93);
            OkButton.Margin = new Padding(4, 5, 4, 5);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(108, 63);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(287, 93);
            CancelButton.Margin = new Padding(4, 5, 4, 5);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(108, 63);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddDiscountPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 168);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentDiscountLabel);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(426, 215);
            MinimizeBox = false;
            MinimumSize = new Size(426, 215);
            Name = "AddDiscountPopUp";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PercentDiscountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}