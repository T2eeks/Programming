using System.Reflection;
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.IO;
using System.Net.NetworkInformation;

namespace LAB_8
{
    public partial class MainForm : Form
    {
        private List<Product> _products = new List<Product>();
        private Product _currentProduct;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex >= 0 && ProductListBox.SelectedIndex < _products.Count)
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(ManufacturerTextBox.Text) || CategoryComboBox.SelectedItem == null || !int.TryParse(QuantityTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Please fill in all fields with valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _products[ProductListBox.SelectedIndex].Name = NameTextBox.Text;
                _products[ProductListBox.SelectedIndex].Manufacturer = ManufacturerTextBox.Text;
                _products[ProductListBox.SelectedIndex].Category = CategoryComboBox.SelectedItem.ToString();
                _products[ProductListBox.SelectedIndex].Amount = Convert.ToInt32(QuantityTextBox.Text);
                ProductsSort();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(ManufacturerTextBox.Text) || CategoryComboBox.SelectedItem == null || !int.TryParse(QuantityTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Пожалуйста, выберите продукт, который нужно удалить.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Product addProduct = new Product(NameTextBox.Text, ManufacturerTextBox.Text, CategoryComboBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                _products.Add(addProduct);
                ProductListBox.Items.Add($"Product called: {addProduct.Name}, Manufacturer: {addProduct.Manufacturer}");

                NameTextBox.Text = "";
                ManufacturerTextBox.Text = "";
                CategoryComboBox.Items.Clear();
                QuantityTextBox.Text = "";

                NameTextBox.BackColor = Color.White;
                ManufacturerTextBox.BackColor = Color.White;
                QuantityTextBox.BackColor = Color.White;

                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());

                ProductsSort();
            }
            catch { }
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedIndex >= 0 && ProductListBox.SelectedIndex < _products.Count)
            {
                _currentProduct = _products[ProductListBox.SelectedIndex];
                NameTextBox.Text = _currentProduct.Name;
                ManufacturerTextBox.Text = _currentProduct.Manufacturer;
                CategoryComboBox.SelectedIndex = Convert.ToInt32(Enum.Parse<Category>(_currentProduct.Category));
                QuantityTextBox.Text = _currentProduct.Amount.ToString();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                Validator.AssertStringInRange(NameTextBox.Text);
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ManufacturerTextBox.BackColor = Color.White;
                Validator.AssertStringInRange(ManufacturerTextBox.Text);
            }
            catch (ArgumentException)
            {
                ManufacturerTextBox.BackColor = Color.LightPink;
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int value))
            {

                try
                {
                    Validator.AssertOnPositiveValue(value);
                    QuantityTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    QuantityTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                QuantityTextBox.BackColor = Color.LightPink;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _products.RemoveAt(ProductListBox.SelectedIndex);
                ProductListBox.Items.RemoveAt(ProductListBox.SelectedIndex);

                NameTextBox.Text = "";
                ManufacturerTextBox.Text = "";
                CategoryComboBox.Items.Clear();
                QuantityTextBox.Text = "";

                NameTextBox.BackColor = Color.White;
                ManufacturerTextBox.BackColor = Color.White;
                QuantityTextBox.BackColor = Color.White;

                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            }
            catch { }
        }

        public void ProductsSort()
        {
            _products = _products.OrderBy(s => s.Name).ToList();
            ProductListBox.Items.Clear();

            foreach (var Product in _products)
            {
                ProductListBox.Items.Add($"Product called: {Product.Name}, Manufacturer: {Product.Manufacturer}");
            }
        }
        private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.txt");

            using (FileStream createStream = File.Create(filePath))
            {
                await JsonSerializer.SerializeAsync(createStream, _products);
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.txt");

            if (File.Exists(filePath))
            {
                using (FileStream readStream = new FileStream(filePath, FileMode.Open))
                {
                    _products = await JsonSerializer.DeserializeAsync<List<Product>>(readStream);

                    foreach (var product in _products)
                    {
                        ProductListBox.Items.Add($"Product called: {product.Name}, Manufacturer: {product.Manufacturer}");
                    }
                }
            }
            else
            {
                _products = new List<Product>();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
