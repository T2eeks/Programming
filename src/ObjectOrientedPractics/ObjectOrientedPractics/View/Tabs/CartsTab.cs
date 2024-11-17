using ObjectOrientedPractics.Model;
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
    public partial class CartsTab : UserControl
    {

        private List<Item> _items;
        private List<Customer> _customers;
        private Customer _currentCustomer;

        public List<Item> Items
        {
            get { return _items; }
            set 
            {
                _items = value;
               UpdateItemsListBox();
            }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
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
        }

        private void UpdateItemsListBox()
        {
            var itemsData = new List<string>();

            if (_items == null)
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.Enabled = false;
                return;
            }

            foreach (var item in _items)
            {
               itemsData.Add(item.Name);
            }

            ItemsListBox.DataSource = itemsData;
            ItemsListBox.Enabled = itemsData.Count != 0;
            
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
            if (_customers == null || _customers.Count == 0 || _currentCustomer == null)
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
            CartsListBox.Enabled = cartsData.Count != 0;

            CartsListBox.SelectedIndex = nextIndex >= 0 && nextIndex < cartsData.Count ? nextIndex : -1;

            amountValueLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomerComboBox.SelectedItem as Customer;

            if (_currentCustomer != null)
            {
                UpdateCartListBox();
            }
           
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item selectedItem = null;
                foreach (var item in _items)
                {
                    if (item.Name == ItemsListBox.SelectedItem.ToString())
                    {
                        selectedItem = item;
                        break; 
                    }
                }
                if (selectedItem == null)
                {
                    MessageBox.Show("Товар не найден.");
                    return;
                }

                
                _currentCustomer.Cart.Items.Add(selectedItem);

                UpdateCartListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart == null || _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста или клиент не выбран.");
                return;
            }

            var items = new List<Item>(_currentCustomer.Cart.Items);

            var order = new Order(_currentCustomer.Address, items);

            _currentCustomer.Orders.Add(order);
            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartsListBox.SelectedItem != null && _currentCustomer != null)
            {
                int selectedIndex = CartsListBox.SelectedIndex;
                _currentCustomer.Cart.Items.RemoveAt(selectedIndex);
                UpdateCartListBox();

            }
        }

        private void RemoveCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();

            }
        }
    }
}
