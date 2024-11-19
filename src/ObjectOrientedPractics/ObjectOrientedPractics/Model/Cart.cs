using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет корзину покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров, добавленных в корзину.
        /// </summary>

        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает или задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get  { return _items;} 
            set { _items = value;}
        }

        // <summary>
        /// Рассчитывает и возвращает общую стоимость товаров в корзине.
        /// Если корзина пуста, возвращает 0.0.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                double totalAmount = 0.0;
                foreach (Item item in _items)
                {
                    totalAmount += item.Cost;

                }
                return totalAmount;
            }
        }
    }
}
