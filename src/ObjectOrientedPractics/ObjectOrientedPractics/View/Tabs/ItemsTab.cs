using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();
        private List<Item> _displayedItems = new();
        private Item _item;

        /// <summary>
        /// Делегат для сортировки.
        /// </summary>
        private Func<Item, Item, bool> SortCompare { get; set; }

        /// <summary>
        /// Делегат для фильтрации.
        /// </summary>
        private Predicate<Item> FilterCompare { get; set; }

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                UpdateDisplayedItems();
                SortComboBox.SelectedIndex = 0;
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            // Добавляем категории в CategoryComboBox
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

            // Добавляем варианты сортировки в SortComboBox
            SortComboBox.Items.Add("Name");
            SortComboBox.Items.Add("Price Asc");
            SortComboBox.Items.Add("Price Desc");

            // Устанавливаем первый элемент как выбранный
            if (SortComboBox.Items.Count > 0)
            {
                SortComboBox.SelectedIndex = 0;
            }

            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Обновить список товаров на основе фильтрации и сортировки.
        /// </summary>
        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            // Фильтрация
            if (FilterCompare != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterCompare);
            }

            // Сортировка
            if (SortCompare != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortCompare);
            }

            _displayedItems = displayedItems;
            UpdateDisplayedItemsListBox();
        }

        /// <summary>
        /// Обновить элементы в ListBox.
        /// </summary>
        private void UpdateDisplayedItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name} стоит - {item.Cost}");
            }
        }

        /// <summary>
        /// Изменить сортировку по выбранному критерию.
        /// </summary>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0: // По имени
                    SortCompare = (firstItem, secondItem) => firstItem.Name.CompareTo(secondItem.Name) < 0;
                    break;

                case 1: // По возрастанию цены
                    SortCompare = (firstItem, secondItem) => firstItem.Cost.CompareTo(secondItem.Cost) < 0;
                    break;

                case 2: // По убыванию цены
                    SortCompare = (firstItem, secondItem) => firstItem.Cost.CompareTo(secondItem.Cost) > 0;
                    break;
            }

            UpdateDisplayedItems();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                FilterCompare = null; // Показываем весь список
            }
            else
            {
                FilterCompare = item => item.Name.Contains(query, StringComparison.OrdinalIgnoreCase);
            }

            UpdateDisplayedItems();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Category selectedCategory = (Category)Enum.Parse(typeof(Category), CategoryComboBox.SelectedItem.ToString());

                float cost = float.Parse(CostTextBox.Text);
                Item addItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, cost, selectedCategory);

                _items.Add(addItem);

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

                UpdateDisplayedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении - " + ex.Message);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _displayedItems.Count)
            {
                _item = _displayedItems[ItemsListBox.SelectedIndex];
                NameTextBox.Text = _item.Name;
                DescriptionTextBox.Text = _item.Info;
                CostTextBox.Text = _item.Cost.ToString();
                IdTextBox.Text = _item.Id.ToString();
                CategoryComboBox.SelectedItem = _item.Category;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    var selectedItem = _displayedItems[ItemsListBox.SelectedIndex];
                    _items.Remove(selectedItem);

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

                UpdateDisplayedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении - " + ex.Message);
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
                    _item.Name = NameTextBox.Text;
                    UpdateDisplayedItems();
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
                    _item.Info = DescriptionTextBox.Text;
                    UpdateDisplayedItems();
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
                float cost = float.Parse(CostTextBox.Text);

                ValueValidator.AssertOnPositiveValue((double)cost, 0, 100000, nameof(Item.Cost));

                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _item.Cost = cost;
                    UpdateDisplayedItems();
                }
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length == 0)
            {
                FilterCompare = null;
            }
            else
            {
                FilterCompare = (item) => { return item.Name.Contains(SearchTextBox.Text); };
            }

            UpdateDisplayedItems();
        }
    }
    
}
