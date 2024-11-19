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

        private Order _selectedOrder;

        private PriorityOrder _selectedPriorityOrder;

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
            StatusComboBox.FormattingEnabled = true;
            PriorityPanel.Visible = false;
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
            if (OrdersDataGridView.SelectedRows.Count == 0)
            {
                _selectedOrder = null;
                _selectedPriorityOrder = null;
                PriorityPanel.Visible = false;
                return;
            }

            _selectedOrder = OrdersDataGridView.SelectedRows[0].Tag as Order;

            if (_selectedOrder is PriorityOrder priorityOrder)
            {
                _selectedPriorityOrder = priorityOrder;
                DeliveryTimeComboBox.SelectedIndex = (int)priorityOrder.Time - 1;
                PriorityPanel.Visible = true; 
            }
            else
            {
                _selectedPriorityOrder = null;
                PriorityPanel.Visible = false; 
            }

            UpdateOrderDetails();

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

        private void IdTexBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateOrderDetails()
        {
            if (_selectedOrder == null)
            {
                return;
            }

            IdTexBox.Text = _selectedOrder.Id.ToString();
            CreatedTextBox.Text = _selectedOrder.CreationDate.ToString("yyyy-MM-dd HH:mm");
            StatusComboBox.SelectedItem = _selectedOrder.Status;

            addressControl1.Address = _selectedOrder.DeliveryAddress;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _selectedOrder.Items)
            {
                OrderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }

            amountValueLabel.Text = _selectedOrder.TotalAmount.ToString("F2");

            if (_selectedPriorityOrder != null)
            {
                DeliveryTimeComboBox.SelectedIndex = (int)_selectedPriorityOrder.Time - 1;
                PriorityPanel.Visible = true;
            }
            else
            {
                PriorityPanel.Visible = false;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null)
            {
                _selectedPriorityOrder.Time = (OrderTime)(DeliveryTimeComboBox.SelectedIndex + 1);
            }
        }
    }
}
