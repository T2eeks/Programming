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
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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
        private float _cost;

        /// <summary>
        /// Событие, возникающее при изменении свойства Name.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие, возникающее при изменении свойства Info.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// Событие, возникающее при изменении свойства Cost.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

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
                if (_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            get { return _info; }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должна быть положительной и не превышать 100000
        /// </summary>
        public float Cost
        {
            set
            {
                ValueValidator.AssertOnPositiveFloatValue(value, 0, 100000, nameof(Cost));
                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
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
        public Item(string name, string info, float cost, Category category)
        {
            _id = _nextId++;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
        public Item(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Создает копию объекта <see cref="Item"/>.
        /// </summary>
        /// <returns>Копия объекта в <see cref="object"/>.</returns>
        public object Clone()
        {
            var item = new Item(this.Id);
            item.Name = this.Name;
            item.Info = this.Info;
            item.Cost = this.Cost;
            item.Category = this.Category;
            return item;
        }
        /// <summary>
        /// Проверяет равенство исходного объект с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Item"/>.</param>
        /// <returns>Возвращает булевое значение, равны ли объекты.</returns>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return this.Id == other.Id;
        }
        /// <summary>
        /// Сравнивает исходный объект с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Item"/>.</param>
        /// <returns>
        /// 0 - Если цены равны;
        /// 1 - Если у исходного объекта цена выше;
        /// -1 - Если у передаваемого объекта цена выше.
        /// </returns>
        public int CompareTo(Item other)
        {
            if (this.Cost == other.Cost)
            {
                return 0;
            }
            else if (this.Cost > other.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
