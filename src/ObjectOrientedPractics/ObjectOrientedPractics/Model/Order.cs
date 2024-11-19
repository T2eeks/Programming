using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Хранит следующее доступное значение идентификатора для заказа
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Хранит уникальный идентификатор заказа
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Время создания заказа
        /// </summary>
        private readonly DateTime _creationDate;

        /// <summary>
        /// Адрес доставки 
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Статус заказа
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Список товарок в заказе
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает уникальный идентификатор клиента 
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату создания заказа
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        /// <summary>
        /// Возвращает или задает адрес доставки
        /// </summary>
        public Address DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = value; }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        

        /// <summary>
        /// Возвращает или задает список товаров в заказе
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Вычисляет и возвращает общую стоимость заказа, суммируя стоимость всех товаров
        /// </summary>
        public double TotalAmount
        {
            get
            {
                double total = 0.0;
                foreach (Item item in _items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/> с указанным адресом доставки и списком товаров
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки </param>
        /// <param name="items">Список товаров </param>
        public Order(Address deliveryAddress, List<Item> items)
        {
            _id = _nextId++;
            _creationDate = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            Status = OrderStatus.New;
            Items = items;
        }

    }
}
