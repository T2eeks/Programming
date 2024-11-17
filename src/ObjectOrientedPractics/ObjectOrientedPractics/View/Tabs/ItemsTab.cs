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

        public List<Item> Items
        {
            set
            {
                _items = value;
                UpdateItemsListBox();

            }
            get { return _items; }
        }
        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

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

                CategoryComboBox.SelectedItem = _item.Category;


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
                    UpdateItemsListBox(ItemsListBox.SelectedIndex);
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
                ValueValidator.AssertOnPositiveValue(Convert.ToDouble(CostTextBox.Text), 0, 100000, nameof(Item.Cost));

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    UpdateItemsListBox(ItemsListBox.SelectedIndex);
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
                CategoryComboBox.Items.Clear();

                NameTextBox.BackColor = Color.White;
                DescriptionTextBox.BackColor = Color.White;
                CostTextBox.BackColor = Color.White;
                IdTextBox.BackColor = Color.White;

                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
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
                Category selectedCategory = (Category)Enum.Parse(typeof(Category), CategoryComboBox.SelectedItem.ToString());
                Item addItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, Convert.ToDouble(CostTextBox.Text), selectedCategory);
                _items.Add(addItem);
                ItemsListBox.Items.Add(addItem.Name + " стоит - " + addItem.Cost);

                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CostTextBox.Text = "";
                IdTextBox.Text = "";
                CategoryComboBox.Items.Clear();



                NameTextBox.BackColor = Color.White;
                DescriptionTextBox.BackColor = Color.White;
                CostTextBox.BackColor = Color.White;
                IdTextBox.BackColor = Color.White;

                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
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


        /// <summary>
        /// Обновляет информацию в элементе списка после редактирования товара
        /// </summary>
        /// <param name="index">Индекс товара в списке, который нужно обновить</param>
        private void UpdateItemsListBox(int index)
        {
            ItemsListBox.Items[index] = $"{_items[index].Name} стоит - {_items[index].Cost}";
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name} стоит - {item.Cost}");
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ClearingFields();
        }

        /// <summary>
        /// Очищает поля ввода данных о товаре.
        /// </summary>
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
                DescriptionTextBox.BackColor = Color.White;
                CategoryComboBox.Items.Clear();

                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _items.Count)
            {

                _item.Category = (Category)CategoryComboBox.SelectedItem;


                UpdateItemsListBox(ItemsListBox.SelectedIndex);
            }
        }


    }
}
