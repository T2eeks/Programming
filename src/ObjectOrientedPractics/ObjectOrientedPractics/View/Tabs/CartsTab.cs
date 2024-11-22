using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public decimal DiscountAmount { get; set; }
        private List<Item> _items;
        private List<Customer> _customers;
        private Customer _currentCustomer;

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                UpdateCustomersComboBox();
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
            UpdateDiscountsCheckedListBox();
        }

        private void UpdateItemsListBox()
        {
            if (_items == null)
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.Enabled = false;
                return;
            }

            var itemsData = new List<string>();
            foreach (var item in _items)
            {
                itemsData.Add(item.Name);
            }

            ItemsListBox.DataSource = itemsData;
            ItemsListBox.Enabled = itemsData.Count > 0;
        }

        private void UpdateCustomersComboBox()
        {
            if (_customers == null || _customers.Count == 0)
            {
                CustomerComboBox.DataSource = null;
                CustomerComboBox.Enabled = false;
                amountValueLabel.Text = string.Empty;
                return;
            }

            CustomerComboBox.DataSource = null;
            CustomerComboBox.DataSource = _customers;
            CustomerComboBox.DisplayMember = "FullName";
            CustomerComboBox.Enabled = true;
            CustomerComboBox.SelectedIndex = 0;
        }

        private void UpdateCartListBox(int nextIndex = -1)
        {
            if (_customers == null || _currentCustomer == null)
            {
                CartsListBox.DataSource = null;
                CartsListBox.Enabled = false;
                amountValueLabel.Text = string.Empty;
                return;
            }

            var cartsData = new List<string>();
            foreach (var item in _currentCustomer.Cart.Items)
            {
                cartsData.Add(item.Name);
            }

            CartsListBox.DataSource = cartsData;
            CartsListBox.Enabled = cartsData.Count > 0;

            CartsListBox.SelectedIndex = nextIndex >= 0 && nextIndex < cartsData.Count ? nextIndex : -1;
            UpdateAmountLabels();
        }

        private void UpdateDiscountsCheckedListBox()
        {
            if (_currentCustomer == null || _currentCustomer.Discounts == null)
            {
                DiscountsCheckedListBox.Items.Clear();
                DiscountsCheckedListBox.Enabled = false;
                return;
            }

            DiscountsCheckedListBox.Items.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info);
            }

            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true); // Включаем все скидки
            }

            DiscountsCheckedListBox.Enabled = DiscountsCheckedListBox.Items.Count > 0;
            UpdateAmountLabels();
        }

        private void UpdateAmountLabels()
        {
            if (_currentCustomer == null || _currentCustomer.Cart == null)
            {
                amountValueLabel.Text = "0.00";
                discountAmountLabel.Text = "0.00";
                totalAmountLabel.Text = "0.00";
                return;
            }

            var cartAmount = _currentCustomer.Cart.Amount;
            DiscountAmount = 0M;

            foreach (var item in DiscountsCheckedListBox.CheckedItems)
            {
                var discountIndex = DiscountsCheckedListBox.Items.IndexOf(item);
                DiscountAmount += (decimal)_currentCustomer.Discounts[discountIndex].Calculate(_currentCustomer.Cart.Items);
            }

            amountValueLabel.Text = cartAmount.ToString("F2");
            discountAmountLabel.Text = DiscountAmount.ToString("F2");
            totalAmountLabel.Text = ((decimal)cartAmount - DiscountAmount).ToString("F2");
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomerComboBox.SelectedItem as Customer;
            if (_currentCustomer != null)
            {
                UpdateCartListBox();
                UpdateDiscountsCheckedListBox();
            }
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || ItemsListBox.SelectedIndex < 0)
            {
                return;
            }

            var selectedItem = _items[ItemsListBox.SelectedIndex];
            _currentCustomer.Cart.Items.Add(selectedItem);
            UpdateCartListBox();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста или клиент не выбран.");
                return;
            }

            var items = new List<Item>(_currentCustomer.Cart.Items);

            foreach (var item in DiscountsCheckedListBox.CheckedItems)
            {
                var discountIndex = DiscountsCheckedListBox.Items.IndexOf(item);
                _currentCustomer.Discounts[discountIndex].Apply(items);
            }

            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(items);
            }

            UpdateDiscountsCheckedListBox();

            if (_currentCustomer.IsPriority)
            {
                var priorityOrder = new PriorityOrder(
                    _currentCustomer.Address,
                    items,
                    DateTime.Now,
                    (double)DiscountAmount);
                _currentCustomer.Orders.Add(priorityOrder);
            }
            else
            {
                var order = new Order(
                    _currentCustomer.Address,
                    items,
                    (double)DiscountAmount);
                _currentCustomer.Orders.Add(order);
            }

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CartsListBox.SelectedIndex < 0)
            {
                return;
            }

            var selectedIndex = CartsListBox.SelectedIndex;
            _currentCustomer.Cart.Items.RemoveAt(selectedIndex);
            UpdateCartListBox(selectedIndex);
        }

        private void RemoveCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Обновляем расчет скидок, когда меняются галочки
            BeginInvoke(new Action(UpdateAmountLabels));
        }
    }
}
