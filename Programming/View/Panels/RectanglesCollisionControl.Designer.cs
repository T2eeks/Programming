namespace Programming.View.Penis
{
    partial class RectanglesCollisionControl
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
            RectanglesGroupBox = new GroupBox();
            NewRectangleListBox = new ListBox();
            PanelRectangles = new Panel();
            HeightRectanglesTextBox = new TextBox();
            AddRectabgleButton = new Button();
            WidthRectanglesTextBox = new TextBox();
            DeleteRectangleButton = new Button();
            PointYTextBox = new TextBox();
            label16 = new Label();
            PointXTextBox = new TextBox();
            IdRectanglesTextBox = new TextBox();
            label17 = new Label();
            label21 = new Label();
            label18 = new Label();
            label20 = new Label();
            label19 = new Label();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(NewRectangleListBox);
            RectanglesGroupBox.Controls.Add(PanelRectangles);
            RectanglesGroupBox.Controls.Add(HeightRectanglesTextBox);
            RectanglesGroupBox.Controls.Add(AddRectabgleButton);
            RectanglesGroupBox.Controls.Add(WidthRectanglesTextBox);
            RectanglesGroupBox.Controls.Add(DeleteRectangleButton);
            RectanglesGroupBox.Controls.Add(PointYTextBox);
            RectanglesGroupBox.Controls.Add(label16);
            RectanglesGroupBox.Controls.Add(PointXTextBox);
            RectanglesGroupBox.Controls.Add(IdRectanglesTextBox);
            RectanglesGroupBox.Controls.Add(label17);
            RectanglesGroupBox.Controls.Add(label21);
            RectanglesGroupBox.Controls.Add(label18);
            RectanglesGroupBox.Controls.Add(label20);
            RectanglesGroupBox.Controls.Add(label19);
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(875, 485);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "RectanglesGroupBox";
            RectanglesGroupBox.Enter += RectanglesGroupBox_Enter;
            // 
            // NewRectangleListBox
            // 
            NewRectangleListBox.FormattingEnabled = true;
            NewRectangleListBox.Location = new Point(3, 23);
            NewRectangleListBox.Name = "NewRectangleListBox";
            NewRectangleListBox.Size = new Size(229, 124);
            NewRectangleListBox.TabIndex = 0;
            NewRectangleListBox.SelectedIndexChanged += NewRectangleListBox_SelectedIndexChanged;
            // 
            // PanelRectangles
            // 
            PanelRectangles.BorderStyle = BorderStyle.FixedSingle;
            PanelRectangles.Location = new Point(238, 23);
            PanelRectangles.Name = "PanelRectangles";
            PanelRectangles.Size = new Size(608, 446);
            PanelRectangles.TabIndex = 16;
            // 
            // HeightRectanglesTextBox
            // 
            HeightRectanglesTextBox.Location = new Point(87, 370);
            HeightRectanglesTextBox.Name = "HeightRectanglesTextBox";
            HeightRectanglesTextBox.Size = new Size(125, 27);
            HeightRectanglesTextBox.TabIndex = 20;
            HeightRectanglesTextBox.TextChanged += HeightRectanglesTextBox_TextChanged;
            HeightRectanglesTextBox.Leave += HeightRectanglesTextBox_Leave;
            // 
            // AddRectabgleButton
            // 
            AddRectabgleButton.FlatStyle = FlatStyle.Flat;
            AddRectabgleButton.Location = new Point(12, 155);
            AddRectabgleButton.Name = "AddRectabgleButton";
            AddRectabgleButton.Size = new Size(85, 29);
            AddRectabgleButton.TabIndex = 3;
            AddRectabgleButton.Text = "ADD";
            AddRectabgleButton.UseVisualStyleBackColor = true;
            AddRectabgleButton.Click += AddRectabgleButton_Click;
            // 
            // WidthRectanglesTextBox
            // 
            WidthRectanglesTextBox.Location = new Point(87, 331);
            WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            WidthRectanglesTextBox.Size = new Size(125, 27);
            WidthRectanglesTextBox.TabIndex = 19;
            WidthRectanglesTextBox.TextChanged += WidthRectanglesTextBox_TextChanged;
            WidthRectanglesTextBox.Leave += WidthRectanglesTextBox_Leave;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(127, 156);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(85, 29);
            DeleteRectangleButton.TabIndex = 2;
            DeleteRectangleButton.Text = "DELETE";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // PointYTextBox
            // 
            PointYTextBox.Location = new Point(87, 289);
            PointYTextBox.Name = "PointYTextBox";
            PointYTextBox.Size = new Size(125, 27);
            PointYTextBox.TabIndex = 18;
            PointYTextBox.TextChanged += PointYTextBox_Leave;
            PointYTextBox.Leave += PointYTextBox_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 188);
            label16.Name = "label16";
            label16.Size = new Size(139, 20);
            label16.TabIndex = 4;
            label16.Text = "Selected Rectangle;";
            // 
            // PointXTextBox
            // 
            PointXTextBox.Location = new Point(87, 251);
            PointXTextBox.Name = "PointXTextBox";
            PointXTextBox.Size = new Size(125, 27);
            PointXTextBox.TabIndex = 17;
            PointXTextBox.TextChanged += PointXTextBox_Leave;
            PointXTextBox.Leave += PointXTextBox_Leave;
            // 
            // IdRectanglesTextBox
            // 
            IdRectanglesTextBox.Location = new Point(87, 218);
            IdRectanglesTextBox.Name = "IdRectanglesTextBox";
            IdRectanglesTextBox.ReadOnly = true;
            IdRectanglesTextBox.Size = new Size(125, 27);
            IdRectanglesTextBox.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 218);
            label17.Name = "label17";
            label17.Size = new Size(25, 20);
            label17.TabIndex = 6;
            label17.Text = "id;";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 334);
            label21.Name = "label21";
            label21.Size = new Size(52, 20);
            label21.TabIndex = 10;
            label21.Text = "Width;";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 258);
            label18.Name = "label18";
            label18.Size = new Size(21, 20);
            label18.TabIndex = 7;
            label18.Text = "X;";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 373);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 9;
            label20.Text = "Height;";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 296);
            label19.Name = "label19";
            label19.Size = new Size(20, 20);
            label19.TabIndex = 8;
            label19.Text = "Y;";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(865, 481);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private ListBox NewRectangleListBox;
        private Panel PanelRectangles;
        private TextBox HeightRectanglesTextBox;
        private Button AddRectabgleButton;
        private TextBox WidthRectanglesTextBox;
        private Button DeleteRectangleButton;
        private TextBox PointYTextBox;
        private Label label16;
        private TextBox PointXTextBox;
        private TextBox IdRectanglesTextBox;
        private Label label17;
        private Label label21;
        private Label label18;
        private Label label20;
        private Label label19;
    }
}
