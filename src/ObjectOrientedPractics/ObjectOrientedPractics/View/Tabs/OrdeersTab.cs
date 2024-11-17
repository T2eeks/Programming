using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdeersTab : UserControl
    {
        private List<Customer> _customers;
        private List<Order> Orders { get; } = new List<Order>();

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            { 
                _customers = value;
            }
        }
        public OrdeersTab()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            addressControl1.Enabled = false;
            IdTexBox.ReadOnly = true;
            CreatedTextBox.ReadOnly = true;
        }

        public void RefreshData()
        {
            if (Customers == null || !Customers.Any())
            {
                Orders.Clear();
                OrdersDataGridView.DataSource = null;
                return;
            }

            UpdateOrders();
        }

        private void UpdateOrders()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();

            if (Customers == null || !Customers.Any()) return;

            foreach (var customer in Customers)
            {
                var address = $"{customer.Address.Country}, {customer.Address.City}, ";
                address += $"{customer.Address.Street} {customer.Address.Building}, ";
                address += $"{customer.Address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);

                    var rowIndex = OrdersDataGridView.Rows.Add(
                        order.Id,
                        order.CreationDate.ToString("yyyy-MM-dd HH:mm"),
                        customer.FullName,
                        address,
                        order.TotalAmount.ToString("F2"),
                        order.Status.ToString()
                    );

                   
                    OrdersDataGridView.Rows[rowIndex].Tag = order;
                }
            }
        }


        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count == 0) return;


            var selectedRow = OrdersDataGridView.SelectedRows[0];
            var selectedOrder = selectedRow.Tag as Order;

            if (selectedOrder == null) return;

            
            addressControl1.Address = selectedOrder.DeliveryAddress;
            IdTexBox.Text = selectedOrder.Id.ToString();
            CreatedTextBox.Text = selectedOrder.CreationDate.ToString("yyyy-MM-dd HH:mm");
            StatusComboBox.SelectedItem = selectedOrder.Status;

            
            OrderItemsListBox.Items.Clear(); 
            foreach (var item in selectedOrder.Items)
            {
                OrderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }

            amountValueLabel.Text = selectedOrder.TotalAmount.ToString("F2");
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count == 0) return;

            int selectedIndex = OrdersDataGridView.SelectedRows[0].Index;
            var selectedOrder = Orders[selectedIndex];
            if (selectedOrder == null) return;

            if (StatusComboBox.SelectedItem is OrderStatus newStatus)
            {
                selectedOrder.Status = newStatus;

                
                UpdateOrders();

            }
        }
    }
}
