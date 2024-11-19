using ObjectOrientedPractics.Model;
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
        }

        /// <summary>
        /// Очищает поля ввода данных о клиенте
        /// </summary>
        private void ClearingFields()
        {
                IdTextBox.Text = "";
                FullNameTextBox.Text = "";

                AddressControl.Clear();

                FullNameTextBox.BackColor = Color.White;
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

        /// <summary>
        /// Обновляет информацию в элементе списка после редактирования адресса и имени клиента
        /// </summary>
        /// <param name="index">Индекс товара в списке, который нужно обновить.</param>
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

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                CustomersListBox.SetSelected(0, false);
                ClearingFields();
                AddressControl.Clear();
            }

        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex >= 0)
            {
                _customers[CustomersListBox.SelectedIndex].IsPriority = true;
            }
        }
    }
}
