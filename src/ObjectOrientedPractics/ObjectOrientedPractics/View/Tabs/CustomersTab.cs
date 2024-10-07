using ObjectOrientedPractics.Services;
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
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();
        private Customer _customer;
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 && CustomersListBox.SelectedIndex < _customers.Count)
            {
                _customer = _customers[CustomersListBox.SelectedIndex];
                FullNameTextBox.Text = _customer.FullName;
                AddressTextBox.Text = _customer.Address;
                IdTextBox.Text = Convert.ToString(_customer.Id);

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
                    UpdateCustomerData();
                }
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressTextBox.BackColor = Color.White;
            ValueValidator.AssertStringOnLength(AddressTextBox.Text, 500, nameof(Customer.Address));
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                UpdateCustomerData();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer addCustomer = new Customer(FullNameTextBox.Text, AddressTextBox.Text);
                if (AddressTextBox.Text != "")
                {
                    _customers.Add(addCustomer);
                    CustomersListBox.Items.Add(addCustomer.FullName + " проживает по адресу " + addCustomer.Address);
                    FullNameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    FullNameTextBox.BackColor = Color.White;
                    AddressTextBox.BackColor = Color.White;
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
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);


                FullNameTextBox.Text = "";
                AddressTextBox.Text = "";
                FullNameTextBox.BackColor = Color.White;
                AddressTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении - " + ex.Message);
            }

        }

        private void CustomersTab_Click(object sender, EventArgs e)
        {
            ClearingFields();
        }

        private void UpdateCustomersListBox(int index)
        {
            CustomersListBox.Items[index] = $"{_customers[index].FullName} проживает по адресу {_customers[index].Address}";
        }

        private void UpdateCustomerData()
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _customers[CustomersListBox.SelectedIndex].FullName = FullNameTextBox.Text;
                _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                UpdateCustomersListBox(CustomersListBox.SelectedIndex);
            }
        }
        private void ClearingFields()
        {
            if (CustomersListBox.SelectedIndex >= 0 && CustomersListBox.SelectedIndex < _customers.Count)
            {
                CustomersListBox.SetSelected(0, false);
                AddressTextBox.Text = "";
                FullNameTextBox.Text = "";
            }
        }
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
