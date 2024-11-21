using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Order;
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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _priorityOrder;

        private List<Customer> _customers;

        private List<Item> _items;

        public PriorityOrder PriorityOrder
        {
            get
            {
                return _priorityOrder;
            }
            set
            {
                _priorityOrder = value;
                UpdateOrderDetails();
            }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
            }
        }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }
        public PriorityOrdersTab()
        {
            InitializeComponent();
            AddressControl.Enabled = false;
            IdTextBox.ReadOnly = true;

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            DeliveryTimeComboBox.SelectedIndex = 0;
        }


        public void UpdateOrderDetails()
        {
            if (_priorityOrder == null)
            {
                ClearOrderDetails();
                return;
            }

            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreatedTextBox.Text = _priorityOrder.CreationDate.ToString("yyyy-MM-dd HH:mm");
            StatusComboBox.SelectedItem = _priorityOrder.Status;

            AddressControl.Address = _priorityOrder.DeliveryAddress;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _priorityOrder.Items)
            {
                OrderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }

            AmountLabel.Text = _priorityOrder.TotalAmount.ToString("F2");
        }

        private void ClearOrderDetails()
        {
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;


            OrderItemsListBox.Items.Clear();
            AmountLabel.Text = "0.00";
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_items == null || !_items.Any())
            {
                MessageBox.Show("Список товаров пуст.");
                return;
            }

            var random = new Random();
            var randomItem = _items[random.Next(_items.Count)];

            _priorityOrder.Items.Add(randomItem);
            UpdateOrderDetails();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар для удаления.");
                return;
            }

            _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            UpdateOrderDetails();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder(new Address(), new List<Item>(), DateTime.Now, 0);
            UpdateOrderDetails();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null && StatusComboBox.SelectedItem is OrderStatus newStatus)
            {
                _priorityOrder.Status = newStatus;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null)
            {
                _priorityOrder.Time = (OrderTime)(DeliveryTimeComboBox.SelectedIndex + 1);
            }
        }
    }
}
