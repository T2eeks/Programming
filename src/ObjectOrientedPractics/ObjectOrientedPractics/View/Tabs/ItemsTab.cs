using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();
        private Item _item;
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _items.Count)
            {

                _item = _items[ItemsListBox.SelectedIndex];
                NameTextBox.Text = _item.Name;
                DescriptionTextBox.Text = _item.Info;
                CostTextBox.Text = Convert.ToString(_item.Cost);
                IdTextBox.Text = Convert.ToString(_item.Id);
                NameTextBox.BackColor = Color.White;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(NameTextBox.Text, 200, nameof(Item.Name));
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    UpdateItemData();
                }
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(DescriptionTextBox.Text, 1000, nameof(Item.Info));
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    UpdateItemData();
                }
            }
            catch
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = Color.White;
                ValueValidator.AssertOnPositiveValue(Convert.ToDouble(CostTextBox.Text), 100000, nameof(Item.Cost));

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    UpdateItemData();
                }
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);

                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CostTextBox.Text = "";
                IdTextBox.Text = "";

                NameTextBox.BackColor = Color.White;
                DescriptionTextBox.BackColor = Color.White;
                CostTextBox.BackColor = Color.White;
                IdTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении - " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item addItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, Convert.ToDouble(CostTextBox.Text));
                _items.Add(addItem);
                ItemsListBox.Items.Add(addItem.Name + " стоит - " + addItem.Cost + " Рублей.");

                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CostTextBox.Text = "";
                IdTextBox.Text = "";

                NameTextBox.BackColor = Color.White;
                DescriptionTextBox.BackColor = Color.White;
                CostTextBox.BackColor = Color.White;
                IdTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении - " + ex.Message);
            }
        }

        private void ItemsListBox_Click(object sender, EventArgs e)
        {

        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateItemsListBox(int index)
        {
            ItemsListBox.Items[index] = $"{_items[index].Name} стоит - {_items[index].Cost}";
        }
        private void UpdateItemData()
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                UpdateItemsListBox(ItemsListBox.SelectedIndex);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ClearingFields();
        }
        private void ClearingFields()
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _items.Count)
            {
                ItemsListBox.SetSelected(0, false);
                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CostTextBox.Text = "";
                IdTextBox.Text = "";
                CostTextBox.BackColor = Color.White;
                NameTextBox.BackColor = Color.White;

            }
        }



    }
}
