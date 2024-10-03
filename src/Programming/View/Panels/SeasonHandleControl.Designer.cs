namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            HandleGroupBox = new GroupBox();
            HandleComboBox = new ComboBox();
            HandleButton = new Button();
            label5 = new Label();
            HandleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // HandleGroupBox
            // 
            HandleGroupBox.Controls.Add(HandleComboBox);
            HandleGroupBox.Controls.Add(HandleButton);
            HandleGroupBox.Controls.Add(label5);
            HandleGroupBox.Location = new Point(3, 3);
            HandleGroupBox.Name = "HandleGroupBox";
            HandleGroupBox.Size = new Size(259, 133);
            HandleGroupBox.TabIndex = 9;
            HandleGroupBox.TabStop = false;
            HandleGroupBox.Text = "Season Handle;";
            // 
            // HandleComboBox
            // 
            HandleComboBox.FormattingEnabled = true;
            HandleComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            HandleComboBox.Location = new Point(0, 46);
            HandleComboBox.Name = "HandleComboBox";
            HandleComboBox.Size = new Size(151, 28);
            HandleComboBox.TabIndex = 3;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(162, 46);
            HandleButton.Name = "HandleButton";
            HandleButton.Size = new Size(71, 32);
            HandleButton.TabIndex = 2;
            HandleButton.Text = "Go";
            HandleButton.UseVisualStyleBackColor = true;
            HandleButton.Click += HandleButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 23);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Choose Season";
            // 
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HandleGroupBox);
            Name = "SeasonHandleControl";
            Size = new Size(265, 139);
            HandleGroupBox.ResumeLayout(false);
            HandleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox HandleGroupBox;
        private ComboBox HandleComboBox;
        private Button HandleButton;
        private Label label5;
    }
}
