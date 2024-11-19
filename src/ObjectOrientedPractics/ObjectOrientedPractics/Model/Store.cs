using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин, который содержит список товаров и клиентов.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров, доступных в магазине.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список клиентов, зарегистрированных в магазине.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задает список товаров.
        /// </summary>
        public List<Item> Items
        {
           
            set { _items = value; }
            get { return _items; }

        }

        /// <summary>
        /// Возвращает или задает список клиентов.
        /// </summary>

        public List<Customer> Customers
        {

            set { _customers = value; }
            get { return _customers; }

        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store() 
        { 
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

    }
}
