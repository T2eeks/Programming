using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет клиента в системе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Хранит следующее доступное значение идентификатора для новых клиентов
        /// </summary>
        private static int _nextid  = 1;

        /// <summary>
        /// Хранит уникальный идентификатор клиента
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит полное имя клиента
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Хранит адрес клиента
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина клиента
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Приоритет покупателя
        /// </summary>
        private bool _isPriority = false;

        /// <summary>
        /// Возвращает уникальный идентификатор клиента
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает полное имя клиента. Должно содержать не более 200 символов
        /// </summary>
        public string FullName
        {
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
            get { return _fullname; }
        }

        /// <summary>
        /// Возвращает и задает адрес клиента. Должно содержать не более 500 символов
        /// </summary>
        public Address Address
        {
            set
            {
                _address = value;
            }
            get { return _address; }
        }

        /// <summary>
        /// Возвращает корзину клиента
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
        }

        /// <summary>
        /// Заказы клиента
        /// </summary>
        public List<Order> Orders { get; private set; }

        /// <summary>
        /// Возрващает или задает приоритет клиента
        /// </summary>
        public bool IsPriority
        {
            get
            {
                return _isPriority;
            }
            set
            {
                _isPriority = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с указанным полным именем и адресом.
        /// </summary>
        /// <param name="fullname">Полное имя клиента </param>
        /// <param name="address">Адрес клиента </param>
        public Customer(string fullname, Address address)
        {
            _id = _nextid++;
            FullName = fullname;
            Address = address;
            _cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
