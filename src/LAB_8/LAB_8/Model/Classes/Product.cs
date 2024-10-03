using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace LAB_8
{
    /// <summary>
    /// Хранит данные о товаре
    /// </summary>
    internal class Product
    {
   
        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Производитель товара
        /// </summary>
        private string _manufacturer;

        /// <summary>
        /// Категория товара
        /// </summary>
        private string _category;

        /// <summary>
        /// Колличество товара
        /// </summary>
        private int _amount;

        /// <summary>
        /// Возвращает и задает название товара. Должно содержать не более 100 символов
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringInRange(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает производителя товара. Должно содержать не более 100 символов
        /// </summary>
        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                Validator.AssertStringInRange(value);
                _manufacturer = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара. Должно быть из перечисления
        /// </summary>
        public string Category
        {
            set
            {
                if (int.TryParse(value, out var intResult))
                {
                    throw new ArgumentException();
                }
                if (!Enum.TryParse<Category>(value, out var category))
                    throw new ArgumentException();
                _category = value;
            }
            get { return _category; }
        }

        /// <summary>
        /// Возвращает и задает колмчество товара
        /// </summary>
        public int Amount
        {
            get { return _amount; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _amount = value;
            }
        }

        /// <summary>
        ///  Создает новый экземпляр класса Movie <see cref="Product"/
        /// </summary>
        /// <param name="name"> Название товара</param>
        /// <param name="manufacturer">Производитель товара</param>
        /// <param name="category">Категория товара</param>
        /// <param name="amount">Количество товара</param>
        public Product(string name, string manufacturer, string category, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            _amount = amount;
        }
          
        public Product() { }
    }
}
