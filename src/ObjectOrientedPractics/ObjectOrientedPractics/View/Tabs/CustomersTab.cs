using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.DIscount;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Pop_ups;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();
        private Customer _customer;

        public List<Customer> Customers
        {
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
            get { return _customers; }
        }

        public CustomersTab()
        {
            InitializeComponent();

            AddressControl.Address = new Address();
        }

        private void ClearingFields()
        {
            IdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressControl.Clear();
            FullNameTextBox.BackColor = Color.White;
            DiscountsListBox.Items.Clear();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 && CustomersListBox.SelectedIndex < _customers.Count)
            {
                _customer = _customers[CustomersListBox.SelectedIndex];
                FullNameTextBox.Text = _customer.FullName;
                AddressControl.Address = _customer.Address;
                IdTextBox.Text = Convert.ToString(_customer.Id);
                IsPriorityCheckBox.Checked = _customer.IsPriority;
                UpdateDiscountsListBox(_customer);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(FullNameTextBox.Text, 200, nameof(Customer.FullName));
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _customers[CustomersListBox.SelectedIndex].FullName = FullNameTextBox.Text;
                    UpdateCustomersListBox(CustomersListBox.SelectedIndex);
                }
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FullNameTextBox.Text != "")
                {
                    Customer addCustomer = new Customer(FullNameTextBox.Text, AddressControl.Address);
                    if (IsPriorityCheckBox.Checked)
                    {
                        addCustomer.IsPriority = true;
                    }

                    _customers.Add(addCustomer);
                    CustomersListBox.Items.Add("Гражданин " + addCustomer.FullName);
                    FullNameTextBox.Text = "";
                    FullNameTextBox.BackColor = Color.White;

                    AddressControl.Clear();
                    IsPriorityCheckBox.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении - " + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomersListBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Выберите элемент для удаления.");
                    return;
                }

                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                ClearingFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении - " + ex.Message);
            }
        }

        private void CustomersTab_Click(object sender, EventArgs e)
        {
            ClearingFields();
        }

        private void UpdateCustomersListBox(int index)
        {
            CustomersListBox.Items[index] = $" Гражданин {_customers[index].FullName}";
        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var item in _customers)
            {
                CustomersListBox.Items.Add($" Гражданин {item.FullName}");
            }
        }

        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _customers[CustomersListBox.SelectedIndex].IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("Выберите клиента для добавления скидки.");
                return;
            }

            var addDiscountPopUp = new AddDiscountPopUp(_customer);

            if (addDiscountPopUp.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var discount = new PercentDiscount(addDiscountPopUp.Category);
            _customer.Discounts.Add(discount);

            UpdateDiscountsListBox(_customer);
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (_customer == null || DiscountsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите скидку для удаления.");
                return;
            }

            int selectedIndex = DiscountsListBox.SelectedIndex;
            _customer.Discounts.RemoveAt(selectedIndex);
            UpdateDiscountsListBox(_customer);
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveDiscountButton.Enabled = DiscountsListBox.SelectedIndex >= 0;
        }
    }
}
