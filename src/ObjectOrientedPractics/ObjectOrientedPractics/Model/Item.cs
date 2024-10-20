using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет товар в системе
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Хранит следующее доступное значение идентификатора для новых товаров
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Хранит уникальный идентификатор товара
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит описание товара
        /// </summary>
        private string _info;

        /// <summary>
        /// Хранит стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор товара
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает название товара. Должно содержать не более 200 символов
        /// </summary>
        public string Name
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
            get { return _name; }
        }

        /// <summary>
        /// Возвращает и задает описание товара. Должно содержать не более 1000 символов
        /// </summary>
        public string Info
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
            get { return _info; }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должна быть положительной и не превышать 100000
        /// </summary>
        public double Cost
        {
            set
            {
                ValueValidator.AssertOnPositiveValue(value, 100000, nameof(Cost));
                _cost = value;
            }
            get { return _cost; }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с указанным названием, описанием и стоимостью.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара. </param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = _nextId++;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
