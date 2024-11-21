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
            tabPage4 = new TabPage();
            ordeersTab1 = new View.Tabs.OrdeersTab();
            tabPage3 = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            tabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabPage1 = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            OrderTab = new TabControl();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            OrderTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ordeersTab1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1219, 854);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Order";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ordeersTab1
            // 
            ordeersTab1.Customers = null;
            ordeersTab1.Dock = DockStyle.Fill;
            ordeersTab1.Location = new Point(3, 3);
            ordeersTab1.Name = "ordeersTab1";
            ordeersTab1.Size = new Size(1213, 848);
            ordeersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1219, 854);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Carts";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1213, 848);
            cartsTab1.TabIndex = 0;
            cartsTab1.Load += cartsTab1_Load;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1219, 854);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(1213, 848);
            customersTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1219, 854);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1213, 848);
            itemsTab1.TabIndex = 0;
            // 
            // OrderTab
            // 
            OrderTab.Controls.Add(tabPage1);
            OrderTab.Controls.Add(tabPage2);
            OrderTab.Controls.Add(tabPage3);
            OrderTab.Controls.Add(tabPage4);
            OrderTab.Dock = DockStyle.Fill;
            OrderTab.Location = new Point(0, 0);
            OrderTab.Name = "OrderTab";
            OrderTab.SelectedIndex = 0;
            OrderTab.Size = new Size(1227, 887);
            OrderTab.TabIndex = 0;
            OrderTab.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 887);
            Controls.Add(OrderTab);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tabPage4.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            OrderTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private View.Tabs.OrdeersTab ordeersTab1;
        private TabPage tabPage3;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab itemsTab1;
        private TabControl OrderTab;
    }
}
