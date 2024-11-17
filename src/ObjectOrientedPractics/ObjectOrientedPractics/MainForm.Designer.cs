namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabPage3 = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            ordersTab1 = new TabPage();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Controls.Add(ordersTab1);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(877, 596);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(869, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(863, 557);
            itemsTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(869, 563);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(863, 557);
            customersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(869, 563);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Carts";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(6, 6);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(890, 576);
            cartsTab1.TabIndex = 0;
            cartsTab1.Load += cartsTab1_Load;
            // 
            // ordersTab1
            // 
            ordersTab1.Location = new Point(4, 29);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Padding = new Padding(3);
            ordersTab1.Size = new Size(869, 563);
            ordersTab1.TabIndex = 3;
            ordersTab1.Text = "Orders";
            ordersTab1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 596);
            Controls.Add(TabControl);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage tabPage3;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage ordersTab1;
    }
}
