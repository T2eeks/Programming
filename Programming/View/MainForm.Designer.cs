namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Enums = new TabControl();
            Enumss = new TabPage();
            seasonHandleControl1 = new View.Panels.SeasonHandleControl();
            weedDayParsingControl1 = new View.Panels.WeedDayParsingControl();
            enumerationsControls1 = new View.Panels.EnumerationsControls();
            Classes = new TabPage();
            rectanglesControls1 = new View.Panels.RectanglesControls();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Penis.RectanglesCollisionControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            moviesControl1 = new View.Panels.MoviesControl();
            Enums.SuspendLayout();
            Enumss.SuspendLayout();
            Classes.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(Enumss);
            Enums.Controls.Add(Classes);
            Enums.Controls.Add(Rectangles);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(944, 451);
            Enums.TabIndex = 0;
            Enums.Tag = "";
            // 
            // Enumss
            // 
            Enumss.Controls.Add(seasonHandleControl1);
            Enumss.Controls.Add(weedDayParsingControl1);
            Enumss.Controls.Add(enumerationsControls1);
            Enumss.Location = new Point(4, 29);
            Enumss.Name = "Enumss";
            Enumss.Padding = new Padding(3);
            Enumss.Size = new Size(936, 418);
            Enumss.TabIndex = 0;
            Enumss.Text = "Enums";
            Enumss.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(351, 318);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(266, 134);
            seasonHandleControl1.TabIndex = 11;
            // 
            // weedDayParsingControl1
            // 
            weedDayParsingControl1.Location = new Point(-4, 299);
            weedDayParsingControl1.Name = "weedDayParsingControl1";
            weedDayParsingControl1.Size = new Size(349, 153);
            weedDayParsingControl1.TabIndex = 10;
            // 
            // enumerationsControls1
            // 
            enumerationsControls1.Location = new Point(3, 6);
            enumerationsControls1.Name = "enumerationsControls1";
            enumerationsControls1.Size = new Size(631, 298);
            enumerationsControls1.TabIndex = 9;
            // 
            // Classes
            // 
            Classes.Controls.Add(moviesControl1);
            Classes.Controls.Add(rectanglesControls1);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(936, 418);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            //Classes.Enter += Classes_Enter;
            // 
            // rectanglesControls1
            // 
            rectanglesControls1.Location = new Point(0, 6);
            rectanglesControls1.Name = "rectanglesControls1";
            rectanglesControls1.Size = new Size(534, 321);
            rectanglesControls1.TabIndex = 3;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(936, 418);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(930, 412);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(527, 6);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(392, 321);
            moviesControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 451);
            Controls.Add(Enums);
            Name = "MainForm";
            Text = "Form1";
            Enums.ResumeLayout(false);
            Enumss.ResumeLayout(false);
            Classes.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl Enums;
        private TabPage Enumss;
        private GroupBox ParsingGroupBox;
        private TextBox TextBoxForParsing;
        private Label label4;
        private Button ParseButton;
        private TextBox ParsedTextBox;
        private TabPage Classes;
        private TextBox PointyRectangles;
        private TextBox PointxRectangles;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage Rectangles;
        private ListBox listBox2;
        private TextBox textBox5;
        private TextBox RectanglesWidthTextBox;
        private View.Penis.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsControls enumerationsControls1;
        private View.Panels.WeedDayParsingControl weedDayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesControls rectanglesControls1;
        private View.Panels.MoviesControl moviesControl1;
    }
}
